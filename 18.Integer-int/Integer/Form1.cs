using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
            !Önemli Noktalar
                ToString() metodu: C#'da yazdıralan değerler string metoddadır. Bundan dolayı integer'ı string'e dönüştürmek için kullanırız.
                Örn: sayi.ToStirng()

                Convert: Değişkenleri birbirine çevirmemizi sağlayan bir yardımcı metoddur.
                Örn: Convert.ToInt16(textBox1.Text); textBox1'den alınan değeri integer olarak değiştirmiş olduk.
        */
        
        private void WriteButton_Click(object sender, EventArgs e)
        {
            //Uygulama6: Kod kısmından girilen bir sayıyı label'a yazdıran programı kodlayınız.
            int sayi;
            sayi = 14;
            NumberLabel.Text = sayi.ToString();

            //Uygulama7: Kod kısmından girilen iki sayıyı toplayarak label'a yazdırınız.
            int toplam=0, sayi1=1459, sayi2=4101;
            toplam = sayi1 + sayi2;
            TotalLabel.Text = sayi1.ToString() + " + " + sayi2.ToString() +" = "+ toplam.ToString();

            //Uygulama8: Kod kısmında değer vererek karenin alan ve çevresni hesaplayarak yazdırınız.
            int kenar=8, alan=0, cevre=0;
            alan = kenar * kenar;
            cevre = 4 * kenar;
            SquareLabel.Text= "Kare"+ Environment.NewLine +
                "Alan: " + alan.ToString() + Environment.NewLine + 
                "Çevre: " + cevre.ToString();

            //Uygulama9: Kod kısmından iki sınav notu girilen öğrencinin not ort. hesaplayan programı kodlayınız.
            int sinav1 = 32, sinav2 = 70, ortalama=0;
            ortalama = (sinav1 + sinav2) / 2;
            AverageLabel.Text = "Ortalama: " + ortalama.ToString();

            //Uygulama10: Kod kısmından girilen sayının kübünü alan programı kodlayınız.
            int kupsayi = 72, kup=0;
            kup = kupsayi * kupsayi * kupsayi;
            CupeLabel.Text = kupsayi.ToString() + " sayisinin "+ Environment.NewLine + "Küp Değeri: " + kup.ToString();
        }
    }
}
