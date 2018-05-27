using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IndividualiUzduotis
{
    class ImportJson
    {
        static public void ImportScan(string path, List<Block> listOfBlocks)
        {
            if(File.Exists(path))
            {
                JObject database = JObject.Parse(File.ReadAllText(path));
                foreach (KeyValuePair<string, JToken> jsonBlock in database)
                {
                    Block block = new Block(Convert.ToInt32(jsonBlock.Value.SelectToken("BlockNumber")), jsonBlock.Key, Convert.ToInt32(jsonBlock.Value.SelectToken("BlockVersion")), jsonBlock.Value.SelectToken("BlockTime").ToString());
                    listOfBlocks.Add(block);

                    JObject transactions = (JObject)jsonBlock.Value.SelectToken("Transactions");
                    foreach (KeyValuePair<string, JToken> jsonTransaction in transactions)
                    {
                        Transaction transaction = new Transaction(jsonTransaction.Key);
                        block.AddTransaction(transaction);

                        JToken transactionOutputs = jsonTransaction.Value.SelectToken("Out");
                        foreach (JToken jsonTransactionOutput in transactionOutputs)
                        {
                            TransactionOutput transactionOutput = new TransactionOutput(jsonTransactionOutput.SelectToken("Script").ToString());
                            transaction.AddTransactionOutput(transactionOutput);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist:\nPath: " + path, "Error");
            }
        }
    }
}
