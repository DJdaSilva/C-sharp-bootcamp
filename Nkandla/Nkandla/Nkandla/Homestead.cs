using System;

namespace SouthAfrica
{
    public class Homestead
    {
        public Homestead(string name)
        {
            this.name = name;
        }

        private string name;

        public string district;

        public string province;

        public string country;

        public string accept(IVisitor visitor)
        {
            Politician politician = visitor as Politician;

            if (politician.politicalParty != "ANC")
            {
                throw new InvalidOperationException("HAMBA WENA!");
            }
            else
            {
                visitor.visit(this);
                return $"Welcome to {this.name}, {politician.getName()}";
            }
        }
    }
}
