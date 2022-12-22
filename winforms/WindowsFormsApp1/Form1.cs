using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalQuiz
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> countries = new Dictionary<string, string>();


        private Random rng = new Random();

        private string currentCountry;


        private string correctAnswer;

        public int score;

        public int highscore;
        

        public Form1()
        {

            countries.Add("Afghanistan", "Kabul");
            countries.Add("Albanien", "Tirana");
            countries.Add("Algerien", "Algier");
            countries.Add("Andorra", "Andorra la Vella");
            countries.Add("Angola", "Luanda");
            countries.Add("Antigua und Barbuda", "St. Johns");
            countries.Add("Äquatorialguinea", "Malabo");
            countries.Add("Argentinien", "Buenos Aires");
            countries.Add("Armenien", "Eriwan");
            countries.Add("Aserbaidschan", "Baku");
            countries.Add("Äthiopien", "Addis Abeba");
            countries.Add("Bahamas", "Nassau");
            countries.Add("Bahrain", "Manama");
            countries.Add("Bangladesch", "Dhaka");
            countries.Add("Barbados", "Bridgetown");
            countries.Add("Belarus", "Minsk");
            countries.Add("Belgien", "Brüssel");
            countries.Add("Belize", "Belmopan");
            countries.Add("Benin", "Porto-Novo");
            countries.Add("Bhutan", "Thimphu");
            countries.Add("Bolivien", "La Paz");
            countries.Add("Bosnien und Herzegowina", "Sarajevo");
            countries.Add("Botswana", "Gaborone");
            countries.Add("Brasilien", "Brasília");
            countries.Add("Brunei", "Bandar Seri Begawan");
            countries.Add("Bulgarien", "Sofia");
            countries.Add("Burkina Faso", "Ouagadougou");
            countries.Add("Burundi", "Gitega");
            countries.Add("Chile", "Santiago de Chile");
            countries.Add("China", "Peking");
            countries.Add("Cookinseln", "Avarua");
            countries.Add("Costa Rica", "San José");
            countries.Add("Côte d'Ivoire", "Yamoussoukro");
            countries.Add("Dänemark", "Kopenhagen");
            countries.Add("Deutschland", "Berlin");
            countries.Add("Dominica", "Roseau");
            countries.Add("Dominikanische Republik", "Santo Domingo");
            countries.Add("Dschibuti", "Dschibuti");
            countries.Add("Ecuador", "Quito");
            countries.Add("El Salvador", "San Salvador");
            countries.Add("Elfenbeinküste", "Yamoussoukro");
            countries.Add("Eritrea", "Asmara");
            countries.Add("Estland", "Tallinn");
            countries.Add("Eswatini", "Mbabane");
            countries.Add("Fidschi", "Suva");
            countries.Add("Finnland", "Helsinki");
            countries.Add("Frankreich", "Paris");
            countries.Add("Gabun", "Libreville");
            countries.Add("Gambia", "Banjul");
            countries.Add("Georgien", "Tiflis");
            countries.Add("Ghana", "Accra");
            countries.Add("Grenada", "St. George's");
            countries.Add("Griechenland", "Athen");
            countries.Add("Guatemala", "Guatemala-Stadt");
            countries.Add("Guinea", "Conakry");
            countries.Add("Guinea-Bissau", "Bissau");
            countries.Add("Guyana", "Georgetown");
            countries.Add("Haiti", "Port-au-Prince");
            countries.Add("Honduras", "Tegucigalpa");
            countries.Add("Indien", "Neu-Delhi");
            countries.Add("Indonesien", "Jakarta");
            countries.Add("Irak", "Bagdad");
            countries.Add("Iran", "Teheran");
            countries.Add("Irland", "Dublin");
            countries.Add("Island", "Reykjavík");
            countries.Add("Israel", "Jerusalem");
            countries.Add("Italien", "Rom");
            countries.Add("Jamaika", "Kingston");
            countries.Add("Japan", "Tokio");
            countries.Add("Jemen", "Sanaa");
            countries.Add("Jordanien", "Amman");
            countries.Add("Kambodscha", "Phnom Penh");
            countries.Add("Kamerun", "Yaoundé");
            countries.Add("Kanada", "Ottawa");
            countries.Add("Kap Verde", "Praia");
            countries.Add("Kasachstan", "Astana");
            countries.Add("Katar", "Doha");
            countries.Add("Kenia", "Nairobi");
            countries.Add("Kirgisistan", "Bischkek");
            countries.Add("Kiribati", "Tarawa");
            countries.Add("Kolumbien", "Bogotá");
            countries.Add("Komoren", "Moroni");
            countries.Add("Kongo", "Brazzaville");
            countries.Add("Kongo (Demokratische Republik)", "Kinshasa");
            countries.Add("Kroatien", "Zagreb");
            countries.Add("Kuba", "Havanna");
            countries.Add("Kuwait", "Kuwait-Stadt");
            countries.Add("Laos", "Vientiane");
            countries.Add("Lesotho", "Maseru");
            countries.Add("Lettland", "Riga");
            countries.Add("Libanon", "Beirut");
            countries.Add("Liberia", "Monrovia");
            countries.Add("Libyen", "Tripolis");
            countries.Add("Liechtenstein", "Vaduz");
            countries.Add("Litauen", "Vilnius");
            countries.Add("Luxemburg", "Luxemburg");
            countries.Add("Madagaskar", "Antananarivo");
            countries.Add("Malawi", "Lilongwe");
            countries.Add("Malaysia", "Kuala Lumpur");
            countries.Add("Malediven", "Malé");
            countries.Add("Mali", "Bamako");
            countries.Add("Malta", "Valletta");
            countries.Add("Marokko", "Rabat");
            countries.Add("Marshallinseln", "Delap-Uliga-Djarrit");
            countries.Add("Mauritius", "Port Louis");
            countries.Add("Mazedonien", "Skopje");
            countries.Add("Mexiko", "Mexiko-Stadt");
            countries.Add("Mikronesien", "Palikir");
            countries.Add("Moldau", "Chisinau");
            countries.Add("Monaco", "Monaco");
            countries.Add("Mongolei", "Ulaanbaatar");
            countries.Add("Montenegro", "Podgorica");
            countries.Add("Mosambik", "Maputo");
            countries.Add("Myanmar", "Naypyidaw");
            countries.Add("Namibia", "Windhuk");
            countries.Add("Nauru", "Yaren District");
            countries.Add("Nepal", "Kathmandu");
            countries.Add("Nicaragua", "Managua");
            countries.Add("Niederlande", "Amsterdam");
            countries.Add("Niger", "Niamey");
            countries.Add("Nigeria", "Abuja");
            countries.Add("Norwegen", "Oslo");
            countries.Add("Oman", "Maskat");
            countries.Add("Österreich", "Wien");
            countries.Add("Pakistan", "Islamabad");
            countries.Add("Palau", "Melekeok");
            countries.Add("Panama", "Panama-Stadt");
            countries.Add("Papua-Neuguinea", "Port Moresby");
            countries.Add("Paraguay", "Asunción");
            countries.Add("Peru", "Lima");
            countries.Add("Philippinen", "Manila");
            countries.Add("Polen", "Warschau");
            countries.Add("Portugal", "Lissabon");
            countries.Add("Ruanda", "Kigali");
            countries.Add("Rumänien", "Bukarest");
            countries.Add("Rusland", "Moskau");
            countries.Add("Salomonen", "Honiara");
            countries.Add("Sambia", "Lusaka");
            countries.Add("Samoa", "Apia");
            countries.Add("San Marino", "San Marino");
            countries.Add("São Tomé und Príncipe", "São Tomé");
            countries.Add("Saudi-Arabien", "Riad");
            countries.Add("Schweden", "Stockholm");
            countries.Add("Schweiz", "Bern");
            countries.Add("Senegal", "Dakar");
            countries.Add("Serbien", "Belgrad");
            countries.Add("Seychellen", "Victoria");
            countries.Add("Sierra Leone", "Freetown");
            countries.Add("Simbabwe", "Harare");
            countries.Add("Singapur", "Singapur");
            countries.Add("Slowakei", "Bratislava");
            countries.Add("Slowenien", "Ljubljana");
            countries.Add("Somalia", "Mogadischu");
            countries.Add("Spanien", "Madrid");
            countries.Add("Sri Lanka", "Colombo");
            countries.Add("St. Kitts und Nevis", "Basseterre");
            countries.Add("St. Lucia", "Castries");
            countries.Add("St. Vincent und die Grenadinen", "Kingstown");
            countries.Add("Suriname", "Paramaribo");
            countries.Add("Swasiland", "Mbabane");
            countries.Add("Südafrika", "Pretoria");
            countries.Add("Südsudan", "Juba");
            countries.Add("Südkorea", "Seoul");
            countries.Add("Syrien", "Damaskus");
            countries.Add("Tadschikistan", "Duschanbe");
            countries.Add("Taiwan", "Taipeh");
            countries.Add("Tansania", "Dodoma");
            countries.Add("Thailand", "Bangkok");
            countries.Add("Timor-Leste", "Dili");
            countries.Add("Togo", "Lomé");
            countries.Add("Tonga", "Nukualofa");
            countries.Add("Trinidad und Tobago", "Port of Spain");
            countries.Add("Tschad", "NDjamena");
            countries.Add("Tschechien", "Prag");
            countries.Add("Tunesien", "Tunis");
            countries.Add("Türkei", "Ankara");
            countries.Add("Turkmenistan", "Aschgabat");
            countries.Add("Tuvalu", "Vaiaku Village");
            countries.Add("Uganda", "Kampala");
            countries.Add("Ukraine", "Kiew");
            countries.Add("Ungarn", "Budapest");
            countries.Add("Uruguay", "Montevideo");
            countries.Add("Usbekistan", "Taschkent");
            countries.Add("Vanuatu", "Port Vila");
            countries.Add("Vatikanstadt", "Vatikanstadt");
            countries.Add("Venezuela", "Caracas");
            countries.Add("Vereinigte Arabische Emirate", "Abu Dhabi");
            countries.Add("Vereinigte Staaten von Amerika", "Washington D.C.");
            countries.Add("Vereinigtes Königreich", "London");
            countries.Add("Vietnam", "Hanoi");
            countries.Add("Zentralafrikanische Republik", "Bangui");
            countries.Add("Zypern", "Nikosia");

            StartQuiz();
            Show();
        }

        private void StartQuiz()
        {
         

            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1013, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(450, 166);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += CheckAnswer;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(450, 166);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += CheckAnswer;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(450, 166);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 166);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(157, 57);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1568, 300);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1618, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 91);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.ResumeLayout(false);

            button1.Text = correctAnswer;
            button2.Text = "Incorrect Answer 1";
            button3.Text = "Incorrect Answer 2";
            button4.Text = "Incorrect Answer 3";

            currentCountry = "";
            correctAnswer = "";
            currentCountry = countries.Keys.ElementAt(rng.Next(countries.Count));

            correctAnswer = countries[currentCountry];

            lblQuestion.Text = "Was ist die Hauptstadt von " + currentCountry + "?";

            List<string> answers = new List<string>() { correctAnswer };
            while (answers.Count < 4)
            {
                string incorrectAnswer = countries.Values.ElementAt(rng.Next(countries.Count));
                if (!answers.Contains(incorrectAnswer))
                {
                    answers.Add(incorrectAnswer);
                }
            }

            answers = answers.OrderBy(x => rng.Next()).ToList();

            button1.Text = answers[0];
            button2.Text = answers[1];
            button3.Text = answers[2];
            button4.Text = answers[3];
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            


            if (buttonText == correctAnswer)
            {
                score++;
                label1.Text = score.ToString();

                if (buttonText != correctAnswer)
                {
                    score = 0;
                  
                }
                MessageBox.Show("Richtig!");
                currentCountry = "";
                correctAnswer = "";
                currentCountry = countries.Keys.ElementAt(rng.Next(countries.Count));

                correctAnswer = countries[currentCountry];

                lblQuestion.Text = "Was ist die Hauptstadt von " + currentCountry + "?";
                List<string> answers = new List<string>() { correctAnswer };
                while (answers.Count < 4)
                {
                    string incorrectAnswer = countries.Values.ElementAt(rng.Next(countries.Count));
                    if (!answers.Contains(incorrectAnswer))
                    {
                        answers.Add(incorrectAnswer);
                    }
                }
                answers = answers.OrderBy(x => rng.Next()).ToList();

                button1.Text = answers[0];
                button2.Text = answers[1];
                button3.Text = answers[2];
                button4.Text = answers[3];
            }
            else
            {
                score = 0;
                label1.Text = score.ToString();
                MessageBox.Show("Falsch. Die richtige ist " + correctAnswer);
                currentCountry = "";
                correctAnswer = "";
                currentCountry = countries.Keys.ElementAt(rng.Next(countries.Count));

                correctAnswer = countries[currentCountry];

                lblQuestion.Text = "Was ist die Hauptstadt von " + currentCountry + "?";
                List<string> answers = new List<string>() { correctAnswer };
                while (answers.Count < 4)
                {
                    string incorrectAnswer = countries.Values.ElementAt(rng.Next(countries.Count));
                    if (!answers.Contains(incorrectAnswer))
                    {
                        answers.Add(incorrectAnswer);
                    }
                }
                answers = answers.OrderBy(x => rng.Next()).ToList();

                button1.Text = answers[0];
                button2.Text = answers[1];
                button3.Text = answers[2];
                button4.Text = answers[3];
            }


        }

    private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}



