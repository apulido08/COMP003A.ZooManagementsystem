using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementsystem
{
    internal class Lion : Animal
    {
        public string LionName { get; set; }

        public Lion(string lionName, string name, string species)
        {
            LionName = lionName;
            Name = name;
            Species = species;
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }
    }
}
