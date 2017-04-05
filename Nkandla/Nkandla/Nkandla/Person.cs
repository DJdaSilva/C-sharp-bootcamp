namespace SouthAfrica
{
    public class Person
    {
        public Person(string name, PersonType personType)
        {
            this.name = name;
            this.type = personType;
        }

        private string name;

        private PersonType type;

        public uint age;

        public char gender;

        public string getName()
        {
            return this.name;
        }
    }
}
