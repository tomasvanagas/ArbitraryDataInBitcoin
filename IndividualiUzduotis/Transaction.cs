using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiUzduotis
{
    public class Transaction
    {
        public List<TransactionOutput> TransactionOutputList;
        public string TransactionHash { get; }
        public int NoOfOutputs
        {
            get
            {
                return TransactionOutputList.Count;
            }
        }

        public Transaction(string transactionHash)
        {
            TransactionHash = transactionHash;
            TransactionOutputList = new List<TransactionOutput>();
        }

        public void AddTransactionOutput(TransactionOutput transactionOutput)
        {
            TransactionOutputList.Add(transactionOutput);
        }

        public string TransactionToAscii()
        {
            StringBuilder hexBlock = new StringBuilder();
            foreach (TransactionOutput txOutput in TransactionOutputList)
            {
                foreach (string outputPart in txOutput.ScriptOpCodes.Split(' '))
                {
                    if (!outputPart.StartsWith("OP_"))
                    {
                        hexBlock.Append(outputPart);
                    }
                }
            }
            return System.Text.Encoding.UTF8.GetString(DataConverters.StringToByteArray(hexBlock.ToString()));
        }
    }
}
