using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var calculateTax = CalculateTax(meal_cost, tax_percent);
            var calculateTip = CalculateTip(meal_cost, tip_percent);
            var result = meal_cost + calculateTax + calculateTip;
            var answer =  (int)Math.Round(result, MidpointRounding.ToEven);
            Console.WriteLine(answer);
        }
        public static double CalculateTax(double cost, double taxPercent)
        {
            double tax = cost * (taxPercent / 100);
            return tax;

        }
        public static double CalculateTip(double mealCost, int tipPercent)
        {
            var tip = mealCost * ((double)tipPercent / 100);
            return tip;

        }

        static void Main(string[] args)
        {
            //double mealCost;
            //int tipPercent;
            //int taxPercent;
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);

            //mealCost = double.Parse(Console.ReadLine());
            //tipPercent = int.Parse(Console.ReadLine());
            //taxPercent = int.Parse(Console.ReadLine());

            //var result = new CalculateMealTotal(mealCost, tipPercent, taxPercent);
            
            //Console.WriteLine(result.MealTotal().ToString("N2"));

            Console.ReadLine();
        }

    }
    public class CalculateMealTotal
    {
        private double mealCost;
        private int tipPercent;
        private int taxPercent;

        public CalculateMealTotal(double mealCost, int tipPercent, int taxPercent)
        {
            this.mealCost = mealCost;
            this.tipPercent = tipPercent;
            this.taxPercent = taxPercent;
        }

        public int MealTotal()
        {
            var calculateTax = CalculateTax(mealCost, taxPercent);
            var calculateTip = CalculateTip(mealCost, tipPercent);
            var result = mealCost + calculateTax + calculateTip;
            return (int)Math.Round(result, MidpointRounding.ToEven);

        }


        public double CalculateTax(double cost, double taxPercent)
        {
            double tax = cost * (taxPercent / 100);
            return tax;

        }
        public double CalculateTip(double mealCost, int tipPercent)
        {
            var tip = mealCost * ((double)tipPercent / 100);
            return tip;

        }


    }
}
