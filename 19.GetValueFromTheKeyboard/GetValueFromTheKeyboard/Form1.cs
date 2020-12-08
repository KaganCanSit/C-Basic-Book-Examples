using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetValueFromTheKeyboard
{
    public partial class BasicApps : Form
    {
        public BasicApps()
        {
            InitializeComponent();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            //Uygulama11:Klavyeden girilen sayıyı label'a yazdıran programı kodlayınız.
            //Sayı değerini int olarak tanımladık, textbox'dan alıp int olarak convert ile değiştirdik. Label üzerine string olarak yazdırdık.
            int sayi;
            sayi = Convert.ToInt16(ValueTextBox.Text);
            WriteLabel.Text ="Sayı Değeri: " + sayi.ToString();
        }

        private void CupeButton_Click(object sender, EventArgs e)
        {
            //Uygulama12:Klavyeden girilen sayının küpünü hesaplayan programı yazınız.
            int kup = 0,sonuc=0;
            kup = Convert.ToInt32(CupeTextBox.Text);
            sonuc = kup * kup * kup;
            ResultLabel.Text = "İşlem Sonucu: " + sonuc.ToString();
        }

        private void GatherButton_Click(object sender, EventArgs e)
        {
            //Uygulama13:Klavyeden girilen iki sayı değeri toplayan programı yazınız.
            int value1 = 0, value2 = 0, gather = 0;
            value1 = Convert.ToInt32(Value1TextBox.Text);
            value2 = Convert.ToInt32(Value2TextBox.Text);
            gather = value1 + value2;
            GatherLabel.Text = "Toplam: " + gather.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Uygulama14:Klavyeden bir kenarı girilen karenin alan ve çevresini hesaplayan programı kodlayalım.
            int kenar = 0, alan=0, cevre=0;
            kenar = Convert.ToInt32(EdgeBox.Text);
            alan = kenar * kenar;
            cevre = kenar * 4;
            SquareLabel.Text = "Karenin Alanı: " + alan.ToString() + " Karenin Çevresi: " + cevre.ToString();
        }

        private void AverageCalculateButton_Click(object sender, EventArgs e)
        {
            //Uygulama15: Klavyeden 2 dınav notu girilen öğrencinin not ortalamasını hesaplayan programı kodlayınız.
            int not1 = 0, not2 = 0, ort = 0;
            not1 = Convert.ToInt32(ExamBox1.Text);
            not2 = Convert.ToInt32(ExamBox2.Text);
            ort = (not1 + not2) / 2;
            AverageCalculateLabel.Text = "Ortalama: " + ort.ToString();

        }
    }
}
