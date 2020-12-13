
namespace _2Example
{
    partial class Examples
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
            this.OdevGroupBox1 = new System.Windows.Forms.GroupBox();
            this.OdevGroupBox2 = new System.Windows.Forms.GroupBox();
            this.GunComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.GunLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KarakterComboBox = new System.Windows.Forms.ComboBox();
            this.WriteButton1 = new System.Windows.Forms.Button();
            this.KarakterLabel = new System.Windows.Forms.Label();
            this.OdevGroupBox1.SuspendLayout();
            this.OdevGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdevGroupBox1
            // 
            this.OdevGroupBox1.Controls.Add(this.GunLabel);
            this.OdevGroupBox1.Controls.Add(this.WriteButton);
            this.OdevGroupBox1.Controls.Add(this.label2);
            this.OdevGroupBox1.Controls.Add(this.label1);
            this.OdevGroupBox1.Controls.Add(this.GunComboBox);
            this.OdevGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.OdevGroupBox1.Name = "OdevGroupBox1";
            this.OdevGroupBox1.Size = new System.Drawing.Size(290, 236);
            this.OdevGroupBox1.TabIndex = 0;
            this.OdevGroupBox1.TabStop = false;
            this.OdevGroupBox1.Text = "Ödev-1";
            // 
            // OdevGroupBox2
            // 
            this.OdevGroupBox2.Controls.Add(this.KarakterLabel);
            this.OdevGroupBox2.Controls.Add(this.WriteButton1);
            this.OdevGroupBox2.Controls.Add(this.label4);
            this.OdevGroupBox2.Controls.Add(this.label3);
            this.OdevGroupBox2.Controls.Add(this.KarakterComboBox);
            this.OdevGroupBox2.Location = new System.Drawing.Point(308, 12);
            this.OdevGroupBox2.Name = "OdevGroupBox2";
            this.OdevGroupBox2.Size = new System.Drawing.Size(290, 236);
            this.OdevGroupBox2.TabIndex = 1;
            this.OdevGroupBox2.TabStop = false;
            this.OdevGroupBox2.Text = "Ödev-2";
            // 
            // GunComboBox
            // 
            this.GunComboBox.FormattingEnabled = true;
            this.GunComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.GunComboBox.Location = new System.Drawing.Point(80, 65);
            this.GunComboBox.Name = "GunComboBox";
            this.GunComboBox.Size = new System.Drawing.Size(160, 24);
            this.GunComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haftanın Günleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gün:";
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(80, 105);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(160, 28);
            this.WriteButton.TabIndex = 3;
            this.WriteButton.Text = "Yazdır";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // GunLabel
            // 
            this.GunLabel.AutoSize = true;
            this.GunLabel.Location = new System.Drawing.Point(17, 168);
            this.GunLabel.Name = "GunLabel";
            this.GunLabel.Size = new System.Drawing.Size(103, 17);
            this.GunLabel.TabIndex = 4;
            this.GunLabel.Text = "Seçtiğiniz Gün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Karakterin İsmi Ne?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Karakter:";
            // 
            // KarakterComboBox
            // 
            this.KarakterComboBox.FormattingEnabled = true;
            this.KarakterComboBox.Items.AddRange(new object[] {
            "#",
            "$",
            "½",
            "&",
            "^",
            "?",
            "+",
            "-",
            "*",
            "/"});
            this.KarakterComboBox.Location = new System.Drawing.Point(93, 65);
            this.KarakterComboBox.Name = "KarakterComboBox";
            this.KarakterComboBox.Size = new System.Drawing.Size(160, 24);
            this.KarakterComboBox.TabIndex = 5;
            // 
            // WriteButton1
            // 
            this.WriteButton1.Location = new System.Drawing.Point(93, 105);
            this.WriteButton1.Name = "WriteButton1";
            this.WriteButton1.Size = new System.Drawing.Size(160, 28);
            this.WriteButton1.TabIndex = 5;
            this.WriteButton1.Text = "Yazdır";
            this.WriteButton1.UseVisualStyleBackColor = true;
            this.WriteButton1.Click += new System.EventHandler(this.WriteButton1_Click);
            // 
            // KarakterLabel
            // 
            this.KarakterLabel.AutoSize = true;
            this.KarakterLabel.Location = new System.Drawing.Point(14, 168);
            this.KarakterLabel.Name = "KarakterLabel";
            this.KarakterLabel.Size = new System.Drawing.Size(105, 17);
            this.KarakterLabel.TabIndex = 5;
            this.KarakterLabel.Text = "Karakterin İsmi:";
            // 
            // Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 258);
            this.Controls.Add(this.OdevGroupBox2);
            this.Controls.Add(this.OdevGroupBox1);
            this.Name = "Examples";
            this.Text = "Examples";
            this.OdevGroupBox1.ResumeLayout(false);
            this.OdevGroupBox1.PerformLayout();
            this.OdevGroupBox2.ResumeLayout(false);
            this.OdevGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OdevGroupBox1;
        private System.Windows.Forms.Label GunLabel;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GunComboBox;
        private System.Windows.Forms.GroupBox OdevGroupBox2;
        private System.Windows.Forms.Button WriteButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox KarakterComboBox;
        private System.Windows.Forms.Label KarakterLabel;
    }
}

