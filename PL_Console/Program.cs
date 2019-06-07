using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace PL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Trainee trainee = new Trainee
                {
                    Address = new Address { City = "JLM", Number = 21, Street = "Baruch Duvdivani" },
                    BirthDay = new DateTime(1997, 11, 26),
                    Email = new System.Net.Mail.MailAddress("example@website.com"),
                    FirstName = "Steve",
                    LastName = "Rodgers",
                    ID = "111111118"
                };

                Console.WriteLine(trainee);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
