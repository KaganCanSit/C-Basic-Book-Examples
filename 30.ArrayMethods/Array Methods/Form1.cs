using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Methods
{
    public partial class ArrayMethods : Form
    {
        public ArrayMethods()
        {
            InitializeComponent();
        }

        /*
         * Lenght Metodu: Bu metot dizide içerisinde bulunan toplam elaman sayısı sayar.
         * Çalışma prensibi bir foreach döngüsü mantığındadır. Değerleri tek tek okur, taki null bir değer ile karşılaşana kadar.
         */
        private void LengthButton_Click(object sender, EventArgs e)
        {
            int[] lenght = { 11, 25, 36, 79, 71, 495, 65, 741, 16, 28 };
            
            LengthLabel.Text ="Dizinin Eleman Sayısı:" + Convert.ToString(lenght.Length);
        }

        // Short Metodu: Bu metot dizi içerisinde bulunan elemanları küçükten büyüğe herhangi bir ek kullanmadan sıralar.
        private void ShortButton_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 14, 58, 74, 2, 1, 3, 8, 79, 456, 147 };
            Array.Sort(sayilar);

            for (int i=0 ;i<sayilar.Length ;i++)
            {
                SortListBox.Items.Add(Convert.ToString(sayilar[i]));
            }
        }

        //Reverse Metodu: Diziye girilen değerlerin sırasının tersini alır. İlk indexi son indexe sıra ile değiştirir. Kullanım: Array.Reverse(DİZİ İSMİ);
        private void ReverseButton_Click(object sender, EventArgs e)
        {
            int[] TersSirala = { 14,25,36,47,58,69,78,89,97};
            Array.Reverse(TersSirala);

            for (int i = 0; i < TersSirala.Length; i++)
            {
                ReverseListBox.Items.Add(Convert.ToString(TersSirala[i]));
            }

            //IndexOf Metodu: Dizi içerisinde aranan değerin index sırasını bizlere verir. Kullanım: Array.IndexOf(DİZİ İSMİ, ARANAN DEĞER);
            int sira;
            sira = Array.IndexOf(TersSirala, 58);

            IndexOfLabel.Text = "58 Değerinin Index Sırası: " + Convert.ToString(sira);

            //Max-Min Metodu: Dizi içerisindeki en büyük ve en küçük değeri otomatik bulmayı sağlayan metoddur. Kullanım: DİZİİSMİ.Max();
            MaxLabel.Text = "Max Değer: " + Convert.ToString(TersSirala.Max());
            MinLabel.Text = "Min Değer: " + Convert.ToString(TersSirala.Min());
        }
    }
}
