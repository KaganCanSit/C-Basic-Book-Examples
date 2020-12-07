using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Uygulama3: Değişken kullanarak şehir ve ilçeyi ListBox'a yazdıran programı kodlayınız.
        private void ShowButton_Click(object sender, EventArgs e)
        {
            string sehir1, sehir2, sehir3;
            sehir1 = "Bilecik-Bozüyük";
            sehir2 = "Bursa-Osmangazi";
            sehir3 = "İstanbul-Kadiköy";
            listBox1.Items.Add(sehir1);
            listBox1.Items.Add(sehir2);
            listBox1.Items.Add(sehir3);
        }
    }
}
