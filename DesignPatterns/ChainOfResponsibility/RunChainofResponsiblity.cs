using System;
using DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility;

namespace DesignPatterns.ChainOfResponsibility
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


            var determineTaxRate = new IsUSACountry_Determine();
            var isUSAMaritalStatus = new DetermineUSAMaritalStatus();
            var isOutUSMaritalStatus = new DetermineOutUSAMaritalStatus();
            var isOver100KSalary = new IsOver100KSalary_Determine();
            var taxRate3Percent = new TaxRatePercent(3);
            var taxRate5Percent = new TaxRatePercent(5);
            var taxRate6Percent = new TaxRatePercent(6);
            var taxRate10Percent = new TaxRatePercent(10);



            determineTaxRate.Yes(isUSAMaritalStatus);
            determineTaxRate.No(isOutUSMaritalStatus);
            isUSAMaritalStatus.Yes(isOver100KSalary);
            isUSAMaritalStatus.No(taxRate6Percent);
            isOver100KSalary.Yes(taxRate10Percent);
            isOver100KSalary.No(taxRate3Percent);
            isOutUSMaritalStatus.Yes(taxRate10Percent);
            isOutUSMaritalStatus.No(taxRate5Percent);


            var taxRate = determineTaxRate.Process(new CustomerSurvey
                {Country = "out", Maritalstatus = MaritalStatus.Married, Kids = true, Salary = 50000});
            Console.WriteLine($"Tax rate is {taxRate.TaxRate}");

            var taxRate2 = determineTaxRate.Process(new CustomerSurvey
                { Country = "USA", Maritalstatus = MaritalStatus.Married, Kids = true, Salary = 50000 });
            Console.WriteLine($"Tax rate is {taxRate2.TaxRate}");

            //var listOfTests2 = new string[] { "A", "WelcomeEmailRequest", "TrakItRequest", "NewHireRequest", "something_else" };
            //foreach (var test in listOfTests2)
            //{
            //    var response = newhire.Process(test);
            //    Console.WriteLine($"Answer for {test} is: {response.Name}");
            //}

        }
    }
}
