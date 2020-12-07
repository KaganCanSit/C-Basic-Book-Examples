using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_3
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        //Uygulama4:Klavyeden girilen kitap adı ve yazar isimlerini ListBox'a yazdıran uyg. yazınız.
        private void AddButton_Click(object sender, EventArgs e)
        {
            WriteListBox.Items.Add(BookNameTextBox.Text + " - " + WriterTextBox.Text);
        }
    }
}
