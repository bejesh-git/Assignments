// See https://aka.ms/new-console-template for more information

namespace ExercisesCsharp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n#1 Photo book class\n");
            PhotoBook pb1 = new PhotoBook();
            PhotoBook pb2 = new PhotoBook(24);
            PhotoBook pb3 = new BigPhotoBook();

            Console.WriteLine(pb1.GetNumberPages());
            Console.WriteLine(pb2.GetNumberPages());
            Console.WriteLine(pb3.GetNumberPages());



            Console.WriteLine("\n\n#2 Inheritance of objects\n");
            Person[] p = new Person[3];

            Console.WriteLine("Enter 3 Names : ");
            p[0] = new Student(Console.ReadLine());
            p[1] = new Student(Console.ReadLine());
            p[2] = new Teacher(Console.ReadLine());

            ((Student)p[0]).Study();
            ((Student)p[1]).Study();
            ((Teacher)p[2]).Explain();


            Console.WriteLine("\n\n#3 Shapes - Class diagram\n");
            Shapes rec1 = new Rectangle(10, 20);
            Shapes cir1 = new Circle(6);

            Console.WriteLine("Area of Rectangle " + rec1.Area());
            Console.WriteLine("Area of Circle " + cir1.Area());

            Console.WriteLine("Perimeter of Rectangle " + rec1.Perimeter());
            Console.WriteLine("Perimeter of Circle " + cir1.Perimeter());


        }

    }
}