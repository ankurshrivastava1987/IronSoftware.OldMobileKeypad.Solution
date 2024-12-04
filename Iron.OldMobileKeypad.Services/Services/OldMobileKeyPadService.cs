using System.Text;
using Iron.Common;
using Iron.OldMobileKeypad.Interfaces;

namespace Iron.OldMobileKeypad.Services
{
    public class OldMobileKeyPadService : IOldMobileKeyPad
    {
        OldMobileKeypadHelper _oldMobileKeypadHelper = new OldMobileKeypadHelper();
        public string ReplaceOldKeypadInputToChar(string str)
        {
            string[] arr = str.Split("*");
            StringBuilder input = new StringBuilder();
            StringBuilder output = new StringBuilder();


            if (arr.Length == 1)
            {
                //if there is no *(back) present in the input string then just call replace method
                output.Append(_oldMobileKeypadHelper.ReplaceNumberToChar(arr[0]));
            }
            else
            {
                /*
                 if there is  *(back) present in the input string then split the input
                 delete a last char from string, if N number of * present then delete N last char
                 then call just call replace method ReplaceNumberToChar foreach string present in array
                */

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    string s2;
                    if (arr[i].Length > 0)
                    {
                        s2 = arr[i].Remove(arr[i].Length - 1);
                        input.Append(s2);

                        if (arr[i + 1].Length != 0)
                            output.Append(_oldMobileKeypadHelper.ReplaceNumberToChar(input.ToString()));

                    }
                    else if (arr[i].Length == 0)
                    {
                        if (input.Length > 0)
                            input.Remove(input.Length - 1, 1);

                        if ((i < arr.Length - 1) && arr[i + 1].Length != 0)
                            output.Append(_oldMobileKeypadHelper.ReplaceNumberToChar(input.ToString()));
                    }
                    output.Append(_oldMobileKeypadHelper.ReplaceNumberToChar(arr[arr.Length - 1].ToString()));
                }
            }
            return output.ToString();
        }

        
    }
}
