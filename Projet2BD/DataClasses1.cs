namespace Projet2BD
{
    public partial class Abonnements
    {
        public string IdEtNomComplet { get { return $"{Id} ({Prenom} {Nom})"; } }
    }

    public partial class Employes
    {
        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }

    public partial class TypesEmploye
    {
        public override string ToString()
        {
            return Description;
        }
    }
}