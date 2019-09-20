using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RunLoggers
    {
        public async Task RunLoggerSingletonParallel(ILogBase log)
        {
            Console.WriteLine("Starting.... RunLoggerSingletonParallel");

            var taskList = TaskList(log);
            await Task.WhenAll(taskList.ToArray()).ConfigureAwait(false);
            var result1 = taskList[0]; 
            var result2 = taskList[1].Result; 

            Console.WriteLine("Stopping.... RunLoggerSingletonParallel");
        }

        public async Task RunLoggerNonSingletonParallel(ILogBase log)
        {
            Console.WriteLine("Starting.... RunLoggerNonSingletonParallel");
            
            try
            {
                var taskList = TaskList(log);


                await Task.WhenAll(taskList.ToArray()).ConfigureAwait(false);
                var result1 = taskList[0]; 
                var result2 = taskList[1].Result; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Stopping.... RunLoggerNonSingletonParallel");
        }


        public void RunLoggerNonAsync(ILogBase log)
        {
            Console.WriteLine("Starting.... RunLoggerNonSingular");

            var emailManager = new EmailManager(log);
            for (int i = 0; i < 15; i++)
            {
                var result = emailManager.SendEmail($"{i+1} - RichardWysocki@gmail.com").Result;
            }

            Console.WriteLine("Stopping.... RunLoggerNonSingular");
        }

        private List<Task<bool>> TaskList(ILogBase log)
        {
            var taskList = new List<Task<bool>>()
            {
                Task.Run(() => new EmailManager(log).SendEmail("1 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("2 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("3 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("4 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("5 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("6 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("7 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("8 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("9 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("10 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("11 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("12 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("13 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("14 - RichardWysocki@gmail.com")),
                Task.Run(() => new EmailManager(log).SendEmail("15 - RichardWysocki@gmail.com"))
            };
            return taskList;
        }
    }
}
