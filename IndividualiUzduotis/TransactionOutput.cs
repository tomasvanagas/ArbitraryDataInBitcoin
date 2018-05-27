using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiUzduotis
{
    public class TransactionOutput
    {
        public string ScriptHex { get; }
        public string ScriptOpCodes
        {
            get
            {
                Bitcoin_Tool.Scripts.Script script = new Bitcoin_Tool.Scripts.Script(DataConverters.StringToByteArray(ScriptHex));
                return script.ToString();
            }
        }

        public TransactionOutput(string script)
        {
            this.ScriptHex = script;
        }
    }
}
