using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RunLoggers
    {
        public RunLoggers()
        {
            
            
        }

        public async Task RunLoggerSingletonParallel()
        {
            Console.WriteLine("Starting.... RunLoggerSingletonParallel");

            var logger = new LoggerSingleton(@"log.txt");
            logger.Init();


            var TaskList = new List<Task<bool>>()
            {
                Task.Run(() => new EmailManager(logger).SendEmail("1 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("2 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("3 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("4 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("5 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("6 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("7 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("8 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("9 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("10 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("11 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("12 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("13 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("14 - RichardWysocki@gmail.com" )),
                Task.Run(() => new EmailManager(logger).SendEmail("15 - RichardWysocki@gmail.com" ))
            };

            //var task1 = new Task(); GetAsync(1);
            //var task2 = GetAsync(2)
            await Task.WhenAll(TaskList.ToArray()).ConfigureAwait(false);
            var result1 = TaskList[0]; // results[0];
            var result2 = TaskList[1].Result; //TaskListresults[1];

            Console.WriteLine("Stopping.... RunLoggerSingletonParallel");
        }

        public async Task RunLoggerNonSingletonParallel()
        {
            Console.WriteLine("Starting.... RunLoggerNonSingletonParallel");

            var logger = new LoggerSingleton(@"log.txt");
            logger.Init();

            try
            {
                var TaskList = new List<Task<bool>>()
                {
                    Task.Run(() => new EmailManager(logger).SendEmail("1 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("2 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("3 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("4 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("5 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("6 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("7 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("8 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("9 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("10 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("11 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("12 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("13 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("14 - RichardWysocki@gmail.com" )),
                    Task.Run(() => new EmailManager(logger).SendEmail("15 - RichardWysocki@gmail.com" ))
                };

                //var task1 = new Task(); GetAsync(1);
                //var task2 = GetAsync(2)

                await Task.WhenAll(TaskList.ToArray()).ConfigureAwait(false);
                var result1 = TaskList[0]; // results[0];
                var result2 = TaskList[1].Result; //TaskListresults[1];
            }
            catch (Exception e)
            {
                //logger.Terminate();
                Console.WriteLine(e);
                // throw;
            }

            Console.WriteLine("Stopping.... RunLoggerNonSingletonParallel");
        }

        public void RunLoggerNonAsync()
        {
            Console.WriteLine("Starting.... RunLoggerNonSingular");

            var logger = new Logger(@"log.txt");
            var emailManager = new EmailManager(logger);
            for (int i = 0; i < 15; i++)
            {
                var result = emailManager.SendEmail($"{i} - RichardWysocki@gmail.com").Result;
            }
            Console.WriteLine("Stopping.... RunLoggerNonSingular");
        }


    }
}
