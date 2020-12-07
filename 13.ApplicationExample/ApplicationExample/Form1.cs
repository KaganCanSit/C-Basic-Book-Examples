using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationExample
{
    public partial class TravelCompanyForm : Form
    {
        public TravelCompanyForm()
        {
            InitializeComponent();
        }
        /*
            Uygulama13: Elazığ-Malatya-Gaziantep illeri arasında çalışan Jüpiter Firması yolcu bilgilerinin kaydedilmesi
            için bir program hazırlanması isteniyor. Programda yolcuların ad, soyad, TC no, telefon, gibi kişisel bilgileri
            ve nereden nereye gittikleri, hangi tarih ve saatte gidecekleri gibi bilgilerin yazdırılıp ListBox'a
            kaydedilmesi istenmektedir.
        */

        //Butona tıkladığımızda verileri ListBox'a yadırmasını sağladık.
        //Tüyo! ListBox özelliklerinde scroll bar vb. ayarlar açarak sağa ve aşağıya kaydırma sağlayabiliriz.
        private void AddButton_Click(object sender, EventArgs e)
        {
            PrintAllListBox.Items.Add(NameBox.Text + " " + TCNoMaskedBox.Text + " " + PhoneMaskedBox.Text);
            PrintAllListBox.Items.Add(WhereFromComboBox.Text + " " + WhereBox.Text + " " +
                DateMaskedTextBox.Text + " " + TimeMaskedBox.Text);
        }

    }
}
