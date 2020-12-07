using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Uygulama4: Text Box'a bir metinsel ifadeyi yazdırınız.
        //Yazdır Button'a tıklandığında gerçekleştir.
        private void PrintButton_Click(object sender, EventArgs e)
        {
            TextPrintBox.Text = "Yalnız tek bir şeye ihtiyacımız vardır, çalışkan olmak. " + Environment.NewLine +
            "Servet ve onun tabii neticesi olan refah ve saadet yalnız ve ancak çalışkanların hakkıdır." + Environment.NewLine +
            "Mustafa Kemal Atatürk";
            //Environment.NewLine Komutu bir alt satıra geçmesini sağlar.


            //Uygulama5: TextBox'a girilmiş veriyi Label'a yazdırma.
            //TextBox içerisindeki veriyi Label içerisine atadık.
            PrintLabel.Text = TextPrintBox.Text;
        }
    }
}
