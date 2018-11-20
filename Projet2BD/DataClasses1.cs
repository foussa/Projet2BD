namespace Projet2BD
{
    public partial class Abonnements
    {
        public string IdEtNomComplet { get { return $"{Id} ({Prenom} {Nom})"; } }
    }
}