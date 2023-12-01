using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Park
{
    public class Elephant :Animal, IWalk, IEat, ISleep
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Elephant(string name, string sound, double height, double weight) :base(name, sound)
        {
            Height = height;
            Weight = weight;
        }

        public void Walk()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is walking.");
            Console.WriteLine("      _..--\"\"\"--.._");
            Console.WriteLine("    .'             '.");
            Console.WriteLine("   /   O           O \\");
            Console.WriteLine("  :            ()    :");
            Console.WriteLine("   \\   .           . /");
            Console.WriteLine("    '._'._'._'._'._'");
        }

        public void Eat()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is eating.");
            Console.WriteLine("       __.-.");
            Console.WriteLine("      |__|__|");
            Console.WriteLine("     (@)  (@)");
            Console.WriteLine("     \\        /");
            Console.WriteLine("      \\      /");
            Console.WriteLine("      / @__@ \\");
            Console.WriteLine("      |      |");
            Console.WriteLine("     _\\    /_");
        }

        public void Sleep()
        {
            Console.WriteLine($"Name :{Name} sound: {Sound} height: {Height} weight {Weight} is sleeping.");
            Console.WriteLine("        Zzzz");
            Console.WriteLine("      Zzzz");
            Console.WriteLine("    Zzzz");
            Console.WriteLine("  Zzzz");
            Console.WriteLine("Zzzz");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Height,-10} {Weight,-10}";
        }
    }
}
