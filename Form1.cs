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

namespace _3sem_3lab_c_sharp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fin = new StreamReader("input.txt");
            string TextFile = fin.ReadToEnd();
            fin.Close();
            textFileInput.Text = TextFile;
            string[] fileOutput = TextFile.Split();
            Array.Reverse(fileOutput);
            for (int i = 0; i < fileOutput.Length; i++)
                invertedFile.Text += fileOutput[i] + ' '; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredString = inputString.Text;
            string[] reversedString = enteredString.Split();
            Array.Reverse(reversedString);
            for (int i = 0; i < reversedString.Length; i++)
                invertedStringOutput.Text += reversedString[i] + ' ';
        }
    }
}
