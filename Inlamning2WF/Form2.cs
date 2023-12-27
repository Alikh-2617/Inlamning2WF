using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inlamning2WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string data = ReadFromFile();
            richTextBox1.Text = data;
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
            Seller seller = new Seller();
            seller.persNr = textBox2.Text;
            seller.Name = textBox1.Text;
            seller.distrikt = textBox3.Text;
            seller.antal = string.Empty;

            string result = SaveToDictionary(seller);
            textBox4.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Task.Delay(2000).Wait();
            textBox4.Clear();
            string data = ReadFromFile();
            richTextBox1.Text = data;

        }




        private string ReadFromFile()
        {
            string fileContent = "";

            try
            {
                using (StreamReader reader = new StreamReader(Application.StartupPath + "\\Data\\" + "Data.txt"))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return "Något gick fel , antingen file inte finns eller har inga data i sig !";
            }
            return fileContent;
        }


        private string SaveToDictionary(Seller seller)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "PersonNr ", seller.persNr },
                { "Name ", seller.Name },
                { "Distrikt ", seller.distrikt },
                {"Antal ", seller.antal }
            };
            string result = SaveDictionaryToFile(myDictionary);
            return result;
        }

        private string SaveDictionaryToFile(Dictionary<string, string> dictionary)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Application.StartupPath + "\\Data\\" + "Data.txt", true))
                {
                    foreach (var kvp in dictionary)
                    {
                        writer.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                    writer.WriteLine("-----------------------------------------------------");
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                return "Det gick inte ,kan du försöka om";
            }

            return "Klart !";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

