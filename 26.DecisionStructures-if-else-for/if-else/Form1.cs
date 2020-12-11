using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
{
    public partial class IfElseForm : Form
    {
        public IfElseForm()
        {
            InitializeComponent();
        }


        /*
         * Uygulama6:
           Klavyeden girilen değere göre suyun durumunu(su<0 - Katı 100>su>0 - Sıvı Su>100 - Gaz) yazdıran prg. yazınız.
        */
        private void CheckButton_Click(object sender, EventArgs e)
        {
            int su;
            su = Convert.ToInt32(WaterTextBox.Text);

            if(su<100 || su>0)
            {
                WaterLabel.Text = "Suyun Hali: Sıvıdır";
            }
            if(su<=0)
            {
                WaterLabel.Text = "Suyun Hali: Katıdır";
            }
            if(su>=100)
            {
                WaterLabel.Text = "Suyun Hali: Gazdır";
            }
        }


        /*
         *Uygulama7: Klavyeden 2 sınav notu girilen öğrencinin ortalamasına göre başarı durumunu yazdıran prg. kodlayınız. 
         *
         *Durumlar;
         *0-40 arası Vasat
         *41-60 arası Orta
         *61-75 arası İyi
         *76-100 arası Çok İyi
        */
        private void ExamButton_Click(object sender, EventArgs e)
        {
            int exam1, exam2, average;

            exam1 = Convert.ToInt32(ExamTextBox1.Text);
            exam2 = Convert.ToInt32(ExamTextBox2.Text);
            average = (exam1 + exam2) / 2;
            
            //Sınav değerleri için 0/100 kontrolü
            if(exam1<0 || exam1>100 || exam2 < 0 || exam2 > 100)
            {
                MessageBox.Show("Sınav Notu Değerleri 1-100 Arasında Olmaladır.");
                Environment.Exit(0); //Bu aralıkta not girişi varsa programı sonlandır.
            }


            //Notlara göre ortalama ve durum sonuçları
            if (average>0 && average<40)
            {
                ExamLabel.Text = "Ortalama: " + average + Environment.NewLine + "Durum: Vasat";
            }
            else if(average>41 && average<60)
            {
                ExamLabel.Text = "Ortalama: " + average + Environment.NewLine + "Durum: Orta";
            }
            else if (average > 61 && average < 75)
            {
                ExamLabel.Text = "Ortalama: " + average + Environment.NewLine + "Durum: İyi";
            }
            else if (average > 76 && average < 100)
            {
                ExamLabel.Text = "Ortalama: " + average + Environment.NewLine + "Durum: Çok İyi";
            }
        }


        //Uygulama8: Klavyeden girilen harfe göre takımı yazdıran prg. yazınız.(g-G=Galatasaray /f-F=Fenerbahçe // b-B=Beşiktaş)
        private void TeamButton_Click(object sender, EventArgs e)
        {
            if(TeamTextBox.Text=="g" || TeamTextBox.Text=="G")
            {
                TeamLabel.Text = "Takım: Galatasaray";
            }
            else if (TeamTextBox.Text == "f" || TeamTextBox.Text == "F")
            {
                TeamLabel.Text = "Takım: Fenerbahçe";
            }
            else if (TeamTextBox.Text == "b" || TeamTextBox.Text == "B")
            {
                TeamLabel.Text = "Takım: Beşiktaş";
            }
            else
            {
                MessageBox.Show("Tanımlanmayan Karakter Girdiniz. Yeniden Deneyiniz.");
                Environment.Exit(0);
            }
        }


        //Uygulama9: Klavyeden girilen sayının 2'ye ve 3'e tam bölünüp bölünmediğini kontrolünü yapan prog. yazınız.
        private void NumberButton_Click(object sender, EventArgs e)
        {
            int Number;
            Number = Convert.ToInt32(NumberTextBox.Text);

            if(Number%2==0 && Number%3==0)
            {
                NumberResultLabel.Text = "Sonuç:" + Environment.NewLine + "Sayı Değeri Bölünebilir";
            }
            else
            {
                NumberResultLabel.Text = "Sonuç:" + Environment.NewLine + "Sayı Değeri Bölünemez";
            }

        }

        /*
         * Uygulama10: 5 kelimeden oluşan bir İngilizce-Türkçe kelime bloğu oluşturalım. Kelimelerin İnglizcelerini ComboBox
         * aracına ekleyelim. ComboBox'tan seçtiğimiz kelimeleye göre Türkçe karşılığını Label'a yazdıralım.
        */
        private void TranslateButton_Click(object sender, EventArgs e)
        {
            //İlk değerlerini ComboBox aracına form yüzünden Edit Items diyerek alt alta ekledik.
            if(EngComboBox.Text=="Apple")
            {
                TurkeyLabel.Text = "Türkçe: Elma";
            }
            else if(EngComboBox.Text == "Melon")
            {
                TurkeyLabel.Text = "Türkçe: Kavun";
            }
            else if(EngComboBox.Text == "Orange")
            {
                TurkeyLabel.Text = "Türkçe: Portakal";
            }
            else if(EngComboBox.Text == "Banan")
            {
                TurkeyLabel.Text = "Türkçe: Muz";
            }
            else if(EngComboBox.Text == "Peach")
            {
                TurkeyLabel.Text = "Türkçe: Şeftali";
            }
        }
    }
}
