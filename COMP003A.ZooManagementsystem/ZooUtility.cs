// Author: Alvaro Pulido
// Course: COMP003A
// Faculty: Jonathan Cruz
// Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementsystem
{
    /// <summary>
    /// Class for describing an animal
    /// </summary>
    internal class ZooUtility
    {
        /// <summary>
        /// Calls for the name of the animal.
        /// </summary>
        /// <param name="name">Name of the animal</param>
        
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Name: {name}");
        }
        /// <summary>
        /// Prints the name and species of the animal.
        /// </summary>
        /// <param name="name">Name of the animal.</param>
        /// <param name="species">Species of the animal.</param>

        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"Species: {species}");
        }
        /// <summary>
        /// Prints the name, species, and age of the animal.
        /// </summary>
        /// <param name="name">Name of the animal</param>
        /// <param name="species">Species of the animal</param>
        /// <param name="age">Age of the animal</param>

        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"Age: {age}");
        }
    }
}
