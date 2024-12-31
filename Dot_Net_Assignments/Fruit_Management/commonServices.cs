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



        public string ToTitleCase(string val)
        {
            return val[0].ToString().ToUpper() + val.Substring(1).ToLower();
        }


        public void DisplayArray(object array)
        {
            Console.Write("You have ");
            if (array is Array arr)
            {
                foreach (var item in arr)
                {
                    Console.Write($" \"{item}\"");
                }
            }
            else 
            { 
                Console.WriteLine("The provided object is not an array."); 
            }            
        }


        public void DisplayList<T>(List<T> list) 
        {
            Console.Write("\nYou have ");
            foreach (var item in list) 
            {
                Console.Write($" \"{item}\"");
            } 
        }

        public void DisplayList<T>(List<T> list,string message)
        {
            Console.Write($"\n{message}");
            foreach (var item in list)
            {
                Console.Write($" \"{item}\"");
            }
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
