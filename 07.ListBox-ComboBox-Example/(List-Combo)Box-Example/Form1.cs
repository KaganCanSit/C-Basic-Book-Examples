using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _List_Combo_Box_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            Uygulama10: Klavyeden adı ve soyadı girilen, ComboBox'tan cinsiyeti ve bir diğer ComboBox'tan
            sabahçı mı yoksa öğlenci mi olduğu seçilen öğrencilerin bilgilerini ListBox'a yadıran uygulamayı yazınız.
        */

        //Butona basıldığında TextBox'lar ve ComboBox'larda bulanan verileri ListBox'a eklemesini istiyoruz.
        private void AddBttn_Click(object sender, EventArgs e)
        {
            DetailBox.Items.Add(NameBox.Text + " " + SurnameBox.Text + " " + GenderBox.Text + " " + StatusBox.Text);
        }
    }
}
