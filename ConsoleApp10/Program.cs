using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public Animal(string name, int age, string habitat)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Habitat: {Habitat}");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
    public class Tiger : Animal
    {
        public string FurColor { get; set; }
        public Tiger(string name, int age, string habitat, string furColor)
            : base(name, age, habitat)
        {
            FurColor = furColor;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fur Color: {FurColor}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars!");
        }
    }
    public class Crocodile : Animal
    {
        public int Length { get; set; }
        public Crocodile(string name, int age, string habitat, int length)
            : base(name, age, habitat)
        {
            Length = length;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Length: {Length} meters");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} growls!");
        }
    }
    public class Kangaroo : Animal
    {
        public double JumpHeight { get; set; }
        public Kangaroo(string name, int age, string habitat, double jumpHeight)
            : base(name, age, habitat)
        {
            JumpHeight = jumpHeight;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Jump Height: {JumpHeight} meters");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a boing sound!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Sher Khan", 5, "Jungle", "Orange with black stripes");
            Crocodile crocodile = new Crocodile("Gator", 8, "Swamp", 5);
            Kangaroo kangaroo = new Kangaroo("Kenny", 3, "Australian Outback", 3.5);
            Console.WriteLine("Tiger Info:");
            tiger.DisplayInfo();
            tiger.MakeSound();
            Console.WriteLine();
            Console.WriteLine("Crocodile Info:");
            crocodile.DisplayInfo();
            crocodile.MakeSound();
            Console.WriteLine();
            Console.WriteLine("Kangaroo Info:");
            kangaroo.DisplayInfo();
            kangaroo.MakeSound();
        }
    }
}