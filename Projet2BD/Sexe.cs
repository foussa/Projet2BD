namespace Projet2BD
{
    class Sexe
    {
        public string Id { get; private set; }
        public string Nom { get; private set; }

        public Sexe(string Id, string Nom)
        {
            this.Id = Id;
            this.Nom = Nom;
        }
    }
}