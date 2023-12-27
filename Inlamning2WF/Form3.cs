using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning2WF
{
    public partial class Form3 : Form
    {
        private string persNr = string.Empty;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string antal = textBox2.Text;
            string updateResult = UpdateValueInFile(antal);
            textBox1.Text = updateResult;
            textBox2.Clear();
            string person = GetValueFromFile(persNr);

            Task.Delay(1000).Wait();
            richTextBox1.Text = person;
            Task.Delay(2000).Wait();
            textBox1.Clear();
        }

        private string UpdateValueInFile(string newValue)
        {
            string antal = "Antal : ";
            try
            {
                string filePath = Application.StartupPath + "\\Data\\" + "Data.txt";
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == "-----------------------------------------------------")
                    {
                        continue;
                    }
                    string line = lines[i];
                    string[] pers2 = line.Split(":");
                    string value = pers2[1].Trim();
                    if (value.Equals(persNr))
                    {
                        lines[i+3] = $"{antal} {newValue}";
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    return $"{antal} hittades inte i filen.";
                }

                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                return "Det gick inte.";
            }

            return "Uppdatering klar!";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            persNr = tbPR.Text;
            string person = GetValueFromFile(persNr);

            tbPR.Clear();
            richTextBox1.Text = person;
        }

        private string GetValueFromFile(string keyToFind)
        {
            string clear = string.Empty;
            string fileContent = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(Application.StartupPath + "\\Data\\" + "Data.txt"))
                {
                    fileContent = reader.ReadToEnd();
                }
                string[] parts = fileContent.Split("-----------------------------------------------------");
                foreach (string part in parts)
                {
                    string[] perNr = part.Split("\r");
                    if (perNr[0]== "")
                    {
                        perNr = perNr.Skip(1).ToArray();
                    }
                    string pers1 = perNr[0].Trim();
                    string[] pers2 = pers1.Split(":");
                    string value = pers2[1].Trim();
                    if (keyToFind.Equals(value))
                    {
                        return part;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Vi kunde inte hitta dig \nAntingen du har inte registerat eller file inte finns eller har inga data i sig !";
            }

            return "Kunde inte hitta dig !";
        }


    }
}
