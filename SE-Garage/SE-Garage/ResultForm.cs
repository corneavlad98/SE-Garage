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
    public partial class ResultForm : Form
    {
        public ResultForm(PC pc, decimal inputBudget, string inputType)
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();

            if (inputType.Equals("Gaming"))
            {
                sb.Append("PC Gaming ");
                pictureBox1.Image = Properties.Resources.case2;
            }
            if (inputType.Equals("Design"))
            {
                sb.Append("PC Design ");
                pictureBox1.Image = Properties.Resources.case3;
            }
            if (inputType.Equals("Office"))
            {
                sb.Append("PC Office ");
                pictureBox1.Image = Properties.Resources.case1;
            }

            sb.AppendFormat("{0} {1} {2}GHz, ", pc.procesor.Producator, pc.procesor.Model, pc.procesor.FrecventaBaza);
            sb.AppendFormat("{0} GB {1}, ", pc.ram.Capacitate, pc.ram.Tip);
            sb.AppendFormat("{0} GB SSD, ", pc.ssd.Capacitate);
            sb.AppendFormat("{0} HDD, ", pc.hdd.Capacitate);
            sb.AppendFormat("{0} {1} {2} {3} GB {4} ", pc.placaVideo.Producator, pc.placaVideo.Serie, pc.placaVideo.Model, pc.placaVideo.DimensiuneMemorie, pc.placaVideo.TipMemorie);

            title.Text = sb.ToString();
          
            priceLabel.Text = "Price: " + pc.Pret.ToString() + " lei";
            budgetLabel.Text = "Your budget: " + inputBudget.ToString() + " lei";

            var dif = pc.Pret - (double)inputBudget;
            if (dif > 500)
            {
                priceLabel.BackColor = Color.Red;
            }
            if (dif <= 500 && dif > 250)
            {
                priceLabel.BackColor = Color.Yellow;
            }
            if (dif <= 250)
            {
                priceLabel.BackColor = Color.LawnGreen;
            }

            setExtraInfo(pc);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void setExtraInfo(PC pc)
        {
            setProcesorInfo(pc);
            setRAMInfo(pc);
            setSSDInfo(pc);
            setHDDInfo(pc);
            setVideoCardInfo(pc);
            setMotherBoardInfo(pc);
        }
        private void setProcesorInfo(PC pc)
        {
            treeView1.Nodes[0].Nodes[0].Text += " " + pc.procesor.Producator;
            treeView1.Nodes[0].Nodes[1].Text += " " + pc.procesor.Serie;
            treeView1.Nodes[0].Nodes[2].Text += " " + pc.procesor.Model;
            treeView1.Nodes[0].Nodes[3].Text += " " + pc.procesor.Socket;
            treeView1.Nodes[0].Nodes[4].Text += " " + pc.procesor.Nucleu;
            treeView1.Nodes[0].Nodes[5].Text += " " + pc.procesor.NumarNuclee;
            treeView1.Nodes[0].Nodes[6].Text += " " + pc.procesor.NumarThreads;
            treeView1.Nodes[0].Nodes[7].Text += " " + pc.procesor.FrecventaBaza + " GHz";
            treeView1.Nodes[0].Nodes[8].Text += " " + pc.procesor.FrecventaTurbo + " GHz";
            treeView1.Nodes[0].Nodes[9].Text += " " + pc.procesor.TehnologieFabricatie + " nm";
            treeView1.Nodes[0].Nodes[10].Text += " " + pc.procesor.PutereTotalaDisipata + " W";
            treeView1.Nodes[0].Nodes[11].Text += " " + pc.procesor.CoolerInclus;
            treeView1.Nodes[0].Nodes[12].Text += " " + pc.procesor.RecomandatGaming;
            treeView1.Nodes[0].Nodes[13].Text += " " + pc.procesor.TipMemorieSuportata;
            treeView1.Nodes[0].Nodes[14].Text += " " + pc.procesor.MemorieMaxSuportata;
            treeView1.Nodes[0].Nodes[15].Text += " " + pc.procesor.FrecventaMemorieSuportata + " Hz";
        }
        private void setRAMInfo(PC pc)
        {
            treeView1.Nodes[1].Nodes[0].Text += " " + pc.ram.Producator;
            treeView1.Nodes[1].Nodes[1].Text += " " + pc.ram.Serie;
            treeView1.Nodes[1].Nodes[2].Text += " " + pc.ram.Tip;
            treeView1.Nodes[1].Nodes[3].Text += " " + pc.ram.Capacitate + " GB";
            treeView1.Nodes[1].Nodes[4].Text += " " + pc.ram.Frecventa + " MHz";
            treeView1.Nodes[1].Nodes[5].Text += " " + pc.ram.LatentaCAS;
            treeView1.Nodes[1].Nodes[6].Text += " " + pc.ram.RecomandatGaming;
            treeView1.Nodes[1].Nodes[7].Text += " " + pc.ram.DualChannelKit;        
        }
        private void setSSDInfo(PC pc)
        {
            treeView1.Nodes[2].Nodes[0].Text += " " + pc.ssd.Producator;
            treeView1.Nodes[2].Nodes[1].Text += " " + pc.ssd.Model;
            treeView1.Nodes[2].Nodes[2].Text += " " + pc.ssd.TipSSD;
            treeView1.Nodes[2].Nodes[3].Text += " " + pc.ssd.FormFactor;
            treeView1.Nodes[2].Nodes[4].Text += " " + pc.ssd.Interfata;
            treeView1.Nodes[2].Nodes[5].Text += " " + pc.ssd.SuportNVMe;
            treeView1.Nodes[2].Nodes[6].Text += " " + pc.ssd.Capacitate + " GB";
            treeView1.Nodes[2].Nodes[7].Text += " " + pc.ssd.CitireMax + " MB/s";
            treeView1.Nodes[2].Nodes[8].Text += " " + pc.ssd.ScriereMax + " MB/s";
            treeView1.Nodes[2].Nodes[9].Text += " " + pc.ssd.TotalBytesWritten;
            treeView1.Nodes[2].Nodes[10].Text += " " + pc.ssd.CriptareDate;
            treeView1.Nodes[2].Nodes[11].Text += " " + pc.ssd.RecomandatGaming;
        }
        private void setHDDInfo(PC pc)
        {
            treeView1.Nodes[3].Nodes[0].Text += " " + pc.hdd.Producator;
            treeView1.Nodes[3].Nodes[1].Text += " " + pc.hdd.Serie;
            treeView1.Nodes[3].Nodes[2].Text += " " + pc.hdd.Interfata;
            treeView1.Nodes[3].Nodes[3].Text += " " + pc.hdd.Capacitate;
            treeView1.Nodes[3].Nodes[4].Text += " " + pc.hdd.Buffer;
            treeView1.Nodes[3].Nodes[5].Text += " " + pc.hdd.Viteza;
            treeView1.Nodes[3].Nodes[6].Text += " " + pc.hdd.FormFactor;
           
        }
        private void setVideoCardInfo(PC pc)
        {
            treeView1.Nodes[4].Nodes[0].Text += " " + pc.placaVideo.Producator;
            treeView1.Nodes[4].Nodes[1].Text += " " + pc.placaVideo.Serie;
            treeView1.Nodes[4].Nodes[2].Text += " " + pc.placaVideo.Model;
            treeView1.Nodes[4].Nodes[3].Text += " " + pc.placaVideo.Intefata;
            treeView1.Nodes[4].Nodes[4].Text += " " + pc.placaVideo.Producator;
            treeView1.Nodes[4].Nodes[5].Text += " " + pc.placaVideo.DimensiuneMemorie;
            treeView1.Nodes[4].Nodes[6].Text += " " + pc.placaVideo.TipMemorie;
            treeView1.Nodes[4].Nodes[7].Text += " " + pc.placaVideo.PortVGA;
            treeView1.Nodes[4].Nodes[8].Text += " " + pc.placaVideo.PortDVI;
            treeView1.Nodes[4].Nodes[9].Text += " " + pc.placaVideo.PortHDMI;
            treeView1.Nodes[4].Nodes[10].Text += " " + pc.placaVideo.PortDP;
            treeView1.Nodes[4].Nodes[11].Text += " " + pc.placaVideo.DimensiuneRacire;
            treeView1.Nodes[4].Nodes[12].Text += " " + pc.placaVideo.RecomandatGaming;
            treeView1.Nodes[4].Nodes[13].Text += " " + pc.placaVideo.Overclocked;
            treeView1.Nodes[4].Nodes[14].Text += " " + pc.placaVideo.PutereDisipata;
        }
        private void setMotherBoardInfo(PC pc)
        {
            treeView1.Nodes[5].Nodes[0].Text += " " + pc.placaDeBaza.Producator;
            treeView1.Nodes[5].Nodes[1].Text += " " + pc.placaDeBaza.Nume;
            treeView1.Nodes[5].Nodes[2].Text += " " + pc.placaDeBaza.Format;
            treeView1.Nodes[5].Nodes[3].Text += " " + pc.placaDeBaza.SocketProcesor;
            treeView1.Nodes[5].Nodes[4].Text += " " + pc.placaDeBaza.ProducatorChipset;
            treeView1.Nodes[5].Nodes[5].Text += " " + pc.placaDeBaza.ModelChipset;
            treeView1.Nodes[5].Nodes[6].Text += " " + pc.placaDeBaza.InterfataGrafica;
            treeView1.Nodes[5].Nodes[7].Text += " " + pc.placaDeBaza.MemorieSuportata;
            treeView1.Nodes[5].Nodes[8].Text += " " + pc.placaDeBaza.MemorieMaxSuportata;
            treeView1.Nodes[5].Nodes[9].Text += " " + pc.placaDeBaza.CanaleMemorie;
            treeView1.Nodes[5].Nodes[10].Text += " " + pc.placaDeBaza.FrecventaMemorie;
            treeView1.Nodes[5].Nodes[11].Text += " " + pc.placaDeBaza.InterfataSDD;
            treeView1.Nodes[5].Nodes[12].Text += " " + pc.placaDeBaza.USB_2;
            treeView1.Nodes[5].Nodes[13].Text += " " + pc.placaDeBaza.USB_3;
            treeView1.Nodes[5].Nodes[14].Text += " " + pc.placaDeBaza.USB_C;
            treeView1.Nodes[5].Nodes[15].Text += " " + pc.placaDeBaza.RJ_45_LAN;
            treeView1.Nodes[5].Nodes[16].Text += " " + pc.placaDeBaza.SuportAudio;
        }

    }
}
