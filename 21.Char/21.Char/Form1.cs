using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.Char
{
    public partial class BasicChar : Form
    {
        public BasicChar()
        {
            InitializeComponent();
        }

        //Uygulama20: Kod kısmından girilen char değişkeni labela yazdıran programı kodlayınız.
        private void LatterButton_Click(object sender, EventArgs e)
        {
            char harf='k';
            LetterLabel.Text ="Harfimiz: " +  harf.ToString();
        }


        //Uygulama21: Klavyeden girilen harfi char değişkeni olarak alıp label'a yazdıran programı kodlayınız.
        private void GetLatterButton_Click(object sender, EventArgs e)
        {
            char harfal;
            harfal = Convert.ToChar(GetLatterTextBox.Text);
            WriteLatter.Text ="Girilen Harf: " + harfal.ToString();
        }
        /*
            Uygulama23:Kullanıcı tarafından ad,soyad, sınav1, sınav2, sınav3 bilgileri girilen kişinin 
            adını ,soyadını ve ortalamasını ListBox'a ekleyen programı yazınız.
        */
        private void GiveButton_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double sinav1, sinav2, sinav3, ortalama;

            ad = NameTextBox.Text;
            soyad = SurnameTextBox.Text;

            sinav1 = Convert.ToDouble(ExamTextBox1.Text);
            sinav2 = Convert.ToDouble(ExamTextBox2.Text);
            sinav3 = Convert.ToDouble(ExamTextBox3.Text);
            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            ResultListBox.Items.Add(ad + " " + soyad + "- Ortalama: " + ortalama.ToString());
        }
    }
}
