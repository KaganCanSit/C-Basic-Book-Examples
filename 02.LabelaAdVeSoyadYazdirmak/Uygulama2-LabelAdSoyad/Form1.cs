using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2_LabelAdSoyad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Uygulama2: Label üzerinden Adınızı Ve Soyadınızı Yazıdırınız.
        //NameSurnameButton'a tıklandığında bu işlemleri gerçekleştir.
        private void NameSurnameButton_Click(object sender, EventArgs e)
        {
            //Label etiketlerine Text olarak atadık.
            NameLabel.Text = "Ad: Kağan Can";
            SurnameLabel.Text = "Soyad: Şit";

            //Uygulama3: Ayrıca şehir,ilçe,iş kısımlarını ekledik.
            CityLabel.Text = "Şehir: Bilecik";
            DistrictLabel.Text = "İlçe: Bozüyük";
            JobLabel.Text = "Meslek: Öğrenci";
        }
        //!Ek Bilgi: Süslü parantezler arasındaki alana(komutlara) verilen isim "Scope".
    }
}
