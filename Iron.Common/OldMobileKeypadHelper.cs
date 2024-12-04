using System.Text;

namespace Iron.Common
{
    public class OldMobileKeypadHelper
    {
        /// <summary>
        /// method to replace old keypad numer to char
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReplaceNumberToChar(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            sb.Replace("222", "C");
            sb.Replace("22", "B");
            sb.Replace("2", "A");

            sb.Replace("333", "F");
            sb.Replace("33", "E");
            sb.Replace("3", "F");

            sb.Replace("444", "I");
            sb.Replace("44", "H");
            sb.Replace("4", "G");

            sb.Replace("555", "L");
            sb.Replace("55", "K");
            sb.Replace("5", "J");

            sb.Replace("666", "O");
            sb.Replace("66", "N");
            sb.Replace("6", "M");

            sb.Replace("7777", "S");
            sb.Replace("777", "R");
            sb.Replace("77", "Q");
            sb.Replace("7", "P");

            sb.Replace("888", "V");
            sb.Replace("88", "U");
            sb.Replace("8", "T");

            sb.Replace("999", "Z");
            sb.Replace("999", "Y");
            sb.Replace("99", "X");
            sb.Replace("9", "W");

            sb.Replace("#", "");
            sb.Replace(" ", "");
            return sb.ToString();
        }
    }
}
