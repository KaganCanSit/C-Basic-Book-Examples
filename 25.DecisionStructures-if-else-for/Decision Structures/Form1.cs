using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structures
{
    public partial class DecisionStructuresForm : Form
    {
        public DecisionStructuresForm()
        {
            InitializeComponent();
        }

        //Eğer TextBox'a girilen metin abc ise labela doğru, değilse yanlış yazdıran prg. kodlayalım.
        private void abcButton_Click(object sender, EventArgs e)
        {
            if (abcTextBox.Text == "abc" || abcTextBox.Text == "ABC")
            {
                abcLabel.Text= "Sonuç: " +  "abc metnini girdiniz.Doğru metin!";
            }
            else
            {
                abcLabel.Text="Sonuç:" + "abc metnini girmediniz. Yanlış metin.";
            }
        }

        //Uygulama2: Klavyeden girilen sayının pozitif mi yoksa negatif mi olduğunu bulan prg. yazınız.
        private void GetNumberButton1_Click(object sender, EventArgs e)
        {
            //NegPoz(Negatif Pozitif) adında değişken tanımlayarak TextBox içerisindeki değeri atadık.
            int NegPoz;
            NegPoz = Convert.ToInt32(GetNumberTextBox.Text);
        
            if(NegPoz<0)
            {
                NPResultLabel.Text = "Sayınız: Negatiftir.";
            }
            else
            {
                NPResultLabel.Text = "Sayınız: Pozitiftir.";
            }
        }


        //Uygulama3: Klavyeden girilen sayının pozitif mi yoksa negatif mi olduğunu bulan prog. yazalım.
        private void GetNumberButton_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(NumberTextBox.Text);

            //!Önemli: Bir sayının çift olduğunu anlamamız içim mod2'sini alırız. Çift sayıların mod2'si 0'a eşittir.
            if(sayi%2==0)
            {
                ResultLabel.Text = "Sayınız: Çifttir.";
            }
            else
            {
                ResultLabel.Text = "Sayınız: Tektir.";
            }
        }

        /*
            Uygulama4: Klavyeden girilen 3 sınav notuna göre öğrencinin ortalamasını hesaplayıp,
            eğer ortlaması 50'den büyük ve eşitse geçti, aksi durumda kaldı mesajlarını label'a yazdıran prg. kodlayınız.
         */
        private void ExamButton_Click(object sender, EventArgs e)
        {
            int exam, exam1, exam2, ortalama;

            //Değerleri TextBox'lardan değişkenlere çektik.
            exam = Convert.ToInt32(ExamTextBox1.Text);
            exam1 = Convert.ToInt32(ExamTextBox2.Text);
            exam2 = Convert.ToInt32(ExamTextBox3.Text);

            if(exam>100 || exam<0 || exam1 > 100 || exam1 < 0 || exam2 > 100 || exam2 < 0)
            {
                MessageBox.Show("Not değeri 100'den büyük veya 0'dan küçük olamaz");
                Environment.Exit(0);
            }

            ortalama = (exam + exam1 + exam2) / 3;
            AverageLabel.Text ="Ortalama:" + ortalama.ToString();

            if (ortalama>=50)
            {
                StatusLabel.Text = "Durum: Dersten Geçti.";
            }
            else
            {
                StatusLabel.Text = "Durum: Dersten Kaldı.";
            }
        }

        /*
            Uygulama5: Bir kullancı adı ve şifre kontrolü programı yapalım. Eğer kullanıcı adı "erol" şifresi "sungur" ise Label'a 
        "Hoşgeldiniz", aksi durumda "Hatalı Bilgi Girişi" yazdıran prog. yazınız.
        */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserTextBox.Text=="erol" && PassawordTextBox.Text=="sungur")
            {
                LoginLabel.Text = "Giriş Başarılı." + Environment.NewLine + "Hoşgeldiniz";
            }
            else
            {
                LoginLabel.Text = "Hatalı Bilgi Girişi." + Environment.NewLine + "Yeniden Deneyiniz.";
            }

        }
    }
}
