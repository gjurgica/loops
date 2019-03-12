using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("Enter a twenty numbers");
            for (int i = 0; i < 20; i++)
            {
                string answer = Console.ReadLine();
                numbers[i] = int.Parse(answer);
            }
            foreach(int num in numbers)
            {
                if (num == 0)
                {
                    continue;
                }
                else if(num>99 && num < 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }
    }
}
