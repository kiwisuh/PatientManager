using System;

namespace Patients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPatients;
            string name;
            int age;
            string healthConcern;
            Users patients = new Users("Kiwi", 20, "anxiety");
            User default_user = new User("", 0, "");
            Console.WriteLine("Enter in number of patients: ");
            numPatients = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= numPatients; i++)
            {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter health concern in 100 characters: ");
                healthConcern = Console.ReadLine();
                patients.addUser(name, age, healthConcern);
            }

            foreach(User i in patients)
            {
                Console.WriteLine("Name of Patient: " + i.GetName() + " and Age: " + i.GetAge() + " and health issues: " + i.GetHealthConcern());
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
