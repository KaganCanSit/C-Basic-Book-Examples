using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Example
{
    public partial class Examples : Form
    {
        public Examples()
        {
            InitializeComponent();
        }

        //Örnek1: Klavyeden girilen sayıya göre haftanın gününü veren prg. kodlayınız.
        private void WriteButton_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt16(GunComboBox.Text);
            //Dizi tanımlayarak farklı bir yoldan çözdük.
            string[] Hafta = { "Pazartesi", "Sali", "Carsamba", "Persembe", "Cuma", "Cumartesi", "Pazar" };

            GunLabel.Text = "Seçtiğiniz Gün: " + Hafta[gun-1] ;

        }

        //Örnek2: Klavyeden girilen sembolün ismini veren prg. kodlayınız. En az 10 sembol. (? = Soru İşareti gibi)
        //Şimdiye kadar ki Constructor yapısı ile çözelim.
        private void WriteButton1_Click(object sender, EventArgs e)
        {
            char karakter = Convert.ToChar(KarakterComboBox.Text);

            switch (karakter)
            {
                case '#': KarakterLabel.Text = "Karakterin İsmi: Diyez"; break;
                case '$': KarakterLabel.Text = "Karakterin İsmi: Dolar İşareti"; break;
                case '½': KarakterLabel.Text = "Karakterin İsmi: 1 Bölü 2"; break;
                case '&': KarakterLabel.Text = "Karakterin İsmi: Ampersant - Ve İşareti"+ Environment.NewLine + "Gemici Düğümü"; break;
                case '^': KarakterLabel.Text = "Karakterin İsmi: Üs İşareti"; break;
                case '?': KarakterLabel.Text = "Karakterin İsmi: Soru İşareti"; break;
                case '+': KarakterLabel.Text = "Karakterin İsmi: Artı İşareti"; break;
                case '-': KarakterLabel.Text = "Karakterin İsmi: Eksi İşareti"; break;
                case '*': KarakterLabel.Text = "Karakterin İsmi: Yıldız İşareti"+ Environment.NewLine +"Çarpma İşlemi İçinde Kullanılır"; break;
                case '/': KarakterLabel.Text = "Karakterin İsmi: Bölüm İşareti"; break;
                default: KarakterLabel.Text = "Karakteri Yanlış Seçtiniz."; break;

            }
            //Bu yapı if-else gibi başka yapılar ile de kurulabilir.
        }
    }
}
