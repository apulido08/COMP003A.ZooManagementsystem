// Author: Alvaro Pulido
// Course: COMP003A
// Faculty: Jonathan Cruz
// Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementsystem
{
    /// <summary>
    /// Represents the Animal Clss
    /// </summary>
    
    internal abstract class Animal
    {
        private string _name { get; set; }
        private string _species { get; set; }

        public string name;
        public string species;


        /// <summary>
        /// Gets or sets the name of the animal
        /// Throws an error if the input is invalid
        /// </summary>

        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                   throw new ArgumentNullException(nameof(value));
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the species of the animal
        /// Throws an error if input is invalid
        /// </summary>
        
        public string Species
        {
            get { return _species; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                _species = value;

            }
        }
        public abstract void MakeSound();

    }
}

    


