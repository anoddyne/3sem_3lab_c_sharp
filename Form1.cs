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
            //чтение файла
            var fin = new StreamReader("input.txt");
            string TextFile = fin.ReadToEnd();
            fin.Close();

            //заполнение строки текстом из файла
            textFileInput.Text = TextFile;

            //очистка строки от предыдущей информации
            invertedFile.Clear();

            //разделение строки из файла по словам и добавление в массив
            string[] fileOutput = TextFile.Split();

            //вывод массива с конца
            for (int i = fileOutput.Length - 1; i >= 0; i--)
                invertedFile.Text += fileOutput[i] + ' '; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //очистка строки от предыдущей информации 
            invertedStringOutput.Clear();

            //ввод строки
            string enteredString = inputString.Text;

            //разделение введенной строки по словам и добавление в массив
            string[] reversedString = enteredString.Split();

            //вывод массива с конца
            for (int i = reversedString.Length - 1; i >= 0; i--)
                invertedStringOutput.Text += reversedString[i] + ' ';
        }
    }
}
