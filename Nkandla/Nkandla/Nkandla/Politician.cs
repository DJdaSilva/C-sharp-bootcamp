namespace SouthAfrica
{
    public class Politician: Person, IVisitor
    {
        public Politician(string name, PersonType personType)
            :base(name, personType)
        {
        }

        private bool morals;

        private bool corrupt;

        private float bankAccount;

        public string politicalParty;

        public bool visit(Homestead homestead)
        {
            return true;
        }
    }
}
