using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Intent;

using System.Windows.Input;
//using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
//using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

using Microsoft.Rest;
using System.Net.Http;
using System.Threading;

using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System;
using System.Data.SqlClient;
using System.Text;

namespace AICrackersFinalApp
{
   /**/

    public partial class Form2 : Form
    {
        
       
        private const string apiKey = "bf5337af36e2445c9d98030c93c47005";
        private const string sentimentUri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/sentiment";
        private const string keyPhrasesUri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases";
        private const string languageUri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/languages";
        private const string SubscriptionKey = "e074bf56d56e4347bb69997dd5493456";
        

        public Form2()
        {
            this.ControlBox = false;
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
            string message = "We suggest to start with the Holland test, to check your abilities.";
            string title = "Suggestion";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            
            toolTip1.SetToolTip(button8, "This test contains questions from Economics and Statistics.");
            toolTip2.SetToolTip(button5, "This test contains questions from Chemistry, Biology and Physics.");
            toolTip3.SetToolTip(button2, "This test contains questions from Psihology and Philosophy.");
            toolTip4.SetToolTip(button3, "This test contains questions from Music and Painting.");
            toolTip5.SetToolTip(button4, "This test contains questions from History, Geography and Literature.");
            toolTip6.SetToolTip(button6, "This test contains questions from Calculus, Algebra and Algorithmics.");
            //toolTip7.SetToolTip(button7, "The Sport teoretical section.");
            toolTip8.SetToolTip(button10, "This section gets information about your personality. You should explain which domain is your favorite and talk about your University choice.");
           // toolTip9.SetToolTip(button11, "This section contains parameters from the tests and displays information globally about the students' results.");
            toolTip10.SetToolTip(button1, "Holland is a personality test, to guide you in choosing the sections in order to complete.");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(this);
            //Hide();
            f12.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(this);
            
            f9.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(this);
            
            f8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(this);
            
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            
            f6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            
            f3.ShowDialog();
        }


        public int[] selectParticipants()
        {
            int[] resutls1 = new int[12];

            try
            {

                SqlConnection connessione = new SqlConnection("Server = tcp:testaicrackers.database.windows.net,1433; Initial Catalog = Test_Data; Persist Security Info = False; User ID = adminai; Password = passwordteamup123!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                connessione.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM STUDENTS", connessione);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int s = int.Parse(dr.GetString(18));
                        resutls1[s - 1]++;
                    }
                }

                dr.Close();
                connessione.Close();

                

            }
            catch (SqlException e)
            {

            }

            return resutls1;
        }

        public int selectResults (string s, string search)
        {
            int found = 1;

            try
            {
                
                SqlConnection connessione = new SqlConnection("Server = tcp:testaicrackers.database.windows.net,1433; Initial Catalog = Test_Data; Persist Security Info = False; User ID = adminai; Password = passwordteamup123!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                connessione.Open();
                SqlCommand cmd = new SqlCommand(s, connessione);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(2).ToLower().Contains(search));
                        return 1;
                    }
                }

                dr.Close();
                connessione.Close();
                if (i == 0)
                {
                    found = 0;
                }
               
            }
            catch (SqlException e)
            {
                
            }

            return found;
        }

        public int insertResults(string firstName, string lastName, int unicode)
        {
            int found = 1;

            try
            {

                SqlConnection connessione = new SqlConnection("Server = tcp:testaicrackers.database.windows.net,1433; Initial Catalog = Test_Data; Persist Security Info = False; User ID = adminai; Password = passwordteamup123!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                connessione.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO STUDENTS (id, firstname, lastname, totalscore, science, economics, math, psihology, philology, arts, speech, photo, holland1, holland2, holland3, holland4, holland5, holland6, uni_code)
                                  VALUES (@id, @firstname, @lastname, @totalscore, @science, @economics, @math, @psihology, @philology, @arts, @speech, @photo, @holland1, @holland2, @holland3, @holland4, @holland5, @holland6, @uni_code)", connessione);
                int id = int.Parse(Guid.NewGuid().ToString());
                float total = (float)((science_score + economics_score + math_score + psihology_score + philology_score + arts_score + speech_score + photo_score + holland_test_results[0] + holland_test_results[1] + holland_test_results[2] + holland_test_results[3] + holland_test_results[4] + holland_test_results[5]) / 14.0);
                cmd.Parameters.Add(new SqlParameter("id", id));
                cmd.Parameters.Add(new SqlParameter("firstname", firstName));
                cmd.Parameters.Add(new SqlParameter("lastname", lastName));
                cmd.Parameters.Add(new SqlParameter("totalscore", total));
                cmd.Parameters.Add(new SqlParameter("science", science_score));
                cmd.Parameters.Add(new SqlParameter("economics", economics_score));
                cmd.Parameters.Add(new SqlParameter("math", math_score));
                cmd.Parameters.Add(new SqlParameter("psihology", psihology_score));
                cmd.Parameters.Add(new SqlParameter("philology", philology_score));
                cmd.Parameters.Add(new SqlParameter("arts", arts_score));
                cmd.Parameters.Add(new SqlParameter("speech", speech_score));
                cmd.Parameters.Add(new SqlParameter("photo", photo_score));
                cmd.Parameters.Add(new SqlParameter("holland1", holland_test_results[0]));
                cmd.Parameters.Add(new SqlParameter("holland2", holland_test_results[1]));
                cmd.Parameters.Add(new SqlParameter("holland3", holland_test_results[2]));
                cmd.Parameters.Add(new SqlParameter("holland4", holland_test_results[3]));
                cmd.Parameters.Add(new SqlParameter("holland5", holland_test_results[4]));
                cmd.Parameters.Add(new SqlParameter("holland6", holland_test_results[5]));
                cmd.Parameters.Add(new SqlParameter("uni_code", unicode));
                cmd.ExecuteNonQuery();
                connessione.Close();
               


            }
            catch (SqlException e)
            {

            }

            return found;
        }




        public double initTextAnalysis(string text)
        {

            var sampleText = text;
            if (sampleText.Length == 0)
                sampleText = "No Text";
            var client = new WebClient();
            client.Headers.Add("Ocp-Apim-Subscription-Key", apiKey);
            client.Headers.Add("Content-Type", "application/json");
            client.Headers.Add("Accept", "application/json");
            var postData1 = @"{""documents"":[{""id"":""1"", ""text"":""@sampleText""}]}".Replace("@sampleText", sampleText);
            var response1 = client.UploadString(languageUri, postData1);
            var language = new Regex(@"""iso6391Name"":""(\w+)""").Match(response1).Groups[1].Value;

            // Determine sentiment
            var postData2 = @"{""documents"":[{""id"":""1"", ""language"":""@language"", ""text"":""@sampleText""}]}".Replace("@sampleText", sampleText).Replace("@language", language);
            var response2 = client.UploadString(sentimentUri, postData2);
            var sentimentStr = new Regex(@"""score"":([\d.]+)").Match(response2).Groups[1].Value;
            var sentiment = Convert.ToDouble(sentimentStr, System.Globalization.CultureInfo.InvariantCulture);

            // Detemine key phrases
            var postData3 = postData2;
            var response3 = client.UploadString(keyPhrasesUri, postData2);
            var keyPhrases = new Regex(@"""keyPhrases"":(\[[^\]]*\])").Match(response3).Groups[1].Value;

            return sentiment;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(this);
            f10.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            
            f4.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\dell\source\repos\AICrackersFinalApp\AICrackersFinalApp\Geography.html");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11(this);
            f11.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\dell\source\repos\AICrackersFinalApp\AICrackersFinalApp\BOT23.html");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            //Form13 f13 = new Form13(this);
            //f13.ShowDialog();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Open Statistics");
        }
    }
}
