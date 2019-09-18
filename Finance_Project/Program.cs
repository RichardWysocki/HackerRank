using System;
using Microsoft.Extensions.Configuration;

namespace Finance_Project
{
    class Program
    {

        private static IConfiguration _configuration;

        public Program(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var runProg = new Finance(_configuration);
            runProg.Execute();

        }
    }
}
