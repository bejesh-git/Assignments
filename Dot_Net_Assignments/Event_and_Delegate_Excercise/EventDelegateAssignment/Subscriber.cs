using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateAssignment
{
    internal class Subscriber
    {

        public void start()
        {
            List<string> banedUsers = new List<string>() { "Jack", "Steven", "Mathew" };

            RegisterStudents registerStudents = new RegisterStudents(banedUsers);
            registerStudents.warnAdmin += this.Alarm;
            registerStudents.warnAdmin += this.Email;

            registerStudents.RegisterStudentsMethod();
        }

        public void Alarm(string name)
        {
            Console.WriteLine("!( Alarm )!");
            Console.WriteLine("You have been banned, Contact Admin");
        }

        public void Email(string name)
        {
            Console.WriteLine("\nSending an Mail to the Admin\n");
        }
    }
}
