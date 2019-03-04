using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Gjurgica", "Nikola" };
            Console.WriteLine("Enter your name");
            Array.Resize(ref names, names.Length+1);
            names[names.Length-1] = Console.ReadLine();
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            char answer;
            do
            {
                Console.WriteLine("Do you want enter another name?" +
                    "Choose 'y' for yes or 'n' for no");
                string input = Console.ReadLine();
                answer = char.Parse(input);
                if (answer != 'y')
                {
                    return;
                }
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = Console.ReadLine();
                foreach(string name in names)
                {
                    Console.WriteLine(name);
                }
                Console.ReadLine();

            }
            while (answer == 'y');
          
        }
    }
}
