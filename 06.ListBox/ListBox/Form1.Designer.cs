﻿
namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Kağan",
            "Ali",
            "Mehmet",
            "Ece",
            "Eda",
            "Ege",
            "Efe",
            "Burak",
            "Metin",
            "İskender",
            "Cumhur"});
            this.listBox1.Location = new System.Drawing.Point(38, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 228);
            this.listBox1.TabIndex = 0;
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(38, 309);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(265, 22);
            this.AddBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eklemek İstediğinizi Yazınız:";
            // 
            // AddBttn
            // 
            this.AddBttn.Location = new System.Drawing.Point(119, 349);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(102, 31);
            this.AddBttn.TabIndex = 3;
            this.AddBttn.Text = "Ekle";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 402);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBttn;
    }
}

