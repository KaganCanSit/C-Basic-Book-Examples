using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double
{
    public partial class DoubleExamples : Form
    {
        public DoubleExamples()
        {
            InitializeComponent();
        }

        //Uygulama16:Kod kısmından girilen ondalıklı sayıyı labela yazdıran programı yazınız.
        private void WriteBtn_Click(object sender, EventArgs e)
        {
            double sayi = 2.94;
            DoubleLabel.Text ="Ondalıklı Sayı Değeri: "+ sayi.ToString();
        }


        //Uygulama17:Kod kısmından girilen iki sayıyı toplayıp sonucu hesaplayan prgogramı yazınız.
        private void GatherButton_Click(object sender, EventArgs e)
        {
            double value = 2.48, value1 = 3.57, gather = 0;
            gather = value + value1;
            ResultLabel.Text ="Toplam Sonucu: " + gather.ToString();
        }

        //Önemli! Klavyede veri alırken ToInt olarak değil ToDouble olarak veriyi çekmelisin.!!!
        //Uygulama18:Klavyeden girilen ondalıklı bir sayıyı label'a yazdıran programı kodlayınız.
        private void DoubleWriteButton_Click(object sender, EventArgs e)
        {
            double deger = 0;
            deger = Convert.ToDouble(DoubleTextBox.Text);
            DoubleWriteLabel.Text ="Ondalıklı Sayı Değeri: " + deger.ToString();
        }

        //Klavyeden girilen ondalıklı iki sayı için aritmetik 4 işlem yapan programı kodlayalım.
        private void MakeMathsButton_Click(object sender, EventArgs e)
        {
            double math1 = 0, math2 = 0, Total = 0, Extraction = 0, Product = 0, Episode = 0;
            math1 = Convert.ToDouble(MatBox1.Text);
            math2 = Convert.ToDouble(MatBox2.Text);

            Total = math1 + math2;
            Extraction = math1 - math2;
            Product = math1 * math2;
            Episode = math1 / math2;

            ResultsLabel.Text = "Sonuçlar:" + Environment.NewLine +
                "Toplam Sonucu: " + Total.ToString() + Environment.NewLine +
                "Çıkarma Sonucu: " + Extraction.ToString() + Environment.NewLine +
                "Çarpma Sonucu: " + Product.ToString() + Environment.NewLine +
                "Bölme Sonucu: " + Episode.ToString();
        }
    }
}
