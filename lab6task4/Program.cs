using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler<string, int> scheduler = new TaskScheduler<string, int>(ExecuteTask);

            while (true)
            {
                Console.WriteLine("Enter a task (or 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                Console.WriteLine("Enter priority (integer):");
                if (int.TryParse(Console.ReadLine(), out int priority))
                {
                    scheduler.AddTask(input, priority);
                    Console.WriteLine($"Task added with priority {priority}.");
                }
                else
                {
                    Console.WriteLine("Invalid priority. Task not added.");
                }
            }

            scheduler.ExecuteNext();
        }

        static void ExecuteTask(string task)
        {
            Console.WriteLine($"Executing task: {task}");
        }
    }
    
}
