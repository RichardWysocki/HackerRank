using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Factory;
using DesignPatterns.Repository;
using DesignPatterns.SingletonExample;

namespace DesignPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start Program");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("CHAIN OF RESPONSIBILITY---------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            var chainofResponsilbity = new RunChainofResponsiblity();
            chainofResponsilbity.Run();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("SINGLETON NOT ASYNC-------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            var runLoggers = new RunLoggers();
            var stopwatch = new Stopwatch();
            Console.WriteLine("Singleton");
            stopwatch.Start();
            runLoggers.RunLoggerNonAsync(new Logger(@"log.txt"));
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("SINGLETON IN PARALLEL-----------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            stopwatch.Restart();
            //await runLoggers.RunLoggerSingletonParallel(new LoggerSingleton(@"log_Singleton.txt"));
            await runLoggers.RunLoggerSingletonParallel(Singleton.Instance);
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("NOT SINGLETONIN PARALLEL--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            stopwatch.Restart();
            try
            {
                await runLoggers.RunLoggerNonSingletonParallel(new Logger(@"NotSingleton_log.txt"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("FACTORY PATTERN-----------------------------------------------------------------------------------"); 
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            var transactionTypes = new List<string> { "CreditCard", "CheckingAccount" };
             
            foreach (var type in transactionTypes)
            {
                var defaultbalanceShouldbe = type == "CreditCard" ? 1000 : 12450.25;
                Console.WriteLine($"Starting Factory {type} wih default balance of {defaultbalanceShouldbe}");
                var factory = new CreateFactory();
                var transactionFactory = factory.LoadFactory(type);
                Console.WriteLine("CheckBalance: " + transactionFactory.CheckBalance("12345"));
                Console.WriteLine("Deposit of $75.50: " + transactionFactory.Deposit("12345", 75.50));
                Console.WriteLine("CheckBalance: " + transactionFactory.CheckBalance("12345"));
                Console.WriteLine("WithDraw of $50.25: " + transactionFactory.WithDraw("12345", 50.25));
                Console.WriteLine("CheckBalance: " + transactionFactory.CheckBalance("12345"));
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("REPOSITORY PATTERN-----------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            

            var businessRespository = new BusinessRepository(new LoggerFile(), new LoggerDB());

            foreach (var item in businessRespository.getAllLogs())
            {
                Console.WriteLine($"Log record: {item.Source}");
            }
            
            Console.WriteLine("Adding Records---------------------------------------------------------------------------------------");

            var record = new Log { Error = "Error Source", Source = "Adding a Source" };
            businessRespository.AddDBLog(record);
            businessRespository.AddFileLog(record);
            businessRespository.AddFileLog(record);
            Console.WriteLine("Listing all Data--------------------------------------------------------------------------------------");
            foreach (var item in businessRespository.getAllLogs())
            {
                Console.WriteLine($"Log record: {item.Source}");
            }



            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Console.WriteLine("End Program");
        }
    }

}
