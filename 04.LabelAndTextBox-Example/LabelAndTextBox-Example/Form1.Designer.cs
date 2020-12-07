
namespace LabelAndTextBox_Example
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SaveNameLabel = new System.Windows.Forms.Label();
            this.SaveSurnameLabel = new System.Windows.Forms.Label();
            this.SaveAgeLabel = new System.Windows.Forms.Label();
            this.SaveClassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(43, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Ad:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(43, 112);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 17);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Soyad:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(43, 157);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(57, 17);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Yaşınız:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(43, 203);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(60, 17);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Sınıfınız:";
            // 
            // SaveBttn
            // 
            this.SaveBttn.Location = new System.Drawing.Point(107, 244);
            this.SaveBttn.Name = "SaveBttn";
            this.SaveBttn.Size = new System.Drawing.Size(141, 33);
            this.SaveBttn.TabIndex = 4;
            this.SaveBttn.Text = "Kaydet";
            this.SaveBttn.UseVisualStyleBackColor = true;
            this.SaveBttn.Click += new System.EventHandler(this.SaveBttn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(107, 65);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(141, 22);
            this.NameBox.TabIndex = 5;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(107, 107);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(141, 22);
            this.SurnameBox.TabIndex = 6;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(107, 154);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(141, 22);
            this.AgeBox.TabIndex = 7;
            // 
            // ClassBox
            // 
            this.ClassBox.Location = new System.Drawing.Point(107, 198);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(141, 22);
            this.ClassBox.TabIndex = 8;
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(333, 36);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(77, 17);
            this.InformationLabel.TabIndex = 9;
            this.InformationLabel.Text = "Bilgi Paneli";
            // 
            // SaveNameLabel
            // 
            this.SaveNameLabel.AutoSize = true;
            this.SaveNameLabel.Location = new System.Drawing.Point(333, 63);
            this.SaveNameLabel.Name = "SaveNameLabel";
            this.SaveNameLabel.Size = new System.Drawing.Size(31, 17);
            this.SaveNameLabel.TabIndex = 10;
            this.SaveNameLabel.Text = "AD:";
            // 
            // SaveSurnameLabel
            // 
            this.SaveSurnameLabel.AutoSize = true;
            this.SaveSurnameLabel.Location = new System.Drawing.Point(333, 105);
            this.SaveSurnameLabel.Name = "SaveSurnameLabel";
            this.SaveSurnameLabel.Size = new System.Drawing.Size(60, 17);
            this.SaveSurnameLabel.TabIndex = 11;
            this.SaveSurnameLabel.Text = "SOYAD:";
            // 
            // SaveAgeLabel
            // 
            this.SaveAgeLabel.AutoSize = true;
            this.SaveAgeLabel.Location = new System.Drawing.Point(333, 150);
            this.SaveAgeLabel.Name = "SaveAgeLabel";
            this.SaveAgeLabel.Size = new System.Drawing.Size(64, 17);
            this.SaveAgeLabel.TabIndex = 12;
            this.SaveAgeLabel.Text = "YAŞINIZ:";
            // 
            // SaveClassLabel
            // 
            this.SaveClassLabel.AutoSize = true;
            this.SaveClassLabel.Location = new System.Drawing.Point(333, 196);
            this.SaveClassLabel.Name = "SaveClassLabel";
            this.SaveClassLabel.Size = new System.Drawing.Size(70, 17);
            this.SaveClassLabel.TabIndex = 13;
            this.SaveClassLabel.Text = "SINIFINIZ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 335);
            this.Controls.Add(this.SaveClassLabel);
            this.Controls.Add(this.SaveAgeLabel);
            this.Controls.Add(this.SaveSurnameLabel);
            this.Controls.Add(this.SaveNameLabel);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SaveBttn);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Ad Soyad Yazdırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button SaveBttn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox ClassBox;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label SaveNameLabel;
        private System.Windows.Forms.Label SaveSurnameLabel;
        private System.Windows.Forms.Label SaveAgeLabel;
        private System.Windows.Forms.Label SaveClassLabel;
    }
}

