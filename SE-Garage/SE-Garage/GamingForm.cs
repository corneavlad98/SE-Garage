﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedGames = new List<string>();
            foreach(object game in listBox1.SelectedItems)
            {
                selectedGames.Add(game.ToString());
            }
            var test = selectedGames;
        }
    }
}
