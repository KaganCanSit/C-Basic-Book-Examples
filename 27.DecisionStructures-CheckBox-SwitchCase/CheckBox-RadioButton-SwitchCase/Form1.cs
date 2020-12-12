using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_RadioButton_SwitchCase
{
    public partial class İslemButton : Form
    {
        public İslemButton()
        {
            InitializeComponent();
        }

        //Uygulama11(CheckBox): Button aracına tıklandığı zaman eğer CheckBox işaretli ise Label'a aktif, değilse pas yazdıran prog. kodlayınız.
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (TryCheckBox.Checked == true)
            {
                TryLabel.Text = "Aktif";
            }
            else
            {
                TryLabel.Text = "Pas";
            }
        }

        /*
         * !Önemli: CheckBox ile RadioButton'un farkı Radio butonda her zaman en az bir seçeneğin işaretli olması gerekir. 
         * CheckBox da böyle bir şart yoktur.
        */

        /*
            Uygulama12(RadioButton): Button'a tıklandığı zaman RadioButtonlar'da yer alan 'Erkek' ya da 'Kadın' seçimlerine göre
            seçilen değeri Label'a yazdıran prg. kodlayınız.
        */
        private void ManWomanButton_Click(object sender, EventArgs e)
        {
            if (ManRadioButton.Checked == true)
            {
                ManWomanLabel.Text = "Seçiminiz: Erkek";
            }
            else if (WomanRadioButton.Checked == true)
            {
                ManWomanLabel.Text = "Seçiminiz: Kadın";
            }

        }

        //Uygulama13(RadioButton): Klavyeden girilen iki sayıya RadioButton'lardan seçilen aritmetik işleme göre hesaplama yaptıran prog. kodlayınız.
        private void IslemButton_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(NumberTextBox1.Text);
            sayi2 = Convert.ToInt32(NumberTextBox2.Text);

            if (ToplamRadioBttn.Checked == true)
            {
                sonuc = sayi1 + sayi2;
                SonucLabel.Text = "Toplama İşlemi Sonucu: " + sonuc.ToString();
            }
            else if (CikarmaRadioBttn.Checked == true)
            {
                sonuc = sayi1 - sayi2;
                SonucLabel.Text = "Cikarma İslemi Sonucunuz: " + sonuc.ToString();
            }
            else if (BolmeRadioBttn.Checked == true)
            {
                sonuc = sayi1 / sayi2;
                SonucLabel.Text = "Bolme İslemi Sonucunuz: " + sonuc.ToString();
            }
            else if (CarpmaRadioBttn.Checked == true)
            {
                sonuc = sayi1 * sayi2;
                SonucLabel.Text = "Carpma İslemi Sonucunuz: " + sonuc.ToString();
            }
            else
            {
                SonucLabel.Text = "İslem türünü seçmediniz." + Environment.NewLine + "Tekrar deneyiniz!";
            }
        }

        /*
         * Uygulama14(RadioButton): Klavyeden kullanıcı tarafından bir ürünün fiyatını girip RadioButton araçlarından seçilen yüzde 8
           ya da 18 KDV oranına göre KDV'li halini Label'a yazdıran prg. kodlayınız.
        */
        private void HesaplaButton_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(TutarTextBox.Text);

            if (KDVRadioButton18.Checked == true)
            {
                tutar = (tutar * 18 / 100) + tutar;
                HesaplaLabel.Text = tutar.ToString();
            }
            else if (KDVRadioButton8.Checked == true)
            {
                tutar = (tutar * 8 / 100) + tutar;
                HesaplaLabel.Text = tutar.ToString();
            }
        }

        //Uygulama15(Switch-Case): Klavyeden girilen sayıya göre yılın ayını veren prog. kodlayınız.
        private void AyButton_Click(object sender, EventArgs e)
        {
            int ay;
            ay = Convert.ToInt32(AyTextBox.Text);

            switch (ay)
            {
                case 1:
                        AyLabel.Text = "Ayınız: Ocak";
                        break;
                case 2:
                        AyLabel.Text = "Ayınız: Şubat";
                        break;
                case 3:
                        AyLabel.Text = "Ayınız: Mart";
                        break;
                case 4:
                        AyLabel.Text = "Ayınız: Nisan";
                        break;
                case 5:
                        AyLabel.Text = "Ayınız: Mayıs";
                        break;
                case 6:
                        AyLabel.Text = "Ayınız: Haziran";
                        break;
                case 7:
                        AyLabel.Text = "Ayınız: Temmuz";
                        break;
                case 8:
                        AyLabel.Text = "Ayınız: Ağustos";
                        break;
                case 9:
                        AyLabel.Text = "Ayınız: Eylül";
                        break;
                case 10:
                        AyLabel.Text = "Ayınız: Ekim";
                        break;
                case 11:
                        AyLabel.Text = "Ayınız: Kasım";
                        break;
                case 12:
                        AyLabel.Text = "Ayınız: Aralık";
                        break;
                default:
                        AyLabel.Text = "Yanlış Değer Aralığı Girdiniz.";
                        break;
            }

        }

        //Uygulama16(Switch-Case): Klavyeden girilen plakaya göre şehri Label aracına yazdıralım.
        private void PlakaButton_Click(object sender, EventArgs e)
        {
            int plaka;
            plaka = Convert.ToInt32(PlakaTextBox.Text);

            switch (plaka)
            {
                case 01: PlakaLabel.Text = "Şehiriniz: Adana"; break;
                case 11: PlakaLabel.Text = "Şehiriniz: Bilecik"; break;
                case 26: PlakaLabel.Text = "Şehiriniz: Eskişehir"; break;
                case 06: PlakaLabel.Text = "Şehiriniz: Ankara"; break;
                case 45: PlakaLabel.Text = "Şehiriniz: Manisa"; break;
                default: PlakaLabel.Text = "Şehiriniz: Henüz Eklenmedi."; break;
            }
        }

        //Uygulama17(Switch-Case): Klavyeden girilen mevsime göre o mevsime ait ayları Label aracına yazdıran prg. kodlayınız.
        private void MevsimButton_Click(object sender, EventArgs e)
        {
            string mevsim;
            mevsim = MevsimTextBox.Text;

            switch (mevsim)
            {
                case "İlkbahar": MevsimLabel.Text = "Mevsim Aylarınız:" + Environment.NewLine + "Mart - Nisan - Mayıs"; break;
                case "Yaz": MevsimLabel.Text = "Mevsim Aylarınız:" + Environment.NewLine + "Haziran - Temmuz  Ağustos"; break;
                case "Sonbahar": MevsimLabel.Text = "Mevsim Aylarınız:" + Environment.NewLine + "Eylül - Ekim - Kasım"; break;
                case "Kış": MevsimLabel.Text = "Mevsim Aylarınız:" + Environment.NewLine + "Aralık - Ocak - Şubat"; break;
                default: MevsimLabel.Text = "Yanlış metin girdiniz." + Environment.NewLine + "Yeniden Deneyiniz."; break;
            }
        }

        //Uygulama18(Switch-Case): Klavyeden girilen iki sayıya yine klavyeden girilen sembole göre aritmetik işlem yapan prog. kodlayınız.
        private void IslemBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, sonuc;
            char islem;

            num1 = Convert.ToInt32(Sayi1TextBox.Text);
            num2 = Convert.ToInt32(Sayi2TextBox.Text);
            islem = Convert.ToChar(IslemTextBox.Text);

            switch (islem)
            {
                case '+':
                    sonuc = num1 + num2;
                    IslemSonucuLabel.Text = "Toplam Sonucu: " + sonuc.ToString();
                    break;
                case '-':
                    sonuc = num1 - num2;
                    IslemSonucuLabel.Text = "Fark Sonucu: " + sonuc.ToString();
                    break;
                case '/':
                    sonuc = num1 / num2;
                    IslemSonucuLabel.Text = "Bölüm Sonucu: " + sonuc.ToString();
                    break;
                case '*':
                    sonuc = num1 * num2;
                    IslemSonucuLabel.Text = "Carpim Sonucu: " + sonuc.ToString();
                    break;
                default:
                    IslemSonucuLabel.Text = "Yanlış islem seçimi. Yeniden deneyiniz.";
                    break;
            }
        }
    }
}
