using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.Media.IPCamera;
using Ozeki.Media;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.Video.Controls;

namespace AICrackersFinalApp
{
    public partial class Form3 : Form
    {
        static int no_questions;
        string[] questions;
        float[] inputs_loaded;
        static int index = 0;
        static int idx = 0;
        Form2 f2;

        private float[] answers = new float[] { 2, 3, 4, 3, 4};

        public Form3(Form2 f)
        {
            f2 = f;
            string filename = "Economics.txt";
            string text = "";
            System.IO.StreamReader objReader;

            if (System.IO.File.Exists(filename) == true)
            {
                //System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(filename);
                no_questions = int.Parse(objReader.ReadLine());
                questions = new string[no_questions * 6];
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
            InitializeComponent();
        }


        public Form3()
        {
            //string w_file = "TextFile1.txt";
            string filename = "Economics.txt";
            string text = "";
            System.IO.StreamReader objReader;

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
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            try
            {
                button3.Visible = false;
            }
            catch
            {

            }
            label1.Text = questions[index];
            radioButton1.Text = questions[++index];
            radioButton2.Text = questions[++index];
            radioButton3.Text = questions[++index];
            radioButton4.Text = questions[++index];
            idx++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                index = index - 10;
                if (index >= 0)
                {
                    label1.Text = questions[++index];
                    radioButton1.Text = questions[++index];
                    radioButton2.Text = questions[++index];
                    radioButton3.Text = questions[++index];
                    radioButton4.Text = questions[++index];
                    idx--;
                    button1.Enabled = true;
                }
                else
                {
                    index = 4;
                    idx = 0;
                    label1.Text = questions[0];
                    radioButton1.Text = questions[1];
                    radioButton2.Text = questions[2];
                    radioButton3.Text = questions[3];
                    radioButton4.Text = questions[4];
                    idx = 0;
                    button1.Enabled = false;

                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                

            }

            else
            {
                button1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            inputs_loaded[idx] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            inputs_loaded[idx] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            inputs_loaded[idx] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            inputs_loaded[idx] = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (inputs_loaded[i] == answers[i])
                {
                    f2.economics_score++;
                }
            }

            f2.economics_score = f2.economics_score * 20;

            f2.setL2(((int)f2.economics_score).ToString() + "%");
            f2.setB8();
            f2.Visible = true;
            Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (idx < 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                label1.Text = questions[++index];
                radioButton1.Text = questions[++index];
                radioButton2.Text = questions[++index];
                radioButton3.Text = questions[++index];
                radioButton4.Text = questions[++index];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                idx++;
            }

            else
            {
                button3.Visible = true;
                button2.Enabled = false;

            }
        }
    }
}
