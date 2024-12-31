using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethos
{
    internal class Arrays
    {
       
        public void task1()
        {
            int[] numArray1 = { 15, 30, 45, 60, 75, 100 };
            int number;

            Console.Write("Type the Number To find : ");
            number = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(numArray1, number);
            if (index == -1)
            {
                Console.WriteLine("Unable to Find the Number");
            }
            else
            {
                Console.WriteLine("The number is Found at index " + index);
            }
        }


        public void task2()
        {
            string[] strArray = { "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday", "sunday"};
            string day;


            Console.Write("Enter a week day ");
            day = Console.ReadLine();

            int index = Array.IndexOf(strArray, day.ToLower());

            Console.WriteLine(
                (index == -1) ?
                "Please check the spelling" : 
                (index >= 5) ?
                "It is a Week End" : 
                "It is a Week Day"
                );
           
        }


        private string ToTitleCase(string val)
        {
            return val[0].ToString().ToUpper() + val.Substring(1).ToLower();
        }
        public string[] task3(string[] strArray)
        {
            string fruit;
            bool isFound = false;
            int index = -1;

            Console.Write("\nSearch for a Fruit ");
            fruit = Console.ReadLine();

            foreach (string frt in strArray)
            {
                index++;

                if (fruit.Equals(frt, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\nThe {fruit} is found at index {index}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Unable to find {fruit} in the array");
                Console.Write("\nDo you want to add it?(y/n)");
                string opt = Console.ReadLine();
                if (opt[0].ToString().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Array.Resize(ref strArray, strArray.Length + 1);
                    strArray[strArray.Length - 1] = ToTitleCase(fruit);
                    Console.WriteLine($"{fruit} is added to the array");
                }
                
            }

            return strArray;
        }
        public string TaskMenu()
        {
            Console.WriteLine("\n\nOperation\n1.Display Fruits\n2.Find Fruit");
            Console.Write("\nWhat do you want me to do  ");
            return Console.ReadLine();
        }

        public void TaskDisplay(string[] array)
        {
            Console.Write("\nAvailable Fruits ");
            foreach (string fruit in array) 
            {
                Console.Write($" \"{fruit}\"");
            };
            Console.WriteLine("");
        }
        





    }
}
