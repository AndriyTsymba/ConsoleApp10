using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    public abstract class Device
    {
        public string Name { get; set; }

        public Device(string name)
        {
            Name = name;
        }

        public abstract void Sound();
        public void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }

        public abstract void Desc();
    }

    public class Kettle : Device
    {
        public Kettle() : base("Kettle") { }

        public override void Sound()
        {
            Console.WriteLine("Kettle is boiling...");
        }

        public override void Desc()
        {
            Console.WriteLine("A kettle is used to boil water.");
        }
    }

    public class Microwave : Device
    {
        public Microwave() : base("Microwave") { }

        public override void Sound()
        {
            Console.WriteLine("Microwave is beeping...");
        }

        public override void Desc()
        {
            Console.WriteLine("A microwave is used to heat food.");
        }
    }

    public class Car : Device
    {
        public Car() : base("Car") { }

        public override void Sound()
        {
            Console.WriteLine("Car engine is running...");
        }

        public override void Desc()
        {
            Console.WriteLine("A car is used for personal transportation.");
        }
    }

    public class Steamboat : Device
    {
        public Steamboat() : base("Steamboat") { }

        public override void Sound()
        {
            Console.WriteLine("Steamboat whistle sounds...");
        }

        public override void Desc()
        {
            Console.WriteLine("A steamboat is used for traveling on water.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Device[] devices = new Device[]
            {
            new Kettle(),
            new Microwave(),
            new Car(),
            new Steamboat()
            };

            foreach (var device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine();
            }
        }
    }
}