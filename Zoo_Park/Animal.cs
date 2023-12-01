using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo_Park
{
    public abstract class Animal
    {
        public string name { get; set; }
        public string sound { get; set; }
       

        public string Name
        {
            get { return name; }
            set
            {
                if(value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Can't use numbers in name");
                }
                name = value;
            }
        }

        public string Sound //call method property
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
            
        }

        public override string ToString()
        {
            return $"{Name, -10} {Sound, -10}";
        }

       
    }
}
