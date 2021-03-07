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
    public partial class Form1 : Form
    {
        public Form1()
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
            string query1 = "SELECT * FROM Procesor";
            string query2 = "SELECT * FROM RAM";
            string query3 = "SELECT * FROM HDD";

            getData(query1);
            getData(query2);
            getData(query3);
        }

       
    }
}
