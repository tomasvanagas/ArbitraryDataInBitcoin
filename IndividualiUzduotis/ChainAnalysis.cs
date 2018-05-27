using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace IndividualiUzduotis
{
    public class ChainAnalysis
    {
        public JObject jsonBlockchainData;
        ChainAnalysisWindow chainAnalysisWindowObject;
        int maxOutputs;
        string jsonSavePath;

        public async Task AnalyseChain(string pathToChain, string jsonSavePath, int maxOutputs, ChainAnalysisWindow chainAnalysisWindowObject)
        {
            this.chainAnalysisWindowObject = chainAnalysisWindowObject;
            BitcoinBlockchain.Parser.IBlockchainParser blockchainParser;
            this.maxOutputs = maxOutputs;
            this.jsonSavePath = jsonSavePath;

            try
            {
                blockchainParser = new BitcoinBlockchain.Parser.BlockchainParser(pathToChain, "blk00000.dat");

                // Starting analysis
                try
                {
                    chainAnalysisWindowObject.StartAnalysisButton.Content = "Analysing Please Wait...";
                    chainAnalysisWindowObject.StartAnalysisButton.IsEnabled = false;
                    jsonBlockchainData = new JObject();
                    await ExtractBlockchainAsync(blockchainParser, jsonBlockchainData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exeption information:\n\n\n" + ex.ToString(), "Error");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not analyse this path, wrong path?\n\nExeption information:\n\n\n" + ex.ToString(), "Error");      
            }
        }

        async Task ExtractBlockchainAsync(BitcoinBlockchain.Parser.IBlockchainParser blockchainParser, JObject jsonBlockchainData)
        {
            int blockNo = 0;
            foreach (BitcoinBlockchain.Data.Block block in blockchainParser.ParseBlockchain())
            {
                ExtractBlock(block, jsonBlockchainData);

                blockNo++;
                
                if (blockNo == 472140)
                    break;

                if (chainAnalysisWindowObject.IsActive == false)
                {
                    break;
                }

                if ((blockNo / 4721) * 4721 == blockNo)
                {
                    chainAnalysisWindowObject.AnalysisProgressBar.Value = (blockNo / 4721);
                    await Task.Delay(10);
                }
                    
            }
            File.WriteAllText(jsonSavePath, jsonBlockchainData.ToString());
            chainAnalysisWindowObject.StartAnalysisButton.Content = "Start Analysis";
            chainAnalysisWindowObject.StartAnalysisButton.IsEnabled = true;
        }

        // Block Analysis
        void ExtractBlock(BitcoinBlockchain.Data.Block block, JObject jsonBlockchainData)
        {
            JObject jsonBlockTransactions = new JObject();
            foreach (BitcoinBlockchain.Data.Transaction transaction in block.Transactions)
            {
                ExtractTransaction(transaction, jsonBlockTransactions);
            }
            if (jsonBlockTransactions.Count > 0)
            {
                dynamic jsonBlock = new JObject();
                jsonBlock.BlockTime = block.BlockHeader.BlockTimestamp.ToString();
                jsonBlock.BlockVersion = block.BlockHeader.BlockVersion;
                //jsonBlock.MerkleRootHash = block.BlockHeader.MerkleRootHash.ToString();
                jsonBlock.Transactions = jsonBlockTransactions;
                jsonBlockchainData[block.BlockHeader.BlockHash.ToString()] = jsonBlock;
            }
        }

        // Transaction Analysis
        void ExtractTransaction(BitcoinBlockchain.Data.Transaction transaction, JObject jsonBlockTransactions)
        {
            bool message = true;
            JArray jsonTxOutputs = new JArray();
            if (transaction.Outputs.Count > 10)
            {
                // Check 
                foreach (BitcoinBlockchain.Data.TransactionOutput transactionOutput in transaction.Outputs)
                {
                    if (transactionOutput.OutputValueSatoshi > (ulong)maxOutputs)
                    {
                        message = false;
                        break;
                    }
                }

                if (message)
                {
                    foreach (BitcoinBlockchain.Data.TransactionOutput transactionOutput in transaction.Outputs)
                    {
                        ExtractTransactionOutput(transactionOutput, jsonTxOutputs);
                    }

                    if (jsonTxOutputs.Count > 0)
                    {
                        dynamic jsonTransaction = new JObject();
                        jsonTransaction.Out = jsonTxOutputs;
                        jsonBlockTransactions[transaction.TransactionHash.ToString()] = jsonTransaction;
                    }
                }
            }
        }

        // Transaction Output Analysis
        void ExtractTransactionOutput(BitcoinBlockchain.Data.TransactionOutput transactionOutput, JArray jsonTxOutputs)
        {
            string txOut = transactionOutput.OutputScript.ToString();
            dynamic jsonOutputScript = new JObject();
            jsonOutputScript.Script = txOut;
            jsonTxOutputs.Add(jsonOutputScript);
        }
    }
}
