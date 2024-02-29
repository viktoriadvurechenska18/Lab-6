using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            Repository<string> stringRepository = new Repository<string>();

            intRepository.Add(17);
            intRepository.Add(5);
            intRepository.Add(23);

            stringRepository.Add("map");
            stringRepository.Add("water");
            stringRepository.Add("book");

            Console.WriteLine("Whole numbers greater than 5:");
            List<int> intResults = intRepository.Find(x => x > 5);
            foreach (int item in intResults)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Strings starting with 'w':");
            List<string> stringResults = stringRepository.Find(x => x.StartsWith("w"));
            foreach (string item in stringResults)
            {
                Console.WriteLine(item);
            }
        }
    }
}
