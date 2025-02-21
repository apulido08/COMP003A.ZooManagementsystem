

namespace COMP003A.ZooManagementsystem
{
    internal class ZooUtility
    {
        public static void DescribeAnimal(string name)
        {
            System.Console.WriteLine($"Name: {name}");
        }

        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"Species: {species}");
        }

        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"Age: {age}");
        }
    }
}
