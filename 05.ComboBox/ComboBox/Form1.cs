using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ComboBox bir listeleme aracıdır.
        //Uygulama7:Aşağıdaki satırda Butona tıkladığımızda ComboBox listesine bir şehir daha ekleyeceğiz.
        private void AddBttn_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Trabzon");

            //Uygulama8: Direk yazı olarak eklemek yerine bir TextBox'dan alıp ekleyelim.
            comboBox1.Items.Add(AddCityBttn.Text);
        }
    }
}
