// Author: Alvaro Pulido
// Course: COMP003A
// Faculty: Jonathan Cruz
// Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementsystem
{
    internal class Parrot : Animal
        /// <summary>
        /// Creates a sub class for the Animal Class
        /// </summary>
        /// <param name="The name of the parrot."</param>
        /// <param name="The species of the parrot."</param
    {
      
        public override void MakeSound()
        {
            Console.WriteLine("The parrot squaks!");
        }
    }
}
