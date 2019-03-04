using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotKol_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = textBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    trackBarOmuz.Enabled = true;
                    trackBarDonme.Enabled = true;
                    trackBarDirsek.Enabled = true;
                    lblBaglanti.Text = "Bağlanıldı";
                }
            }
            catch
            {
                lblBaglanti.Text = "Bağlanılamadı";
            }
        }


        
        private void trackBarDirsek_Scroll(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                int tr1Deger = trackBarDirsek.Value;
                string deger = tr1Deger.ToString();
                serialPort1.Write("R" + deger);
                lblDirsek.Text = Convert.ToString(trackBarDirsek.Value);
            }
        }
        private void trackBarOmuz_Scroll(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                int tr1Deger = trackBarOmuz.Value;
                string deger = tr1Deger.ToString();
                serialPort1.Write("O" + deger);
                lblOmuz.Text = Convert.ToString(trackBarOmuz.Value);
            }
        }
        private void trackBarDonme_Scroll(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                int tr1Deger = trackBarDonme.Value;
                string deger = tr1Deger.ToString();
                serialPort1.Write("D"+ deger);
                lblDonme.Text = Convert.ToString(trackBarDonme.Value );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void trackBarTutkac_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int tr1Deger = trackBarTutkac.Value;
                string deger = tr1Deger.ToString();
                serialPort1.Write("T" + deger);
                lblTUTKAC.Text = Convert.ToString(trackBarTutkac.Value);
            }

        }

        private void trackBarBilek_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int tr1Deger = trackBarBilek.Value;
                string deger = tr1Deger.ToString();
                serialPort1.Write("B" + deger);
                lblBilek.Text = Convert.ToString(trackBarBilek.Value);
            }
        }
    }
}
