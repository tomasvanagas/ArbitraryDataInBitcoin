using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiUzduotis
{
    class Find
    {
        public static List<int> String(List<Block> blockList, string part)
        {
            List<int> blockNumbers = new List<int>();
            foreach (Block block in blockList)
            {
                bool contains = false;
                foreach (Transaction transaction in block.TransactionList)
                {
                    if(transaction.TransactionToAscii().Contains(part))
                    {
                        contains = true;
                        break;
                    }
                }
                if(contains)
                {
                    blockNumbers.Add(block.BlockNumber);
                }
            }
            return blockNumbers;
        }
    }
}
