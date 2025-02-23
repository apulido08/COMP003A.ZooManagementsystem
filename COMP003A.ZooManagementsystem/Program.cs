// Author: [Alvaro Pulido]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.ComponentModel.Design;
using System.Linq.Expressions;

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
                Console.WriteLine("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                int menu = 0;

                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invaid input. Please enter a valid number");
                }
                if (menu == 1)
                {
                    Lion lion = new Lion();
                    Console.WriteLine("Name of lion: ");
                    lion.Name = Console.ReadLine();

                    Console.WriteLine("Enter the species of the lion: ");
                    lion.Species = Console.ReadLine();

                    animals.Add(lion);
                    Console.WriteLine("Lion added successfully!");
                }

                else if (menu == 2)
                {
                    Parrot parrot = new Parrot();
                    Console.WriteLine("Name of the Parrot: ");
                    parrot.Name = Console.ReadLine();

                    Console.Write("Enter the species of the parrot: ");
                    parrot.Species = Console.ReadLine();
                    animals.Add(parrot);
                    Console.WriteLine("Parrot added successfully!");
                }
                else if (menu == 3)
                {
                    foreach (Animal animal in animals)
                    {
                        Console.WriteLine($" {animal.Name} {animal.Species}");
                        animal.MakeSound();
                    }

                }
                else if (menu == 4)
                {
                    foreach (Animal animal in animals)
                    {
                        Console.WriteLine("DescribeAnimal (name): ");
                        ZooUtility.DescribeAnimal(animal.Name);
                        Console.WriteLine("DescribeAnimal (name and species) :");
                        ZooUtility.DescribeAnimal(animal.Name, animal.Species);
                    }
                }


                else if (menu == 5)
                {
                    Console.WriteLine("Goodbye!");
                }


                } }
        }
    }

