using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Garage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void getData(string query)
        {
            string constring = @"Data Source=(LocalDb)\SE_DB;Initial Catalog=ComputerComponents;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(constring);
            SqlDataAdapter sqlad = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sqlad.Fill(dtbl);

            string data = string.Empty;
            foreach (DataRow row in dtbl.Rows)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item);
                    sb.Append(',');
                    sb.Append(' ');
                  
                }              
                Console.WriteLine(sb);
            }
            Console.WriteLine();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string query1 = "SELECT * FROM Procesor";
            string query2 = "SELECT * FROM RAM";
            string query3 = "SELECT * FROM HDD";

            getData(query1);
            getData(query2);
            getData(query3);*/


            var question1Value = numericUpDown1.Value;
            var question2Text = comboBox1.Text;
            if(question1Value.Equals(0) && question2Text.Equals(""))
            {
                MessageBox.Show("Eroare! Ambele campuri nu au fost completate!");
            }
            if (question1Value.Equals(0) && !question2Text.Equals(""))
            {
                MessageBox.Show("Eroare! Ambele campuri nu au fost completate!");
            }
            if (!question1Value.Equals(0) && question2Text.Equals(""))
            {
                MessageBox.Show("Eroare! Ambele campuri nu au fost completate!");
            }
            if (!question1Value.Equals(0) && !question2Text.Equals(""))
            {
                result1Label.Text = question1Value.ToString() + " lei";
                result2Label.Text = question2Text;
                if(question2Text.Equals("Gaming"))
                {
                    this.Hide();
                    var nextForm = new GamingForm();
                    nextForm.ShowDialog();
                    this.Show();
                }
                if (question2Text.Equals("Office"))
                {
                    this.Hide();
                    var nextForm = new OfficeForm();
                    nextForm.ShowDialog();
                    this.Show();
                }
                if (question2Text.Equals("Design"))
                {
                    this.Hide();
                    var nextForm = new DesignForm();
                    nextForm.ShowDialog();
                    this.Show();
                }
            }          
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
