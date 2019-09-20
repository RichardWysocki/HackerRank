using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var logger = new Logger(@"log.txt");
            //var singletonlogger = new LoggerSingleton(@"log_Singleton.txt");
            //singletonlogger.Init();
            //var runLoggers = new RunLoggers(logger, singletonlogger);

            var runLoggers = new RunLoggers();
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            runLoggers.RunLoggerNonAsync(new Logger(@"log.txt"));
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------");


            stopwatch.Restart();
            //await runLoggers.RunLoggerSingletonParallel(new LoggerSingleton(@"log_Singleton.txt"));
            await runLoggers.RunLoggerSingletonParallel(Singleton.Instance);
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

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
            Console.WriteLine("End Program");


        }
    }

}
