using System;

namespace InheritanceAmazon
{

    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); // create instance of class
            var rating = calculator.Calculate(this); // call the calculate method from rate class

            Console.WriteLine("Promote logic changed");

        }

    }

}