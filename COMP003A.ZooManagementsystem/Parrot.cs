using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementsystem
{
    internal class Parrot : Animal
    {
        public string ParrotName { get; set; }

        public Parrot(string parrotName, string name, string species)
        {
            ParrotName = parrotName;
            Name = name;
            Species = species;

        }

        public override void MakeSound()
        {
            Console.WriteLine("The parrot squaks!");
        }
    }
}
