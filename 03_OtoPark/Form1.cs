using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_OtoPark
{
    public partial class Form1 : Form
    {
        // Saatlik ücretler

        const int oUcret = 10;
        const int mUcret = 15;
        const int taUcret = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxAracTuru.SelectedIndex = 0; // combonun ilk elemanının ekranda gözükmesini sağlıyorum
        }

        private void btonHesapla_Click(object sender, EventArgs e)
        {
            int sure = 0;
            string aracTipi = cboxAracTuru.Text; // araç türünü öğreniyorum

            double ucret = 0; // Otoparka ödenecek miktar


            if (cboxAracTuru.SelectedIndex != 0 && tboxSure.Text != "")
            {
                sure = Convert.ToInt32(tboxSure.Text);

                switch (aracTipi)
                {
                    case "Otomobil":
                        if (sure == 1)
                            ucret = oUcret;
                        else
                            ucret = sure * (oUcret * 1.2);

                        break;

                    case "Minibüs":
                        if (sure == 1)
                            ucret = mUcret;
                        else
                            ucret = sure * (mUcret * 1.25);

                        break;

                    case "Ticari Araç":
                        if (sure == 1)
                            ucret = taUcret;
                        else
                            ucret = sure * (taUcret * 1.3);

                        break;


                    default:
                        break;
                }

                MessageBox.Show($"Ödeyeceğiniz ücret {ucret.ToString()} TL...");
            }

            else
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz....");
        }
    }
}
