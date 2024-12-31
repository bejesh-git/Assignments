using StaticMethos;

internal class Program
{
    private static void Main(string[] args)
    {

        Arrays ar = new Arrays();
        ar.task1();
        ar.task2();


        //--------------ARRAY TASK----------------
        // /*
       string[] strArray = { "Apple", "Orange", "Mango" };
       while (true) 
       {
           string opt = ar.TaskMenu();

           if (opt.Equals("1"))
               ar.TaskDisplay(strArray);
           else if (opt.Equals("2"))
               strArray = ar.task3(strArray);
           else
           {
               Console.WriteLine("\nPlease select 1 or 2");

           }
       }
       // */

    }
}