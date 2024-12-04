using System;
using Iron.OldMobileKeypad.Services;

namespace Iron.OldMobileKeypadSolution
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Please enter keypad input string");
            string str = Console.ReadLine();

            /*_______ Sample string for testing _______*/

            //string str = "33#";
            //str = "227*#";
            //str = "4433555 555666#";
            //str = "8 88777444666*664#";
            Console.WriteLine("Input keypad string is : " + str.ToString());
            OldMobileKeyPadService _oldMobileKeyPadService = new OldMobileKeyPadService();
            Console.WriteLine("Output string is : " + _oldMobileKeyPadService.ReplaceOldKeypadInputToChar(str.ToString()));
            Console.ReadLine();          
        }        
    }
}
