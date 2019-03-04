using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int result = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a five numbers");
                string answer = Console.ReadLine();
                numbers[i] = int.Parse(answer);
            }
            foreach(int num in numbers)
            {
                result += num;
                Console.WriteLine(num);
                
            }
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
