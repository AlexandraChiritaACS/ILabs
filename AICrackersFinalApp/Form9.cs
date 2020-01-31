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
    public partial class Form9 : Form
    {
        static int no_questions;
        string[] questions;
        float[] inputs_loaded;
        static int index = 0;
        Form2 f2;

        public Form9()
        {
            string filename = "Philology.txt";
            string text = "";

            System.IO.StreamReader objReader;
            InitializeComponent();

            if (System.IO.File.Exists(filename) == true)
            {
                //System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(filename);
                no_questions = int.Parse(objReader.ReadLine());
                questions = new string[no_questions];
                inputs_loaded = new float[no_questions + 8];

                int i = 0;

                do
                {
                    text = objReader.ReadLine();
                    questions[i++] = text;
                } while (objReader.Peek() != -1);

                objReader.Close();
            }

            else
            {
                MessageBox.Show("No such file " + filename);
            }
        }

        public Form9(Form2 f)
        {
            f2 = f;
            string filename = "Philology.txt";
            string text = "";

            System.IO.StreamReader objReader;
            InitializeComponent();

            if (System.IO.File.Exists(filename) == true)
            {
                //System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(filename);
                no_questions = int.Parse(objReader.ReadLine());
                questions = new string[no_questions];
                inputs_loaded = new float[no_questions + 8];

                int i = 0;

                do
                {
                    text = objReader.ReadLine();
                    questions[i++] = text;
                } while (objReader.Peek() != -1);

                objReader.Close();
            }

            else
            {
                MessageBox.Show("No such file " + filename);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                button4.Visible = false;
            }
            catch
            {

            }

            label1.Text = questions[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (index > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                label1.Text = questions[--index];
                pictureBox1.Visible = false;
                pictures();

                if (index == 5 || index == 8 || index == 10 || index == 16 || index == 17 || index == 22 || index == 23 || index == 24 || index == 25 || index == 29)
                {
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    textBox1.Visible = false;
                    fillRadioBox();
                }

                else
                {
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    textBox1.Visible = true;
                }
            }

            else
            {
                button1.Enabled = false;
            }
        }

        private void fillRadioBox()
        {
            if (index == 5)
            {
                radioButton1.Text = "1914 - 1918";
                radioButton2.Text = "1914 - 1916";
            }

            else if (index == 8)
            {
                radioButton1.Text = "Nero the Emperor";
                radioButton2.Text = "Trajan the Emperor";
                
            }

            if (index == 10)
            {
                radioButton1.Text = "Antoine de Saint-Exupéry";
                radioButton2.Text = "Daniel Defoe";
            }

            if (index == 16)
            {
                radioButton1.Text = "Leo Tolstoy";
                radioButton2.Text = "Fyodor Dostoyevsky";
            }

            if (index == 17)
            {
                radioButton1.Text = "James Matthew Barrie";
                radioButton2.Text = "Lewis Carroll";
            }

            if (index == 22)
            {
                radioButton1.Text = "Zimbabwe";
                radioButton2.Text = "Botswana";
                
            }

            if (index == 23)
            {
                radioButton1.Text = "Poland";
                radioButton2.Text = "Russia";
                
            }

            if (index == 24)
            {
                radioButton1.Text = "English";
                radioButton2.Text = "French";
            }

            if (index == 25)
            {
                radioButton1.Text = "Reykjavik";
                radioButton2.Text = "Oslo";
            }

            if (index == 29)
            {
                radioButton1.Text = "USA";
                radioButton2.Text = "Russia";
            }
        }

        private void pictures()
        {
            if (index == 6)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"pearl.jpg");
            }

            else if (index == 7)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"waterloo.jpg");
            }
        
            else if (index == 8)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"trajan.jpg");
            }

            else if (index == 11)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"gatsby.png");
            }

            else if (index == 12)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"sun.png");
            }

            else if (index == 13)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"sonet106.png");
            }

            else if (index == 22)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"zimbabwe.jpg");
            }

            else if (index == 23)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"russia.png");
            }

            else if (index == 26)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"sea.gif");
            }


            else
            {
                pictureBox1.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            if (index < no_questions - 1)
            {

                button2.Enabled = true;

                label1.Text = questions[++index];
                pictures();


                if (index == 5 || index == 8 || index == 10 || index == 16 || index == 17 || index == 22 || index == 23 || index == 24 || index == 25 || index == 29)
                {
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    textBox1.Visible = false;

                    fillRadioBox();

                }

                else
                {
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    textBox1.Visible = true;
                }
            }

            else
            {
                button3.Visible = true;
                button2.Enabled = false;
                button4.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("1804") || (s.Contains("thousand") && s.Contains("four")) || (s.Contains("eightteen") && s.Contains("four")))
                {
                    inputs_loaded[index] = inputs_loaded[index] + (float)0.4;
                }

                double sentiment = f2.initTextAnalysis(s);
                if (sentiment > 0.7 && sentiment < 0.8)
                {
                    inputs_loaded[index] = inputs_loaded[index] + (float)0.4;
                }

                if (sentiment > 0.8)
                {
                    inputs_loaded[index] = inputs_loaded[index] + (float)0.6;
                }
            }

            else if (index == 5)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            

            else if (index == 6)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("pearl") && s.Contains("harbour"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 7)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("waterlo"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 8)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 9)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("poison"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 10)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 15)
            {
                inputs_loaded[index] = (float)f2.selectResults(@"select * from QuizData
                    where author == 'Jules Verne'", textBox1.Text.ToLower());
            }


            else if (index == 20)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("hanoi"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 21)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("libia") || s.Contains("libya") || s.Contains("russia") || s.Contains("rusia") || s.Contains("usa") || (s.Contains("united") && s.Contains("state")) || s.Contains("arab") || s.Contains("iran") || s.Contains("iraq") || s.Contains("canada") || s.Contains("Venezuela") || s.Contains("niger"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 22)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 23)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 24)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 25)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 26)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("baltic"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 27)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("israeli"))
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }

            else if (index == 28)
            {
                string s = textBox1.Text.ToLower();
                inputs_loaded[index] = 0;
                if (s.Contains("croatia"))
                {
                    inputs_loaded[index] = inputs_loaded[index] + (float)0.5;
                }

                if (s.Contains("germany"))
                {
                    inputs_loaded[index] = inputs_loaded[index] + (float)0.5;
                }
            }

            else if (index == 29)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[index] = 1;
                }

                else
                {
                    inputs_loaded[index] = 0;
                }
            }
            

            else
            {
                string s = textBox1.Text.ToLower();
                inputs_loaded[index] = (float)f2.initTextAnalysis(s);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;

            for (i = 0; i < 10; i++)
            {
                f2.history_score = f2.history_score + inputs_loaded[i];
            }

            for (i = 10; i < 20; i++)
            {
                f2.literature_score = f2.literature_score + inputs_loaded[i];
            }

            for (i = 20; i < 30; i++)
            {
                f2.geography_score = f2.geography_score + inputs_loaded[i];
            }

            f2.philology_score = (float)((f2.history_score + f2.literature_score + f2.geography_score) / 3.0);
            f2.setB4();
            f2.setL5(((int)f2.philology_score).ToString() + "%");
            f2.Visible = true;
            Dispose();

        }
    }
}
