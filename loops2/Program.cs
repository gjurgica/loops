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
            string[] names = new string[] { "Jimy","Monica"};
            string answer = "";
            do
            {
                Console.WriteLine("Enter a name");
                Array.Resize(ref names, names.Length + 1);
                names[names.Length-1] = Console.ReadLine();
                Console.WriteLine("Do you want enter another name? Y/N");
                answer = Console.ReadLine();
            }
            while (answer == "Y");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
          
        }
    }
}
