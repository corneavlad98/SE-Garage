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
            List<string> selectedApps = new List<string>();
            foreach (object game in listBox1.SelectedItems)
            {
                selectedApps.Add(game.ToString());
            }
            var test = selectedApps;

            MessageBox.Show(String.Join(", ", selectedApps));

        }
    }
}
