using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateAssignment
{
    public delegate void bannedUserDelegate(string name);

    public class RegisterStudents
    {
        public event bannedUserDelegate warnAdmin;

        private commonServices service = new commonServices();
        private List<string> bannedUsers = new List<string>();
        private List<string> registeredUsers = new List<string>();

        public RegisterStudents() { }

        public RegisterStudents(List<string> bannedusers) 
        {

            if(bannedusers.Count != 0)
            {
                for (int i = 0; i < bannedusers.Count; i++)
                {
                    bannedusers[i] = service.ToTitleCase(bannedusers[i]);
                }
                this.bannedUsers = bannedusers;
            }
            
        }
      
        public void RegisterStudentsMethod()
        {
            string name;

            while (true) 
            {
                
                name = service.GetInputInTitleCase("\n\n\nYour Name ");

                if(this.bannedUsers.Contains(name))
                {
                    Console.Clear();
                    warnAdmin(name);
                }
                else if (registeredUsers.Contains(name))
                {
                    Console.Clear();
                    Console.WriteLine($"Your addentance is already recorded, {name}!\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\nWelcome {name}!\n");
                    registeredUsers.Add(name);
                }

                if(registeredUsers.Count != 0)
                    service.DisplayList(registeredUsers, "Todays Attendance\n\n");
            }


        }
    }
}
