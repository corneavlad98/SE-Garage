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
            var result1 = comboBox1.Text;
            MessageBox.Show(result1);
        }
    }
}
