using SE_Garage.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Garage
{
    public partial class OfficeForm : Form
    {
        public OfficeForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Stocare":
                    Globals.inputRule.activateField(RuleFields.RULE_OFFICE_STOCARE);
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_VITEZA);
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_AMBELE);
                    break;

                case "Viteza":
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_STOCARE);
                    Globals.inputRule.activateField(RuleFields.RULE_OFFICE_VITEZA);
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_AMBELE);
                    break;

                case "Ambele":
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_STOCARE);
                    Globals.inputRule.deactivateField(RuleFields.RULE_OFFICE_VITEZA);
                    Globals.inputRule.activateField(RuleFields.RULE_OFFICE_AMBELE);
                    break;
            }

            MessageBox.Show("Datele au fost salvate!",
                            "Succes",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
