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
    public partial class DesignForm : Form
    {
        public DesignForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Boolean[] selected = new Boolean[8];

            for (int index = 0; index < 8; index++)
            {
                selected[index] = false;
            }

            foreach(object app in listBox1.SelectedItems)
            {
                if (app.ToString().Equals("Adobe Photoshop"))
                    selected[0] = true;

                if (app.ToString().Equals("Adobe Ilustrator"))
                    selected[1] = true;

                if (app.ToString().Equals("CorelDRAW"))
                    selected[2] = true;

                if (app.ToString().Equals("GIMP"))
                    selected[3] = true;

                if (app.ToString().Equals("Blender"))
                    selected[4] = true;

                if (app.ToString().Equals("Autodesk 3ds Max"))
                    selected[5] = true;

                if (app.ToString().Equals("PaintShop Pro"))
                    selected[6] = true;

                if (app.ToString().Equals("Autodesk Maya"))
                    selected[7] = true;
            }

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_PHOTOSHOP, selected[0]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_ILLUSTRATOR, selected[1]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_CORELIDRAW, selected[2]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_GIMP, selected[3]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_BLENDER, selected[4]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_3DSMAX, selected[5]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_PAINTSHOP, selected[6]);

            Globals.inputRule.setField(RuleFields.RULE_DESIGN_MAYA, selected[7]);


            MessageBox.Show("Datele au fost salvate!",
                            "Succes",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
