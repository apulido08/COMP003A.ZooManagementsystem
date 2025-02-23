// Author: [Alvaro Pulido]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
namespace COMP003A.ZooManagementsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {

                Console.WriteLine("Welcome to the Zoo Management System!");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());


            }
        }
    }
}
