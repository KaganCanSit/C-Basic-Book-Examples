using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Array : Form
    {
        public Array()
        {
            InitializeComponent();
        }

        /*
         * !Dizi aynı zamanda bir sınıftır. Sınıfa dair bir örnek verecek olursak; apartmanı bir sınıf olarak deüşünelim. Apartmanın
         * içerisinde daireler birer nesne, dairenin iç özellikleri renk,kat,fiyat vs. bunlarda bizim özelliklerimizdir.
         * Sınıflardan türetilen nesnelerin birbir aynı olması söz konusu değil. Örneğin 1.kattaki biri en küçük odayı çocuk odası 
         * yaparken, diğer katlar farklı şekillerde özelleştirebilir. Yani farklı özellik ve nitelikler ekleyebilirler. 
         *
         * index: Dizinin bellekte kaçıncı sırada tutalacağını belirler.
         * 
         * Sınıf Adı NesneAdı = new SınıfAdı
         * Değiken türü [] Dizi Adı = new Değişken Türü [Eleman Sayısı]
         */




        /*
         * Uygulama1: 5 elemandan oluşan bir renkler dizisi tanımlayıp bu diziye veri girişi yapalım ve dizinin 2.index'inde
         * bulunan elamanı yazdıralım.
        */
        private void ColorButton_Click(object sender, EventArgs e)
        {
            string[] renkler = new string[6];
            renkler[0] = "Sarı";
            renkler[1] = "Mavi";
            renkler[2] = "Beyaz";
            renkler[3] = "Turuncu";
            renkler[4] = "Kırmızı";
            ColorLabel.Text = renkler[2];
        }
 
        //Uygulama2: 4 elamandan oluşan bir iller dizisi oluşturup 1.indexte ki değeri çağıralım.
        private void MarkaButton_Click(object sender, EventArgs e)
        {
            string[] marka = new string[4];
            marka[0] = "Monster";
            marka[1] = "Asus";
            marka[2] = "Lenovo";
            marka[3] = "Dell";

            MarkaLabel.Text = marka[1];
        }

        //Uygulama3: 8 elemandan oluşan bir çift sayılar dizisi oluşturup 6.indexinde ki değeri yazdıralım.
        private void SayıButton_Click(object sender, EventArgs e)
        {
            int[] cift = new int[8];
            cift[0] = 2;
            cift[1] = 222;
            cift[2] = 32;
            cift[3] = 48;
            cift[4] = 76;
            cift[5] = 84;
            cift[6] = 96;
            cift[7] = 16;

            SayıLabel.Text = Convert.ToString(cift[6]);
        }

        //Uygulama4: Oluşturulan 5 elemanlı firmalar dizisinin tüm elemanlarını ListBox aracına yazdıran prg. kodlayınız.
        private void FirmaButton_Click(object sender, EventArgs e)
        {
            string[] firma = { "Microsoft", "IBM", "Apple", "Google", "Amazon" };

            for(int i=0;i<5;i++)
            {
                FirmalarListBox.Items.Add(firma[i]);
            }
        }

        //Uygulama5: 5 elemanlı bir ondalıklı sayı dizisindeki elemanları ListBox aracına yazdıralım.
        private void OndalikliButton_Click(object sender, EventArgs e)
        {
            double[] ondalikli = { 12.15, 123.78, 147.78, 365.1, 11.12 };
            for (int i = 0; i < 5; i++)
            {
                OndalikliListBox.Items.Add(ondalikli[i]);
            }
        }

        //!!Önemli Örnek: Uygulama6: Kullanıcıdan 5 adet şehir ismi alıp, ListBox'a ekleyiniz.
        string[] sehir = new string[5];
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            sehir[sayac] = SehirTextBox.Text;
            sayac++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<5;i++)
            {
                SehirListBox.Items.Add(sehir[i]);
            }
        }

        //Uygulama7: Oluşturulan bir dizideki en büyük elemanı bulan programı yazdıralım.
        private void EnBuyukButton_Click(object sender, EventArgs e)
        {
            int[] dizi = {102,45,78,96,74,852,741,964,789,146 };
            int buyuksayi=0;

            for(int i=0; i<dizi.Length; i++) // Length: Dizi büyüklüğünü bulan program.
            {
                if(buyuksayi<dizi[i])
                {
                    buyuksayi = dizi[i];
                }
            }

            EnBuyukLabel.Text = Convert.ToString(buyuksayi);
        }

        //Uygulama8: Oluşturulan bir dizideki en küçük elemanı bulan prg. yazınız.
        private void EnKucukButton_Click(object sender, EventArgs e)
        {
            int[] dizi = { -125, 5, 11, 147, -784, 85, 4, 94, 89, 14 };
            int kucuksayi = 0;

            for (int i = 0; i < dizi.Length; i++) // Length: Dizi büyüklüğünü bulan program.
            {
                if (kucuksayi > dizi[i])
                {
                    kucuksayi = dizi[i];
                }
            }

            EnKucukLabel.Text = Convert.ToString(kucuksayi);
        }
    }
}
