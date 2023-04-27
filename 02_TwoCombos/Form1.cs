using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TwoCombos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program ilk çalıştığında Formun ilk yüklenme anında çalışır..

            // Burada bizden istenen şey 1.Combonun doldurulması

            for (int i = 1; i <= 20 ; i++)
            {
                cboxFirst.Items.Add(i.ToString()); 
            }
        }

        private void cboxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Öncelikle benim comboboxtaki hangi değeri seçtiğimi öğrenmem lazım.

            int start=int.Parse(cboxFirst.Text) + 1; // öğrendiğim değerin 1 fazlasından başlamam isteniyordu.

            // sıra geldi 2.comboyu doldurmaya
            // bir fazlasından baslasın ve 10 fazlasına kadar gitsin.


            // cboxSecod ı bir temizliyim

            cboxSecond.Items.Clear();


            for (int i = start; i <= start+10; i++)
            {
                cboxSecond.Items.Add(i.ToString());
            }


        }
    }
}
