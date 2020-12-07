using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //String kelime ve cümleler için kullanılır.
        private void WriteButton_Click(object sender, EventArgs e)
        {
            /*
            string metin;
            metin = "Merhaba Dünya";
            WriteLabel.Text = metin;
            */

            //Uygulama2: Değişken kullanarak kişinin adını, soyadını ve mesleğini yazdıran uygulamayı yazınız.
            string ad, soyad, meslek;
            
            ad="Kağan Can";
            soyad = "Şit";
            meslek = "Öğrenci";

            WriteLabel.Text = ad + " " + Environment.NewLine + soyad + " " + Environment.NewLine + meslek;
        }
    }
}
