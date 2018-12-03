using System;

namespace Projet2BD
{
    class Depense
    {
        public decimal montant { get; set; }
        public DateTime date { get; set; }
        public string typeService { get; set; }
        public string nomCompletEmploye { get; set; }
        public string nomCompletAbonne { get; set; }
        public int annee { get; set; }
    }
}