using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiUzduotis
{
    public class Block
    {
        public List<Transaction> TransactionList;

        public int BlockNumber { get; }
        public string BlockHash { get; }
        public int BlockVersion { get; }
        public string TimeMined { get; }
        public int NoOfMessages
        {
            get
            {
                return TransactionList.Count;
            }
        }
        

        public  Block(int blockNumber, string blockHash, int blockVersion, string timeMined)
        {
            BlockNumber = blockNumber;
            BlockHash = blockHash;
            BlockVersion = blockVersion;
            TimeMined = timeMined;
            TransactionList = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            TransactionList.Add(transaction);
        }

    }
}
