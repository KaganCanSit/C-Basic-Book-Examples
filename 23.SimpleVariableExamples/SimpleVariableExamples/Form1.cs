using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVariableExamples
{
    public partial class Veriables : Form
    {
        public Veriables()
        {
            InitializeComponent();
        }

        //Uygulama26:Klavyeden girilen Short türündeki 2 sayıyı toplayıp sonucu label aracına yazdıran kodu giriniz.
        //Short değeri aralığı -32768 ile +32767 arasındadır. İşaretli bir değişkendir.
        private void ShortTotalButton_Click(object sender, EventArgs e)
        {
            //!!Önemli Not: Byte. Sbyte, Short değişkenleri işlemleri yapılıp, üçüncü bir değişkene atanamaz.
            short sayi1 = 1440,  sayi2=2562;
            ShortTotalLabel.Text ="Short Toplam: " + (sayi1+sayi2).ToString();
        }

        //Uygulama27:Kodlama kısmından girilen UShort türündeki değeri label aracına yazdıran kodu yazalım.
        //Ushort değerinin aralığı 0 - 65535 arasında tanımlıdır. İşaretsiz bir değişkendir.
        private void UShortButton_Click(object sender, EventArgs e)
        {
            ushort sayi2 = 65535;
            UShortLabel.Text = "UShort Sayı Değeri: " + sayi2.ToString();
        }

        //Uygulama28:Kod kısmından girdiğimiz Float türündeki sayıyı Label aracımıza yazdıralım.
        //Float: Ondalık hassasiyeti 7 olan. Double türüne göre daha küçük değişkenimizdir.
        private void FloatButton_Click(object sender, EventArgs e)
        {
            
            /*
            Önemli!!: C# ondalıklı ifadelerin varsayılan değişken türü Double'dır.Bundan dolayı Float ve Decimal değikenleri tanımlarken
            Float ifadelerin sonuna f, Decilmak için m harfi eklenir.
            */
            float sayi3 = 27.19f;
            FloatLabel.Text = "Float Sayı Değeri: " + sayi3.ToString();
        }

        //Uygulama29:Kod kısmından girdiğimiz Decimal türündeki sayıyı Label aracımıza yazdıralım.
        //Float: Ondalık hassasiyeti 29 olan. Double ve Float türüne göre çok daha büyük değişkenimizdir.
        private void DecimalButton_Click_1(object sender, EventArgs e)
        {
            /*
            Önemli!!: C# ondalıklı ifadelerin varsayılan değişken türü Double'dır.Bundan dolayı Float ve Decimal değikenleri tanımlarken
            Float ifadelerin sonuna f, Decilmak için m harfi eklenir.
            */

            decimal sayi4 = 47.191198m;
            DecimalLabel.Text = "Decimal Sayı Değeri: " + sayi4.ToString();
        }

        //Uygulama30: Kod kısmından girilen ifadeyi Label aracına mantıksal türde yazdıralım.
        //Bool(Boolean)=True or False değişkendir. 1 veya 0 içerir.
        private void BollButton_Click(object sender, EventArgs e)
        {
            bool durum = true;
            BoolLabel.Text = "Bool Değeri: " + durum.ToString();
        }

        //Uygulama31:Kod kısmından girilen sayının 20'den büyük olup olmadığını bool değişkeni ile kontrol edelim.
        private void BoolNumButton_Click(object sender, EventArgs e)
        {
            int deger = 14;
            bool cevap;
            cevap = deger > 20;
            BoolNumLabel.Text = "Bool Değeri: " + cevap.ToString();
        }
    }
}
