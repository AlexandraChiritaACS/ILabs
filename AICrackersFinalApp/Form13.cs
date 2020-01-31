using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICrackersFinalApp
{
    public partial class Form13 : Form
    {
        Form2 f2;
        NeuralNetwork net = new NeuralNetwork(new int[] { 15, 15, 15, 1 });

        public Form13()
        {
            InitializeComponent();
        }

        public Form13(Form2 f)
        {
            f2 = f;
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            int[] rez = f2.selectParticipants(); 
            this.chart1.Series[0].LegendText = "%";
            this.chart1.Series["Series1"].Points.AddXY("CS/Engineering", rez[0]);
            this.chart1.Series["Series1"].Points.AddXY("Medicine", rez[1]);
            this.chart1.Series["Series1"].Points.AddXY("Economics/Bussiness", rez[2]);
            this.chart1.Series["Series1"].Points.AddXY("History", rez[3]);
            this.chart1.Series["Series1"].Points.AddXY("Geography", rez[4]);
            this.chart1.Series["Series1"].Points.AddXY("Mathematics", rez[5]);
            this.chart1.Series["Series1"].Points.AddXY("Philosophy", rez[6]);
            this.chart1.Series["Series1"].Points.AddXY("Literature", rez[7]);
            this.chart1.Series["Series1"].Points.AddXY("Psihology", rez[8]);
            this.chart1.Series["Series1"].Points.AddXY("Music", rez[9]);
            this.chart1.Series["Series1"].Points.AddXY("Painting", rez[10]);
            this.chart1.Series["Series1"].Points.AddXY("Chemistry", rez[11]);
            this.chart1.Series["Series1"].Points.AddXY("Physics", rez[12]);
        }
    }
}
