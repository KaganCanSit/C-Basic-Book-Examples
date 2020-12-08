using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byte_Sbyte
{
    public partial class Byte_Sbyte : Form
    {
        public Byte_Sbyte()
        {
            InitializeComponent();
        }

        //Uygulama23: Kod kısmından girilen Byte türündekibir değeri Label aracına yazdıran programı yazınız.
        private void GetByteButton_Click(object sender, EventArgs e)
        {
            byte deger=124;
            ByteLabel.Text = "Örnek Byte Değeri: " + deger.ToString();
        }

        //Uygulama24: Klavyeden girilen Sbyte türündeki değeri label aracına yazdıran programı yazınız.
        private void SbyteButton_Click(object sender, EventArgs e)
        {
            sbyte value = 0;
            value=Convert.ToSByte(SbyteTextBox.Text);
            Value.Text = value.ToString();
        }
    }
}
