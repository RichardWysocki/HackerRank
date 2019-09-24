using System;

namespace DesignPatterns.ChainOfResponsibly
{
    public class RunChainofResponsiblity
    {
        public void Run()
        {
            var newhire = new NewHireRequest();
            var trakIt = new TrakItRequest();
            var welcome = new WelcomeEmailRequest();

            newhire.Next( welcome);
            welcome.Next(trakIt);


            var listOfTests = new string[] {"A", "WelcomeEmailRequest", "TrakItRequest", "NewHireRequest", "something_else"};
            foreach (var test in listOfTests)
            {
                var response = newhire.Process(test);
                Console.WriteLine($"Answer for {test} is: {response.Name}");
            }
        }
    }
}
