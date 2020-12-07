
namespace MaskedTextBox
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
            this.maskedPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.maskedDateBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintPhoneLabel = new System.Windows.Forms.Label();
            this.PrintDateLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedPhoneBox
            // 
            this.maskedPhoneBox.Location = new System.Drawing.Point(173, 88);
            this.maskedPhoneBox.Mask = "000-0000";
            this.maskedPhoneBox.Name = "maskedPhoneBox";
            this.maskedPhoneBox.Size = new System.Drawing.Size(195, 22);
            this.maskedPhoneBox.TabIndex = 0;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(53, 91);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(56, 17);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "Telefon";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(53, 135);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(41, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Tarih";
            // 
            // maskedDateBox
            // 
            this.maskedDateBox.Location = new System.Drawing.Point(173, 132);
            this.maskedDateBox.Mask = "00/00/0000";
            this.maskedDateBox.Name = "maskedDateBox";
            this.maskedDateBox.Size = new System.Drawing.Size(195, 22);
            this.maskedDateBox.TabIndex = 3;
            this.maskedDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Değerler:";
            // 
            // PrintPhoneLabel
            // 
            this.PrintPhoneLabel.AutoSize = true;
            this.PrintPhoneLabel.Location = new System.Drawing.Point(53, 298);
            this.PrintPhoneLabel.Name = "PrintPhoneLabel";
            this.PrintPhoneLabel.Size = new System.Drawing.Size(60, 17);
            this.PrintPhoneLabel.TabIndex = 5;
            this.PrintPhoneLabel.Text = "Telefon:";
            // 
            // PrintDateLabel
            // 
            this.PrintDateLabel.AutoSize = true;
            this.PrintDateLabel.Location = new System.Drawing.Point(53, 333);
            this.PrintDateLabel.Name = "PrintDateLabel";
            this.PrintDateLabel.Size = new System.Drawing.Size(41, 17);
            this.PrintDateLabel.TabIndex = 6;
            this.PrintDateLabel.Text = "Tarih";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(173, 178);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(195, 32);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Location = new System.Drawing.Point(53, 51);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(199, 17);
            this.HeadLabel.TabIndex = 8;
            this.HeadLabel.Text = "Sisteme Telefon Ve Tarih Ekle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrintDateLabel);
            this.Controls.Add(this.PrintPhoneLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedDateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.maskedPhoneBox);
            this.Name = "Form1";
            this.Text = "Telefon Ve Tarih";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedPhoneBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.MaskedTextBox maskedDateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PrintPhoneLabel;
        private System.Windows.Forms.Label PrintDateLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HeadLabel;
    }
}

