using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var logger = new Logger();
            //mLogger = LoggerSingle.Instance;
            // instantiate the log observer that will write to disk

            var runLoggers = new RunLoggers();
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            runLoggers.RunLoggerNonAsync();
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine(
                "--------------------------------------------------------------------------------------------------");


            stopwatch.Restart();
            await runLoggers.RunLoggerSingletonParallel();
            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------");


            stopwatch.Restart();
            try
            {
                await runLoggers.RunLoggerNonSingletonParallel();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

            stopwatch.Stop();
            Console.WriteLine($"TimeElapsed = {stopwatch.Elapsed}");

            Console.WriteLine(
                "--------------------------------------------------------------------------------------------------");
            Console.WriteLine("End Program");


        }
    }

}
