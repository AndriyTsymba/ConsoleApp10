using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    public abstract class MusicalInstrument
    {
        public string Name { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public abstract void Sound();
        public void Show()
        {
            Console.WriteLine($"Instrument: {Name}");
        }

        public abstract void Desc();
        public abstract void History();
    }

    public class Violin : MusicalInstrument
    {
        public Violin() : base("Violin") { }

        public override void Sound()
        {
            Console.WriteLine("Violin plays a beautiful melody.");
        }

        public override void Desc()
        {
            Console.WriteLine("A violin is a string instrument played with a bow.");
        }

        public override void History()
        {
            Console.WriteLine("The violin dates back to the early 16th century in Italy.");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone") { }

        public override void Sound()
        {
            Console.WriteLine("Trombone plays a deep, sliding sound.");
        }

        public override void Desc()
        {
            Console.WriteLine("A trombone is a brass instrument with a telescoping slide.");
        }

        public override void History()
        {
            Console.WriteLine("The trombone evolved in the 15th century in Europe.");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele") { }

        public override void Sound()
        {
            Console.WriteLine("Ukulele plays a cheerful, plucky tune.");
        }

        public override void Desc()
        {
            Console.WriteLine("The ukulele is a small four-stringed Hawaiian instrument.");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele was brought to Hawaii by Portuguese immigrants in the 19th century.");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello() : base("Cello") { }

        public override void Sound()
        {
            Console.WriteLine("Cello plays a rich and deep tone.");
        }

        public override void Desc()
        {
            Console.WriteLine("The cello is a large string instrument played with a bow.");
        }

        public override void History()
        {
            Console.WriteLine("The cello evolved in the 16th century in Italy.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Cello()
            };

            foreach (var instrument in instruments)
            {
                instrument.Show();
                instrument.Desc();
                instrument.History();
                instrument.Sound();
                Console.WriteLine();
            }
        }
    }
}
