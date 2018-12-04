using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2BD
{
    class DepenseEtTouteSesInformations
    {
        public string strNomCompletAbonne { get; private set; }
        public String strDateDepense { get; private set; }
        public decimal dcmMontant { get; private set; }
        public string strTypeService { get; private set; }
        public string strNomCompletEmploye { get; private set; }
        public decimal dcmMontantDesDepenses { get; private set; }
        public decimal dcmMontantObligatoire { get; private set; }
    }
}
