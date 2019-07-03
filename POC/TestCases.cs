using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace POC
{
    [TestFixture]
    class TestCases
    {
        [Test]
        [TestCase("Hacker", "Hce akr")]
        [TestCase("Rank", "Rn ak")]
        [TestCase("Three", "Tre he")]
        [TestCase("Ha ck er", "Ha ck er")]
        [TestCase("Ran k", "Ran k")]
        [TestCase("T hr ee", "T hr ee")]
        public void ValidateConverstion(string input, string answer)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){Name="Beverages", ID=001},
                new Category(){ Name="Condiments", ID=002},
                new Category(){ Name="Vegetables", ID=003},
                new Category() {  Name="Grains", ID=004},
                new Category() {  Name="Fruit", ID=005}
            };

            // Specify the second data source.
            List<Product> products = new List<Product>()
            {
                new Product{Name="Cola",  CategoryID=001},
                new Product{Name="Tea",  CategoryID=001},
                new Product{Name="Mustard", CategoryID=002},
                new Product{Name="Pickles", CategoryID=002},
                new Product{Name="Carrots", CategoryID=003},
                new Product{Name="Bok Choy", CategoryID=003},
                new Product{Name="Peaches", CategoryID=005},
                new Product{Name="Melons", CategoryID=005},
            };
            //var inputA = input.Split(' ').ToList();
            //var inputB = answer.Split(' ').ToList();
            //Arrange
            var Conversion = new Conversion();
            //Act
            var result = Conversion.Run(products, categories);

            //Assert
            Assert.That(answer == result);


        }

    }
}
