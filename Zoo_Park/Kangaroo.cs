using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo_Park
{
    public class Kangaroo : Animal, IWalk, IEat, ISleep
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Kangaroo(string name, string sound, double height, double weight) : base(name, sound)
        {
            Height = height;
            Weight = weight;
        }

        public void Walk()
        {
            Console.WriteLine($" Name : {Name} sound: {Sound} height: {Height} weight {Weight} is walking.");
            Console.WriteLine("    __/");
            Console.WriteLine(" --//\\____");
            Console.WriteLine("   \\______\\");
            Console.WriteLine("   -----");
        }

        public void Eat()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is eating.");
            Console.WriteLine("      (__)");
            Console.WriteLine("      (__)");
        }

        public void Sleep()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is sleeping.");
            Console.WriteLine("    zZzZz");
            Console.WriteLine("   zZzZzZz");
            Console.WriteLine(" zZzZzZzZz");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Height,-10} {Weight,-10}";
        }
    }
}
