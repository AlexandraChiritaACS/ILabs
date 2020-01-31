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
    public partial class Form12 : Form
    {
        static int no_questions;
        string[] questions;
        float[] inputs_loaded;
        static int index = 0;
        static int idx = 0;
        Form2 f2;

        public void train()
        {
            NeuralNetwork net;
            net = new NeuralNetwork(new int[] { 15, 15, 15, 1 });

            net.set(0);

            float[] t1 = new float[] { 5, 5, 3, 3, 3, 4, 2, 1, 5, 2, 4, 3, 2, 1, 5, 3, 2, 1, 1, 1, 1, 1, 4, 3, 4, 3, 1, 2, 1, 3, 5, 3, 3, 2, 4, 5, 5, 0.00300731952f, 5.14648448E-08f, 9.180124E-06f, 0.0001912825f, 0.9875571f, 0.0009861537f, 1.889955E-05f, 0.008229999f };
            float[] t2 = new float[] { 1, 3, 4, 5, 3, 3, 2, 3, 5, 4, 1, 4, 3, 2, 3, 3, 4, 3, 4, 2, 2, 1, 2, 5, 5, 1, 1, 2, 1, 4, 3, 5, 5, 5, 2, 5, 1, 0.0300731952f, 5.14648448E-09f, 0.0002323f, 0.0012825f, 0.98750001f, 0.00000001537f, 1.880005E-05f, 0.00822000f };
            float[] t3 = new float[] { 1, 1, 1, 4, 2, 5, 3, 4, 3, 5, 3, 4, 2, 4, 5, 2, 4, 5, 2, 3, 2, 3, 4, 5, 2, 3, 4, 5, 3, 2, 3, 4, 5, 2, 1, 2, 1, 0.00331952f, 5.1932448448E-04f, 9.183240124E-09f, 0.0001912f, 0.98755f, 0.0009867f, 1.889955f, 0.00899f };
            float[] t4 = new float[] { 5, 5, 4, 3, 4, 5, 3, 4, 3, 4, 5, 5, 5, 4, 5, 3, 4, 5, 4, 4, 5, 4, 5, 4, 3, 4, 3, 4, 3, 4, 5, 5, 5, 4, 4, 5, 4, 0.00300731952f, 5.14648448E-08f, 9.180124E-06f, 0.0001912825f, 0.9875571f, 0.0009861537f, 1.889955E-05f, 0.008229999f };
            float[] t5 = new float[] { 3, 3, 4, 2, 3, 3, 3, 3, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 3, 3, 4, 3, 4, 3, 5, 5, 3, 4, 3, 4, 3, 5, 3, 4, 3, 5, 4, 0.03243231952f, 5.12344648448E-08f, 9.180123424E-06f, 0.0034201912825f, 0.98755271f, 0.061537f, 1.855E-05f, 0.0089f };
            float[] t6 = new float[] { 1, 1, 2, 5, 3, 5, 2, 3, 4, 1, 2, 5, 3, 2, 4, 3, 1, 2, 1, 1, 1, 3, 2, 4, 2, 4, 5, 3, 2, 3, 1, 2, 4, 1, 3, 2, 4, 0.0731952f, 5.1464E-08f, 9.184E-06f, 0.01912825f, 0.987571f, 0.0009537f, 1.89955E-05f, 0.0082294999f };
            float[] t7 = new float[] { 5, 5, 5, 5, 5, 3, 4, 4, 4, 4, 5, 5, 2, 3, 5, 5, 5, 5, 4, 3, 4, 5, 3, 4, 5, 5, 4, 5, 4, 5, 3, 4, 5, 3, 4, 5, 3, 0.00230731952f, 5.23448448E-08f, 9.123424E-06f, 0.0002342825f, 0.9234875571f, 0.00234409861537f, 1.889923432455E-05f, 0.008229992349f };
            float[] t8 = new float[] { 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 4, 3, 2, 3, 2, 1, 1, 1, 2, 3, 1, 2, 3, 1, 2, 3, 4, 5, 5, 5, 1, 1, 1, 1, 2, 3, 2, 0.0030078831952f, 5.14648499948E-08f, 9.140080124E-06f, 0.0001912990825f, 0.98099075571f, 0.000090809861537f, 1.88995098805E-05f, 0.008298729999f };
            float[] r1 = new float[] { 3, 4, 3, 2, 3, 3 };
            float[] r2 = new float[] { 5, 3, 2, 3, 4, 5 };
            float[] r3 = new float[] { 3, 1, 2, 1, 2, 3 };
            float[] r4 = new float[] { 3, 3, 2, 4, 3, 4 };
            float[] r5 = new float[] { 4, 4, 3, 3, 2, 3 };
            float[] r6 = new float[] { 2, 3, 2, 3, 4, 2 };
            float[] r7 = new float[] { 3, 4, 5, 5, 5, 4 };
            float[] r8 = new float[] { 1, 2, 1, 1, 2, 2 };

            for (int i = 0; i < 100; i++)
            {
                net.FeedForward(t1);
                net.BP(r1);

                net.FeedForward(t2);
                net.BP(r2);

                net.FeedForward(t3);
                net.BP(r3);

                net.FeedForward(t4);
                net.BP(r4);

                net.FeedForward(t5);
                net.BP(r5);

                net.FeedForward(t6);
                net.BP(r6);

                net.FeedForward(t7);
                net.BP(r7);

                net.FeedForward(t8);
                net.BP(r8);


            }

            no_questions = 18;
            questions = new string[no_questions];
            inputs_loaded = new float[no_questions + 8];
            //inputs_loaded[0] = f2.score
            /*inputs_loaded[1] = f2.science_score;
            inputs_loaded[2] = f2.economics_score;
            inputs_loaded[3] = f2.math_info_score;
            inputs_loaded[4] = f2.psihology_score;
            inputs_loaded[5] = f2.philology_score;
            inputs_loaded[6] = f2.arts_score;
            inputs_loaded[7] = (float)f2.speech_score;
            inputs_loaded
            float[] outputs = net.LoadSolution(inputs_loaded);


    */
        }

        public Form12()
        {
            string filename = "Math.txt";
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

        public Form12(Form2 f)
        {
            f2 = f;
            string filename = "Math.txt";
            string text = "";
            System.IO.StreamReader objReader;

            if (System.IO.File.Exists(filename) == true)
            {
                //System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(filename);
                no_questions = int.Parse(objReader.ReadLine());
                questions = new string[no_questions * 5 + 10];
                inputs_loaded = new float[no_questions + 8];

                int i = 0;
                no_questions = no_questions * 5;

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

        private void Form12_Load(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                index = index - 10;
                label1.Text = questions[++index];
                radioButton1.Text = questions[++index];
                radioButton2.Text = questions[++index];
                radioButton3.Text = questions[++index];
                radioButton4.Text = questions[++index];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                
                visible();
                idx--;
            }

            else
            {
                button1.Enabled = false;
            }
        }

        private void visible()
        {
            if (idx == 7 || idx == 11 || idx == 12 || idx == 14 || idx == 15 || idx == 16 || idx == 18)
            {
                textBox1.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

            }

            else
            {
                textBox1.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }

            if (idx == 5 || idx == 8 || idx == 11 || idx == 17 || idx == 19)
            {
                pictureBox1.Visible = true;
                if (idx == 5)
                {
                    pictureBox1.Image = Image.FromFile(@"trig_cosine.jpg");
                }

                else if (idx == 8)
                {
                    pictureBox1.Image = Image.FromFile(@"matrix.png");
                }

                else if (idx == 11)
                {
                    pictureBox1.Image = Image.FromFile(@"function.png");
                }

                else if (idx == 17)
                {
                    pictureBox1.Image = Image.FromFile(@"json.png");
                }

                else if (idx == 19)
                {
                    pictureBox1.Image = Image.FromFile(@"codeseq.png");
                }
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
                
                visible();
                idx++;
            }

            else
            {
                button3.Visible = true;
                button2.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idx == 0)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 1)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 2)
            {
                if (radioButton4.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 3)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 4)
            {
                if (radioButton2.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 5)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 6)
            {
                if (radioButton3.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 7)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("choose") && s.Contains("a numeration") && s.Contains("set") && s.Contains("bijection with"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 8)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 9)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 10)
            {
                if (radioButton4.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 11)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("2 2 3 3 2 4 6") || s.Contains("2, 2, 3, 3, 2, 4, 6"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 12)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("shift") && s.Contains("position") && s.Contains("byte") && s.Contains("binary"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 13)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 1;
                }
            }
            else if (idx == 14)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("^"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 15)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("cleans") && s.Contains("memory") && s.Contains("automat"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 16)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("gets") && s.Contains("all") && s.Contains("from table") && s.Contains("John"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 17)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 1;
                }
            }

            else if (idx == 18)
            {
                string s = textBox1.Text.ToLower();
                if (s.Contains("strtok") && s.Contains("while") && s.Contains("++"))
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 0;
                }
            }

            else if (idx == 19)
            {
                if (radioButton1.Checked == true)
                {
                    inputs_loaded[idx] = 1;
                }

                else
                {
                    inputs_loaded[idx] = 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                f2.math_score = f2.math_score + inputs_loaded[i];
            }

            f2.math_score = (float)(f2.math_score * 10);

            for (int i = 10; i < 20; i++)
            {
                f2.info_score = f2.info_score + inputs_loaded[i];
            }

            f2.info_score = (float)(f2.info_score * 10);

            f2.math_info_score = (float)((f2.math_score + f2.info_score) / 2.0);
            int ss = (int)f2.math_info_score;
            f2.setL6(ss.ToString() + "%");
            f2.setB6();

            f2.Visible = true;
            Dispose();
        }
    }
}
