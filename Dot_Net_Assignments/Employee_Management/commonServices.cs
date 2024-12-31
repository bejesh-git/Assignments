using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace StaticMethos
{
    internal class commonServices
    {

        public string GetInput(string message = "Enter the Value ")
        {
            Console.Write(message + " ");
            return Console.ReadLine();
        }


        public string GetInputInTitleCase(string message = "Enter the Value ")
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            return input[0].ToString().ToUpper() + input.Substring(1).ToLower();
        }


        

        public string DisplayMenu(string[] menuOptions, string message= "You can ")
        {
            Console.WriteLine("\n\n\n---------------------");
            Console.WriteLine(message);
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }
            Console.Write("\nWhat do You want to do (q: QUIT) ");
            return Console.ReadLine();
        }

    }
}
