using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethos
{
    internal class ListMethods
    {
        
        commonServices cs = new commonServices();


        public void tast1(List<string> fruits)
        {
            for (int i = 0; i < fruits.Count; i++)
                fruits[i] = cs.ToTitleCase(fruits[i]);

            string fruit, option = "c";
            string[] menuOptions = { "Display Fruits", "Add Fruits", "Update Fruits", "Delete Fruits" };

            while (!option[0].ToString().Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n\n\n---------------------");
                Console.WriteLine("You can ");
                for(int i= 0;  i < menuOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                }


                Console.Write("\nWhat do You want to do (q: QUIT) ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        cs.DisplayList(fruits);
                        break;
                    case "2":
                        Console.Clear();
                        fruits = AddFruits(fruits);
                        break;
                    case "3":
                        Console.Clear();
                        fruits = UpdateFruits(fruits);
                        break;
                    case "4":
                        Console.Clear();
                        fruits = DeleteFruits(fruits);
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Closing the Aplication ");
                        break;
                    default:
                        Console.WriteLine("Select a valid option or q to close");
                        break;
                }
            }

        }

        //---------------ADD-------------------
        private List<string> AddFruits(List<string> fruits)
        {
            string fruit;
            cs.DisplayList(fruits, "You already have");
            fruit = cs.GetInputInTitleCase("\nWhat Fruit do You want to Add ");

            if (!fruits.Contains(fruit))
            {
                fruits.Add(fruit);
                Console.WriteLine($"\n{fruit} added successfully");
            }
            else
            {
                Console.WriteLine($"\n{fruit} Already Exists, Try Again");
            }

            return fruits;

        }

        //---------------UPDATE-------------------
        private List<string> UpdateFruits(List<string> fruits)
        {
            string fruit, newFruit;

            int index;
            cs.DisplayList(fruits);
            fruit = cs.GetInputInTitleCase("\nWhat Fruit do You want to Update ");

            if (fruits.Contains(fruit))
            {
                index = fruits.IndexOf(fruit);

            repeat:
                newFruit = cs.GetInputInTitleCase("\nNew Fruit ");    

                if(!fruits.Contains(newFruit))
                {
                    fruits[index] = newFruit;
                    Console.WriteLine($"\n{fruit} updated to {newFruit}");
                }
                else
                {
                    Console.WriteLine($"{newFruit} already exists in the list, Try again");
                    goto repeat;
                }

                
            }
            else
            {
                Console.WriteLine($"\n{fruit} Does not exists, Try Again");
            }

            return fruits;
       
        }

        //---------------DELETE-------------------
        private List<string> DeleteFruits(List<string> fruits)
        {
            string fruit;

            int index;
            cs.DisplayList(fruits);
            fruit = cs.GetInputInTitleCase("\nWhat Fruit do You want to Delete ");

            if (fruits.Contains(fruit))
            {               
                fruits.Remove(fruit);
                Console.WriteLine($"\n{fruit} removed from array");
            }
            else
            {
                Console.WriteLine($"\n{fruit} Does not exists");
            }
            return fruits;
        }

        


    }
}
