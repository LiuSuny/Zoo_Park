using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Park
{
    public class Tigar : Animal, IWalk, IEat, ISleep
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Tigar(string name, string sound, double height, double weight) : base(name, sound)
        {
            Height = height;
            Weight = weight;
        }

        public void Walk()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is walking.");
            Console.WriteLine("      , -.");
            Console.WriteLine("     ( o o )");
            Console.WriteLine("      `- V -'");
        }

        public void Eat()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is eating.");
            Console.WriteLine("     .  ,  .");
            Console.WriteLine("    . \\ | / .");
            Console.WriteLine("   '  ' ' '  ");
        }

        public void Sleep()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is sleeping.");
            Console.WriteLine("   .    .    .");
            Console.WriteLine("    ' .  . ' ");
            Console.WriteLine("     '    '  ");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Height,-10} {Weight,-10}";
        }
    }
}
