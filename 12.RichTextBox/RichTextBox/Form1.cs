using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //RichTextBox: Normal TextBox'dan farklı olarak alt satıra yazı yazma imkanı sağlar. Özellikle uzun metinler için kullanılmaktadir.
        private void ShowButton_Click(object sender, EventArgs e)
        {
            RichTextBox.Text="Hayatta en hakiki mürşit ilimdir, fendir! Mustafa Kemal Atatürk";
        }
    }
}
