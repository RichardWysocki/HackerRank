﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IFooService, FooService>()
                .AddSingleton<IBarService, BarService>()
                .BuildServiceProvider();

            //configure console logging
            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var bar = serviceProvider.GetService<IBarService>();
            bar.DoSomeRealWork();

            logger.LogDebug("All done!");

        }

        public class BarService : IBarService
        {
            private readonly IFooService _fooService;
            public BarService(IFooService fooService)
            {
                _fooService = fooService;
            }

            public void DoSomeRealWork()
            {
                for (int i = 0; i < 10; i++)
                {
                    _fooService.DoThing(i);
                }
            }
        }

        public class FooService : IFooService
        {
            private readonly ILogger<FooService> _logger;
            public FooService(ILoggerFactory loggerFactory)
            {
                _logger = loggerFactory.CreateLogger<FooService>();
            }

            public void DoThing(int number)
            {
                _logger.LogInformation($"Doing the thing {number}");
            }
        }
        public interface IFooService
        {
            void DoThing(int number);
        }

        public interface IBarService
        {
            void DoSomeRealWork();
        }
    }
}
