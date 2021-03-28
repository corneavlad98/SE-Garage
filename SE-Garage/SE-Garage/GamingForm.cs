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
    public partial class GamingForm : Form
    {
        public GamingForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Boolean[] selected = new Boolean[15];

            for(int index = 0; index < 15; index++)
            {
                selected[index] = false;
            }

            foreach(object game in listBox1.SelectedItems)
            {
                if (game.ToString().Equals("Grand Theft Auto V"))
                    selected[0] = true;

                if (game.ToString().Equals("Minecraft"))
                    selected[1] = true;

                if (game.ToString().Equals("Fortnite"))
                    selected[2] = true;

                if (game.ToString().Equals("League of Legends"))
                    selected[3] = true;

                if (game.ToString().Equals("Counter-Strike: Global Offensive"))
                    selected[4] = true;

                if (game.ToString().Equals("PlayerUnknown's Battlegrounds 2017"))
                    selected[5] = true;

                if (game.ToString().Equals("Apex Legends"))
                    selected[6] = true;

                if (game.ToString().Equals("Overwatch"))
                    selected[7] = true;

                if (game.ToString().Equals("Rocket League"))
                    selected[8] = true;

                if (game.ToString().Equals("Cyberpunk 2077"))
                    selected[9] = true;

                if (game.ToString().Equals("Call of Duty: Modern Warfare 2019"))
                    selected[10] = true;

                if (game.ToString().Equals("The Witcher 3: Wild Hunt 2015"))
                    selected[11] = true;

                if (game.ToString().Equals("Terraria"))
                    selected[12] = true;

                if (game.ToString().Equals("Borderlands 3"))
                    selected[13] = true;

                if (game.ToString().Equals("Star Wars Battlefront II 2017"))
                    selected[14] = true;
            }

            Globals.inputRule.setField(RuleFields.RULE_GAMING_GTAV, selected[0]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_MINECRAFT, selected[1]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_FORTNITE, selected[2]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_LEAGUEOFLEGENDS, selected[3]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_CSGO, selected[4]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_PUBG, selected[5]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_APEXLEGENDS, selected[6]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_OVERWATCH, selected[7]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_ROCKETLEAGUE, selected[8]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_CYBERPUNK2077, selected[9]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_CODMW, selected[10]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_WITCHER3, selected[11]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_TERRARIA, selected[12]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_BORDERLANDS3, selected[13]);

            Globals.inputRule.setField(RuleFields.RULE_GAMING_STARWARS, selected[14]);

            switch (comboBox1.Text)
            {
                case "Decent":
                    Globals.inputRule.activateField(RuleFields.RULE_GAMING_RUN_DECENT);
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_BINE);
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_FBINE);
                    break;

                case "Bine":
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_DECENT);
                    Globals.inputRule.activateField(RuleFields.RULE_GAMING_RUN_BINE);
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_FBINE);
                    break;

                case "Foarte bine":
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_DECENT);
                    Globals.inputRule.deactivateField(RuleFields.RULE_GAMING_RUN_BINE);
                    Globals.inputRule.activateField(RuleFields.RULE_GAMING_RUN_FBINE);
                    break;
            }

            MessageBox.Show("Datele au fost salvate!",
                            "Succes",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
