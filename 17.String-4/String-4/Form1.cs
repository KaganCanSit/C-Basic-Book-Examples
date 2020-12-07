using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_4
{
    public partial class ComputerComponent : Form
    {
        public ComputerComponent()
        {
            InitializeComponent();
        }

        //Uygulama5:Klavyeden girilen bilgisayar parçası isimlerini değişken kullanara ComboBox'a yazdıran uyg. kodlayınız.
        //Butona tıklandığında TextBox içerisindeki metini ComboBox içersine ekle.
        private void AddButton_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Add(ComponentTextBox.Text);
        }
    }
}
