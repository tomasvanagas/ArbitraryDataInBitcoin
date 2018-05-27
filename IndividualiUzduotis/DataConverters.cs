using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiUzduotis
{
    static public class DataConverters
    {
        static public byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string HexToAscii(String hexString)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hexString.Length; i += 2)
            {
                String hs = hexString.Substring(i, i + 2);
                System.Convert.ToChar(System.Convert.ToUInt32(hexString.Substring(0, 2), 16)).ToString();
            }
            String ascii = sb.ToString();
            return ascii;
        }
    }
}
