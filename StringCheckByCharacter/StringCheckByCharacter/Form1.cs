using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCheckByCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> nameList = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {


            StreamReader sr = new StreamReader("districts.txt");

            var line = sr.ReadLine();

            while (line != null)
            {
                nameList.Add(line);

                line = sr.ReadLine();

            }

            nameListBox.DataSource = nameList;

        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            List<string> result = new List<string>();

            foreach (string district in nameList) 
            {
                string input = nameTextBox.Text;

                if (district.StartsWith(input))
                {
                   
                    result.Add(district);
                }

                nameListBox.DataSource = null;

                nameListBox.DataSource = result;
            }

        }

       
    }
}
