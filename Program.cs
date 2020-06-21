using System;

namespace Say_My_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qui est tu ?");
            string name = Console.ReadLine();

            Console.WriteLine("Bonjour " + name);
            Console.WriteLine("Quel est ta date de naissance ? ");

            string year = Console.ReadLine();
            int yearNum = int.Parse(year);

            int age = DateTime.Now.Year - yearNum;
            Console.WriteLine("tu as: " + age.ToString());

            if (age < 40)
            {
                Console.WriteLine("tu es encore jeune " + name);
            }
            else
            {
                Console.WriteLine("tu es vieux dis donc Monsieur " + name);
            }

            Console.ReadKey();       

         
            
        }
    }
}
