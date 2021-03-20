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
using SE_Garage.Classes;

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


        private DataTable initializeDataTable(string query)
        {
            string constring = @"Data Source=(LocalDb)\SE_DB;Initial Catalog=ComputerComponents;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(constring);
            SqlDataAdapter sqlad = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sqlad.Fill(dtbl);

            return dtbl;
        }
        private List<Procesor> setAllProcesors()
        {
            List<Procesor> procesorList = new List<Procesor>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM Procesor");

            foreach (DataRow row in dtbl.Rows)
            {             
                Procesor p = new Procesor
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Serie = Convert.ToString(row[2]),
                    Model = Convert.ToString(row[3]),
                    Socket = Convert.ToString(row[4]),
                    Nucleu = Convert.ToString(row[5]),
                    NumarNuclee = Convert.ToInt32(row[6]),
                    NumarThreads = Convert.ToInt32(row[7]),
                    FrecventaBaza = Convert.ToDouble(row[8]),
                    FrecventaTurbo = Convert.ToDouble(row[9]),
                    TehnologieFabricatie = Convert.ToInt32(row[10]),
                    PutereTotalaDisipata = Convert.ToInt32(row[11]),
                    CoolerInclus = Convert.ToBoolean(row[12]),
                    RecomandatGaming = Convert.ToBoolean(row[13]),
                    TipMemorieSuportata = Convert.ToString(row[14]),
                    MemorieMaxSuportata = Convert.ToInt32(row[15]),
                    FrecventaMemorieSuportata = Convert.ToInt32(row[16]),
                    Pret = Convert.ToDouble(row[17]),
                };
                procesorList.Add(p);            
            }
            return procesorList;
        }
        private List<PlacaDeBaza> setAllMotherBoards()
        {
            List<PlacaDeBaza> motherBoardList = new List<PlacaDeBaza>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM PlacaDeBaza");

            foreach (DataRow row in dtbl.Rows)
            {
                PlacaDeBaza pb = new PlacaDeBaza
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Nume = Convert.ToString(row[2]),
                    Format = Convert.ToString(row[3]),
                    SocketProcesor = Convert.ToString(row[4]),
                    ProducatorChipset = Convert.ToString(row[5]),
                    ModelChipset = Convert.ToString(row[6]),
                    InterfataGrafica = Convert.ToString(row[7]),
                    MemorieSuportata = Convert.ToString(row[8]),
                    MemorieMaxSuportata = Convert.ToInt32(row[9]),
                    CanaleMemorie = Convert.ToInt32(row[10]),
                    FrecventaMemorie = Convert.ToInt32(row[11]),
                    InterfataSDD = Convert.ToString(row[12]),
                    USB_2 = Convert.ToInt32(row[13]),
                    USB_3 = Convert.ToInt32(row[14]),
                    USB_C = Convert.ToInt32(row[15]),
                    RJ_45_LAN = Convert.ToInt32(row[16]),
                    SuportAudio = Convert.ToString(row[17]),
                    Pret = Convert.ToDouble(row[18]),
                };
                motherBoardList.Add(pb);
            }
            return motherBoardList;
        }
        private List<PlacaVideo> setAllVideoCards()
        {
            List<PlacaVideo> videoCardList = new List<PlacaVideo>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM PlacaVideo");

            foreach (DataRow row in dtbl.Rows)
            {
                PlacaVideo pv = new PlacaVideo
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Serie = Convert.ToString(row[2]),
                    Model = Convert.ToString(row[3]),
                    Intefata = Convert.ToString(row[4]),
                    ProducatorChipset = Convert.ToString(row[5]),
                    DimensiuneMemorie = Convert.ToInt32(row[6]),
                    TipMemorie = Convert.ToString(row[7]),
                    PortVGA = Convert.ToBoolean(row[8]),
                    PortDVI = Convert.ToBoolean(row[9]),
                    PortHDMI = Convert.ToBoolean(row[10]),
                    PortDP = Convert.ToBoolean(row[11]),
                    DimensiuneRacire = Convert.ToString(row[12]),
                    RecomandatGaming = Convert.ToBoolean(row[13]),
                    Overclocked = Convert.ToBoolean(row[14]),
                    PutereDisipata = Convert.ToInt32(row[15]),              
                    Pret = Convert.ToDouble(row[16]),
                };
                videoCardList.Add(pv);
            }
            return videoCardList;
        }
        private List<RAM> setAllRAM()
        {
            List<RAM> ramList = new List<RAM>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM RAM");

            foreach (DataRow row in dtbl.Rows)
            {
                RAM r = new RAM
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Serie = Convert.ToString(row[2]),
                    Tip = Convert.ToString(row[3]),
                    Capacitate = Convert.ToInt32(row[4]),
                    Frecventa = Convert.ToInt32(row[5]),
                    LatentaCAS = Convert.ToInt32(row[6]),                  
                    RecomandatGaming = Convert.ToBoolean(row[7]),
                    DualChannelKit = Convert.ToBoolean(row[8]),              
                    Pret = Convert.ToDouble(row[9]),
                };
                ramList.Add(r);
            }
            return ramList;
        }
        private List<SSD> setAllSSD()
        {
            List<SSD> ssdList = new List<SSD>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM SSD");

            foreach (DataRow row in dtbl.Rows)
            {
                SSD s = new SSD
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Model = Convert.ToString(row[2]),
                    TipSSD = Convert.ToString(row[3]),
                    FormFactor = Convert.ToString(row[4]),
                    Interfata = Convert.ToString(row[5]),
                    SuportNVMe = Convert.ToBoolean(row[6]),
                    Capacitate = Convert.ToInt32(row[7]),
                    CitireMax = Convert.ToInt32(row[8]),
                    ScriereMax = Convert.ToInt32(row[9]),
                    TotalBytesWritten = Convert.ToInt32(row[10]),
                    CriptareDate = Convert.ToBoolean(row[11]),
                    RecomandatGaming = Convert.ToBoolean(row[12]),
                    Pret = Convert.ToDouble(row[13]),
                };
                ssdList.Add(s);
            }
            return ssdList;
        }
        private List<HDD> setAllHDD()
        {
            List<HDD> hddList = new List<HDD>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM HDD");

            foreach (DataRow row in dtbl.Rows)
            {
                HDD h = new HDD
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Serie = Convert.ToString(row[2]),
                    Interfata = Convert.ToString(row[3]),
                    Capacitate = Convert.ToString(row[4]),
                    Buffer = Convert.ToInt32(row[5]),
                    Viteza = Convert.ToInt32(row[6]),
                    FormFactor = Convert.ToDouble(row[7]),              
                    Pret = Convert.ToDouble(row[8]),
                };
                hddList.Add(h);
            }
            return hddList;
        }
        private List<Sursa> setAllPowerUnits()
        {
            List<Sursa> sursaList = new List<Sursa>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM Sursa");

            foreach (DataRow row in dtbl.Rows)
            {
                Sursa sr = new Sursa
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Tip = Convert.ToString(row[2]),
                    Putere = Convert.ToInt32(row[3]),
                    Eficienta = Convert.ToInt32(row[4]),
                    RecomandatGaming = Convert.ToBoolean(row[5]),
                    PiniATX_20_4 = Convert.ToInt32(row[6]),
                    PiniATX_EPS_4_4 = Convert.ToInt32(row[7]),
                    PiniPCI_E_6_2 = Convert.ToInt32(row[8]),
                    SATA = Convert.ToInt32(row[9]),
                    Molex = Convert.ToInt32(row[10]),
                    Modulara = Convert.ToBoolean(row[11]),
                    Pret = Convert.ToDouble(row[12]),
                };
                sursaList.Add(sr);
            }
            return sursaList;
        }
        private List<UnitateOptica> setAllOpticUnits()
        {
            List<UnitateOptica> opticaList = new List<UnitateOptica>(6);
            DataTable dtbl = initializeDataTable("SELECT * FROM \"Unitate optica\"");

            foreach (DataRow row in dtbl.Rows)
            {
                UnitateOptica opt = new UnitateOptica
                {
                    ID = Convert.ToInt32(row[0]),
                    Producator = Convert.ToString(row[1]),
                    Model = Convert.ToString(row[2]),
                    Tip = Convert.ToString(row[3]),
                    VitezaScriereCD = Convert.ToInt32(row[4]),
                    VitezaScriereDVD = Convert.ToInt32(row[5]),
                    VitezaCitireCD = Convert.ToInt32(row[6]),
                    VitezaCitireDVD = Convert.ToInt32(row[7]),
                    VitezaCitireBluRay = Convert.ToInt32(row[8]),
                    VitezaScriereBluRay = Convert.ToInt32(row[9]),
                    Interfata = Convert.ToString(row[10]),
                    Pret = Convert.ToDouble(row[11]),
                };
                opticaList.Add(opt);
            }
            return opticaList;
        }



        private List<PC> setAllPCs()
        {
            List<PC> pcList = new List<PC>();
            DataTable dtbl = initializeDataTable("SELECT * FROM PC");

            foreach (DataRow row in dtbl.Rows)
            {        
                PC pc = new PC
                {
                    ID = Convert.ToInt32(row[0]),
                    placaDeBaza = Globals.motherBoardList[Convert.ToInt32(row[1]) - 1],
                    procesor = Globals.procesorList[Convert.ToInt32(row[2]) - 1],
                    placaVideo = Globals.videoCardList[Convert.ToInt32(row[3]) - 1],
                    ram = Globals.ramList[Convert.ToInt32(row[4]) - 1],
                    ssd = Globals.ssdList[Convert.ToInt32(row[5]) - 1],
                    hdd = Globals.hddList[Convert.ToInt32(row[6]) - 1],
                    sursa = Globals.powerUnitList[Convert.ToInt32(row[7]) - 1],
                    unitateOptica = null,

                    Pret = Convert.ToDouble(row[9]),
                };
                pcList.Add(pc);
            }
            return pcList;
        }

        private void testButton_Click(object sender, EventArgs e)
        {

            Globals.procesorList = setAllProcesors();
            Globals.motherBoardList = setAllMotherBoards();
            Globals.videoCardList = setAllVideoCards();
            Globals.ramList = setAllRAM();
            Globals.ssdList = setAllSSD();
            Globals.hddList = setAllHDD();
            Globals.powerUnitList = setAllPowerUnits();
            //Globals.opticalDriveList = setAllOpticUnits();

            Globals.pcList = setAllPCs();

            /*var filtered = Globals.pcList.Select(pc => pc)
                                         .Where(pc => pc.ID == 69)
                                         .ToList();*/

          

            List<object> list = new List<object>();
            DataTable dtbl = initializeDataTable("SELECT * FROM Regula");

            foreach (DataRow row in dtbl.Rows)
            {
                var regula = row;
                var PC = Globals.pcList[Convert.ToInt32(regula[33]) - 1];
            }

        }
    }
}
