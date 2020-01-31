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
    public partial class Form11 : Form
    {
        Form2 f2;

        public Form11()
        {
            InitializeComponent();
        }

        public Form11(Form2 f)
        {
            f2 = f;
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            
            //f2.insertResults(firstname, lastname, unicode);
            Dispose();
            f2.Dispose();
        }
    }
}
