using System;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;

namespace Projet2BD
{
    public partial class Abonnements
    {
        public string IdEtNomComplet { get { return $"{Id} ({Prenom} {Nom})"; } }
    }
}