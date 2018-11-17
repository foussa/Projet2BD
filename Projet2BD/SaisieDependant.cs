using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class SaisieDependant : UserControl
    {
        Dependants dependant = new Dependants();
        private int noLien;
        private int typeLien;

        public SaisieDependant(int left, int top, int noLien, int typeLien)
        {
            InitializeComponent();
            Left = left;
            Top = top;
            this.noLien = noLien;
            this.typeLien = typeLien;
        }

        private void SaisieDependant_Load(object sender, EventArgs e)
        {
            if (typeLien == 0) lblDependant.Text = "Conjoint";
            else lblDependant.Text = $"Enfant {typeLien}";

            ddlSexes.Items.Add(new { DisplayMember = "Homme", ValueMember = "H" });
            ddlSexes.Items.Add(new { DisplayMember = "Femme", ValueMember = "F" });
            ddlSexes.DisplayMember = "DisplayMember";
            ddlSexes.ValueMember = "ValueMember";
            ddlSexes.SelectedIndex = 0;
        }
    }
}
