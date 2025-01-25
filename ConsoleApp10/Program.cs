using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Passport
    {
        public string PassportNumber { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Citizenship { get; set; }
        public Passport(string passportNumber, string fullName, string dateOfBirth, string citizenship)
        {
            PassportNumber = passportNumber;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Citizenship = citizenship;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Passport Information:");
            Console.WriteLine($"Passport Number: {PassportNumber}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth}");
            Console.WriteLine($"Citizenship: {Citizenship}");
        }
    }
    public class ForeignPassport : Passport
    {
        public string ForeignPassportNumber { get; set; }
        public List<string> Visas { get; set; }
        public ForeignPassport(string passportNumber, string fullName, string dateOfBirth, string citizenship, string foreignPassportNumber)
            : base(passportNumber, fullName, dateOfBirth, citizenship)
        {
            ForeignPassportNumber = foreignPassportNumber;
            Visas = new List<string>();
        }
        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}");
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine($" - {visa}");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args) { 

            Passport passport = new Passport("AB123456", "Ivan Petrov", "01/01/1990", "Ukraine");
            ForeignPassport foreignPassport = new ForeignPassport("CD789012", "Maria Ivanova", "15/06/1985", "Russia", "FX123456");
            foreignPassport.AddVisa("Schengen Visa");
            foreignPassport.AddVisa("USA Visa");
            Console.WriteLine("Passport Info:");
            passport.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine("Foreign Passport Info:");
            foreignPassport.DisplayInfo();
        }
    }
}