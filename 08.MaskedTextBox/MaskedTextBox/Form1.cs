using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Uygulama11: Klavyeden girilen telefon ve tarih bilgisini iki ayrı label'da gösteren programı yazınız.

        //MaskedTextBox: Tarih,saat,telefon gibi nitelikleri almak amacıyla kullanılan aracımızdır.
        //Button'a tıklandığında Date ve Phone maskedTextBox içerisindeki verileri Label'a yazdır.
        private void AddButton_Click(object sender, EventArgs e)
        {
            PrintPhoneLabel.Text = "Telefon: " + maskedPhoneBox.Text;
            PrintDateLabel.Text = "Tarih: " + maskedDateBox.Text;
        }
    }
}
