namespace COMP003A.ZooManagementsystem
{
    internal abstract class Animal
    {
        private string _name { get; set; }
        private string _species { get; set; }

        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public string Species
        {
            get { return _species; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    _species = value;

            }
        }
        public abstract void MakeSound();

    }
}

    


