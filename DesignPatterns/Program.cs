﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.SingletonExample;

namespace DesignPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start Program");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Console.WriteLine("Chain of Responsibility");
            var chainofResponsilbity = new RunChainofResponsiblity();
            chainofResponsilbity.Run();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            var runLoggers = new RunLoggers();
            var stopwatch = new Stopwatch();
            Console.WriteLine("Singleton");
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
