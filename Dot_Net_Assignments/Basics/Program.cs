using StaticMethos;

internal class Program
{
    private static void Main(string[] args)
    {
       


        StaticMethos.banking b = new StaticMethos.banking(324, "John", 10000);

        int opt;
        double amount;

        Console.WriteLine("Account No : {0}\nAccount Name : {1}\n", b.acctno, b.actname);


        while (true)
        {
           Console.Write("\n\n\nYour Option : \n1.Deposit\n2.WIthdraw\n>>");
           opt = Convert.ToInt32(Console.ReadLine());
           if (opt == 2)
           {
               Console.Write("Withdraw Amount : ");
               amount = Convert.ToDouble(Console.ReadLine());
               if (amount > b.cbalance)
               {
                   Console.WriteLine("Insufficient Funds");
               }
               else
               {
                   b.WithDraw(amount);
                   Console.WriteLine("After Withdrawing {0} Current Balance : {1}", amount, b.cbalance);
               }
           }
           else if (opt == 1)
           {
               Console.Write("Deposit Amount : ");
               amount = Convert.ToDouble(Console.ReadLine());
               b.Deposit(amount);
               Console.WriteLine("After Depositing {0} Current Balance : {1}", amount, b.cbalance);
           }
        }





       


        //-------------Title Case-------------
        string fullname;
        Console.Write("Your Full Name : ");
        fullname = Console.ReadLine();
        string[] nameSplit = fullname.Split(" ");
        for(int i=0; i<nameSplit.Length; i++)
        {
           nameSplit[i] = nameSplit[i].ToLower().Replace(nameSplit[i][0].ToString(), nameSplit[i][0].ToString().ToUpper());
        }
        Console.WriteLine($"\nName : {string.Join(' ',nameSplit)}");


        //-------------Reverse-------------
        string city;
        Console.Write("\n\nYour City : ");
        city = Console.ReadLine();
        char[] cCity = city.ToCharArray();

        city = "";
        foreach (char c in cCity)
        {
           city = c + city;
        }

        Console.WriteLine($"\nCity : {city}");





        //-------------------MAX--------MIN-------------------
        int[] array = { 4, 1, 9, 6, 10, -34, 43 };
        int min=int.MaxValue, max=int.MinValue;

        foreach (int i in array)
        {
           if (i < min) min = i;
           if (i > max) max = i;
        }

        Console.WriteLine("Without Math Function");
        Console.WriteLine($"Minimum = {min}\nMaximum = {max}");



        min = int.MaxValue;
        max = int.MinValue;

        foreach(int i in array)
        {
           min = Math.Min(min, i);
           max = Math.Max(max, i);
        }

        Console.WriteLine("With Math Function");
        Console.WriteLine($"Minimum = {min}\nMaximum = {max}");











        // /* She shells sea shells on the sea shore
        string input;
        int count=0, occ=0;
        Console.Write("Input an Line : ");
        input = Console.ReadLine();
        string[] sInput = input.Split(" ");
        Console.WriteLine("Number of Words : " + sInput.Length);

        Console.Write("Input the Charater to Find Occurance : ");
        char find = Convert.ToChar(Console.ReadLine());

        foreach (char c in input) if (c == find) occ++;

        Console.WriteLine("Total Occurances : "+occ);
        //*/





        /*----------------------Add if Not Available--------------------------
        string frt, rfrt;
        string[] fruits = { "Banana", "Pineapple", "Grape"};
        
        Console.Write("\nFruits >> ");
        foreach (string fruit in fruits) Console.Write(fruit+" ");

        while (true)
        {
            Console.Write("\nWhich Fruit to Remove : ");
            frt = Console.ReadLine();

            bool isAvailable = false;
            for (int i = 0; i < fruits.Length; i++)
            {
                isAvailable = false;
                if (frt.Equals(fruits[i], StringComparison.OrdinalIgnoreCase))
                {
                    isAvailable = true;
                    Console.Write("Replace with : ");
                    rfrt = Console.ReadLine();
                    fruits[i] = rfrt;
                    break;
                }
            }
            if (!isAvailable)
            {
                Console.WriteLine($"{frt} is Not Available in the Array");
                Console.Write("\nDo you want to add it?(y/n)");
                string opt = Console.ReadLine();
                if (opt[0].ToString().ToLower().Equals("y"))
                {
                    Array.Resize(ref fruits, fruits.Length + 1);
                    fruits[fruits.Length - 1] = frt;
                }
            }

            Console.Write("\nFruits >> ");
            foreach (string fruit in fruits) Console.Write(fruit + " ");
            Console.WriteLine("\n\n");
        }
        //*/


    }
}