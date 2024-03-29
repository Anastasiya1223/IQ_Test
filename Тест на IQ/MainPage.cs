﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Тест_на_IQ
{
    public partial class MainPage : Form
    {
        
        public MainPage thisPage;
        public MainPage()
        {
            InitializeComponent();
        }
        public string NickName;

        private void Start()
        {
            if (Nickname_textBox.Text != "")
            {
                NickName = Nickname_textBox.Text ;
                Form1 Test = new Form1();
                string path = @"C:\Users\polue\Downloads\IQ_Test-master (2)\IQ_Test-master\Тест на IQ\Results.txt";
                System.IO.File.AppendAllText(path," "+NickName);
                Test.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(
                         "Вы не ввели свой ник",
                         "Сообщение",
                         MessageBoxButtons.OK
                         );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
            //StreamWriter sw = new StreamWriter(@"C:\Users\polue\Downloads\IQ_Test-master (2)\IQ_Test-master\Тест на IQ\Results.txt", true, Encoding.ASCII);           
            //sw.Write(" ", NickName);
            //sw.Close();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\polue\Downloads\IQ_Test-master (2)\IQ_Test-master\Тест на IQ\Results.txt";
            if (File.Exists(path))
            {
                string[] message = File.ReadAllLines(path);
                string msg = "";
                for (int i = 0; i < message.Length; i++)
                {
                    msg += message[i];
                    msg += "\n";
                    msg += NickName;
                }
                MessageBox.Show(
                            msg,
                            "Результаты",
                            MessageBoxButtons.OK
                            );
            }
            else
            {
                MessageBox.Show(
                               "Файла с результатами еще нет",
                               "Результаты",
                               MessageBoxButtons.OK
                               );
            }
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Start();
            }
        }
        
        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
