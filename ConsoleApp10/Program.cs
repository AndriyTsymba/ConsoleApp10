using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
    public class Builder : Human
    {
        public string Specialty { get; set; }
        public Builder(string name, int age, string gender, string specialty)
            : base(name, age, gender)
        {
            Specialty = specialty;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Specialty: {Specialty}");
        }
    }
    public class Sailor : Human
    {
        public string Rank { get; set; }
        public Sailor(string name, int age, string gender, string rank)
            : base(name, age, gender)
        {
            Rank = rank;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Rank: {Rank}");
        }
    }
    public class Pilot : Human
    {
        public string AircraftType { get; set; }
        public Pilot(string name, int age, string gender, string aircraftType)
            : base(name, age, gender)
        {
            AircraftType = aircraftType;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Aircraft Type: {AircraftType}");
        }
    }
    public class Program
    {
        public static void Main(string[] args) { 
        
            Builder builder = new Builder("John Doe", 35, "Male", "Carpentry");
            Sailor sailor = new Sailor("Alex Smith", 28, "Male", "Lieutenant");
            Pilot pilot = new Pilot("Maria Johnson", 40, "Female", "Boeing 737");

            Console.WriteLine("Builder Info:");
            builder.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Sailor Info:");
            sailor.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Pilot Info:");
            pilot.DisplayInfo();
        }
    }
}