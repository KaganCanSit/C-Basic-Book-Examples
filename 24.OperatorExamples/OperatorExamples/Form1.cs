using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorExamples
{
    public partial class Operators : Form
    {
        public Operators()
        {
            InitializeComponent();
        }

        /*
            Operatörler: Matematiksel işlemleri gerçekleştirebilmemizi(Aritmetik Operatörler), 
        karşılaştırma yapabilmemizi(Mantıksal Operatörler),atama yapabilmezi vb. birçok işlemi sağlayan yapılardır.
        Örn: Aritmetik Operatörler 5 Ana Maddeden Oluşur;
            -Toplama - Çıkarma - Çarpma - Bölme -Mod Alma -Eşittir -Büyük Eşit/Küçük Eşit -Eşit Değildir(!=)
            
        (Bunlar bir sonraki karar yapıları içerisinde fazlaca yer alacak. Oradan ayrıca incelenebilir.)
        Ek olarak: && (Ve) Operatörü iki durum sağlıyorsa işlem gerçekleşir.
                       || (Veya) Operatörü iki durumdan biri doğruysa işlemi gerçekleştir.
                       = Atama Operatörü
                       =+ =- İşlemleri hızlı bir şekilde gerçekleştirmemizi sağlar. Örn: sayi=sayi+4 yeri sayi=+4 yazarız.
                       ?: (Koşul) Operatörü Örn: "e" ? "Doğruysa burayı" : "Yanlışsa burayı" gerçekleştir.
         */

        //Bazı Operatörlerin Basit Kullanımları
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int sayi1 = 0, sayi2 = 0, toplam = 0, kalan = 0, bolum = 0, carpim = 0, mod = 0;
            sayi1 = Convert.ToInt32(ValueTextBox1.Text);
            sayi2 = Convert.ToInt32(ValueTextBox2.Text);

            toplam = sayi1 + sayi2;
            kalan = sayi1 - sayi2;
            bolum = sayi1 / sayi2;
            carpim = sayi1 * sayi2;
            mod =(sayi1%sayi2);

            sayi1--;
            sayi2++;

            if (sayi1 == sayi2)
            {
                ValueListBox.Items.Add("Sayı Değerleri Birbirine Eşittir.");
            }
            else
            {
                ValueListBox.Items.Add("Sayı Değerleri Birbirine Eşit Değildir.");
                if(sayi1<sayi2)
                {
                    ValueListBox.Items.Add("Sayı2 Değeri Sayi1 Değerinden Büyüktür");
                }
                else
                {
                    ValueListBox.Items.Add("Sayı1 Değeri Sayi2 Değerinden Büyüktür");
                }
            }

            ValueListBox.Items.Add("Toplam: " + toplam.ToString());
            ValueListBox.Items.Add("Kalan: " + kalan.ToString());
            ValueListBox.Items.Add("Bolum: " + bolum.ToString());
            ValueListBox.Items.Add("Carpim: " + carpim.ToString());
            ValueListBox.Items.Add("Mod: " + mod.ToString());
            ValueListBox.Items.Add("Sayi1 Değerini 1 Azaltır ve Sayi2 Değerini Bir Arttırsak:");
            ValueListBox.Items.Add("1.Sayi Değeri: " + sayi1);
            ValueListBox.Items.Add("2.Sayi Değeri: " + sayi2);
        }
    }
}
