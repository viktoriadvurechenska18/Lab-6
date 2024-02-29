using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6task4
{
    internal class TaskScheduler<TTask,TPriority>
    {
        private readonly SortedDictionary<TPriority, Queue<TTask>> taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
        private readonly TaskExecution<TTask> taskExecutor;

        public TaskScheduler(TaskExecution<TTask> taskExecutor)
        {
            this.taskExecutor = taskExecutor;
        }

        public void AddTask(TTask task, TPriority priority)
        {
            if (!taskQueue.ContainsKey(priority))
                taskQueue[priority] = new Queue<TTask>();

            taskQueue[priority].Enqueue(task);
        }

        public void ExecuteNext()
        {
            if (taskQueue.Count > 0)
            {
                var highestPriority = taskQueue.Keys.Min();
                var nextTask = taskQueue[highestPriority].Dequeue();

                taskExecutor(nextTask);

                if (taskQueue[highestPriority].Count == 0)
                    taskQueue.Remove(highestPriority);
            }
            else
            {
                Console.WriteLine("No tasks to execute.");
            }
        }
    }
    public delegate void TaskExecution<TTask>(TTask task);

}
