using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
            NormalizeMoney();
        }

        private void NormalizeMoney()
        {
            if (Cents >= 100)
            {
                Dollars += Cents / 100;
                Cents %= 100;
            }
        }

        public void SetAmount(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
            NormalizeMoney();
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Amount: {Dollars} dollars and {Cents} cents");
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }
        public void ReducePrice(int dollars, int cents)
        {
            Money discount = new Money(dollars, cents);
            int totalCents = (Price.Dollars * 100 + Price.Cents) - (discount.Dollars * 100 + discount.Cents);
            Price.SetAmount(totalCents / 100, totalCents % 100);
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {Name}");
            Price.DisplayAmount();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Money money = new Money(10, 50);
            Product product = new Product("Laptop", money);

            product.DisplayProduct();

            Console.WriteLine("\nReducing the price by 2 dollars and 50 cents...");
            product.ReducePrice(2, 50);
            product.DisplayProduct();
        }
    }
}