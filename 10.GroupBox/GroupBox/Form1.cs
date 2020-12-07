using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Kullanıcı Bilgileri Panelini ComboBox Yardımıyla Tasarlayınız, Çıktı Verilerini ListBox'a yazdırınız.
        //ComboBox aracı yardımıyla ile bilgileri sınıflandırılmış görünüm veriniz, ayrıca içerisinde tanımlanan verileri ListBox'a yazdırınız.
        private void AddButton_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(NameTextBox.Text + " " + TCNoMaskedBox.Text + " " + PhoneMaskedBox.Text + " " + AgeTextBox.Text);
            ListBox.Items.Add(CityComboBox.Text + " " + JobTextBox.Text + " " + DateMaskedBox.Text);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
        }
    }
}
