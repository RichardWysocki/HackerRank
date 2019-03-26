using System;

namespace Day2
{
    internal class CalculateMealTotals
    {
        private double mealCost;
        private int tipPercent;
        private int taxPercent;

        public CalculateMealTotals(double mealCost, int tipPercent, int taxPercent)
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
            var tip = mealCost * ((double)tipPercent/ 100);
            return tip;

        }


    }
}