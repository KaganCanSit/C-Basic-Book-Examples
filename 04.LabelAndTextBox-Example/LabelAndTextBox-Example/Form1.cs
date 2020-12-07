using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAndTextBox_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            SaveNameLabel.Text ="ADI:" + NameBox.Text;
            SaveSurnameLabel.Text = "SOYADI:" + SurnameBox.Text;
            SaveAgeLabel.Text = "YAŞI:" + AgeBox.Text;
            SaveClassLabel.Text = "SINIFI:" + ClassBox.Text;
        }
    }
}
