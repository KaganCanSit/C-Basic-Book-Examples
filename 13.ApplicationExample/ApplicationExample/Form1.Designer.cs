
namespace ApplicationExample
{
    partial class TravelCompanyForm
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
            this.PrintAllListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.TCNoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PassengerGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.TCNoMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TripGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.DateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.WhereBox = new System.Windows.Forms.ComboBox();
            this.WhereFromComboBox = new System.Windows.Forms.ComboBox();
            this.Jupiter = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PassengerGroupBox.SuspendLayout();
            this.TripGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintAllListBox
            // 
            this.PrintAllListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrintAllListBox.FormattingEnabled = true;
            this.PrintAllListBox.HorizontalScrollbar = true;
            this.PrintAllListBox.ItemHeight = 16;
            this.PrintAllListBox.Location = new System.Drawing.Point(346, 266);
            this.PrintAllListBox.Name = "PrintAllListBox";
            this.PrintAllListBox.Size = new System.Drawing.Size(442, 176);
            this.PrintAllListBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Ad-Soyad:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 111);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(60, 17);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Telefon:";
            // 
            // TCNoLabel
            // 
            this.TCNoLabel.AutoSize = true;
            this.TCNoLabel.Location = new System.Drawing.Point(6, 79);
            this.TCNoLabel.Name = "TCNoLabel";
            this.TCNoLabel.Size = new System.Drawing.Size(52, 17);
            this.TCNoLabel.TabIndex = 2;
            this.TCNoLabel.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nereden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nereye:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat:";
            // 
            // PassengerGroupBox
            // 
            this.PassengerGroupBox.Controls.Add(this.PhoneMaskedBox);
            this.PassengerGroupBox.Controls.Add(this.TCNoMaskedBox);
            this.PassengerGroupBox.Controls.Add(this.NameBox);
            this.PassengerGroupBox.Controls.Add(this.NameLabel);
            this.PassengerGroupBox.Controls.Add(this.TCNoLabel);
            this.PassengerGroupBox.Controls.Add(this.PhoneLabel);
            this.PassengerGroupBox.Location = new System.Drawing.Point(28, 27);
            this.PassengerGroupBox.Name = "PassengerGroupBox";
            this.PassengerGroupBox.Size = new System.Drawing.Size(296, 161);
            this.PassengerGroupBox.TabIndex = 8;
            this.PassengerGroupBox.TabStop = false;
            this.PassengerGroupBox.Text = "Yolcu Bilgileri";
            // 
            // PhoneMaskedBox
            // 
            this.PhoneMaskedBox.Location = new System.Drawing.Point(106, 106);
            this.PhoneMaskedBox.Mask = "(999) 000-0000";
            this.PhoneMaskedBox.Name = "PhoneMaskedBox";
            this.PhoneMaskedBox.Size = new System.Drawing.Size(184, 22);
            this.PhoneMaskedBox.TabIndex = 5;
            // 
            // TCNoMaskedBox
            // 
            this.TCNoMaskedBox.Location = new System.Drawing.Point(106, 73);
            this.TCNoMaskedBox.Mask = "00000000000";
            this.TCNoMaskedBox.Name = "TCNoMaskedBox";
            this.TCNoMaskedBox.Size = new System.Drawing.Size(184, 22);
            this.TCNoMaskedBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(106, 37);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 22);
            this.NameBox.TabIndex = 3;
            // 
            // TripGroupBox
            // 
            this.TripGroupBox.Controls.Add(this.TimeMaskedBox);
            this.TripGroupBox.Controls.Add(this.DateMaskedTextBox);
            this.TripGroupBox.Controls.Add(this.WhereBox);
            this.TripGroupBox.Controls.Add(this.WhereFromComboBox);
            this.TripGroupBox.Controls.Add(this.label4);
            this.TripGroupBox.Controls.Add(this.label5);
            this.TripGroupBox.Controls.Add(this.label6);
            this.TripGroupBox.Controls.Add(this.label7);
            this.TripGroupBox.Location = new System.Drawing.Point(28, 259);
            this.TripGroupBox.Name = "TripGroupBox";
            this.TripGroupBox.Size = new System.Drawing.Size(296, 187);
            this.TripGroupBox.TabIndex = 9;
            this.TripGroupBox.TabStop = false;
            this.TripGroupBox.Text = "Yolculuk Bilgileri";
            // 
            // TimeMaskedBox
            // 
            this.TimeMaskedBox.Location = new System.Drawing.Point(106, 143);
            this.TimeMaskedBox.Mask = "00:00";
            this.TimeMaskedBox.Name = "TimeMaskedBox";
            this.TimeMaskedBox.Size = new System.Drawing.Size(184, 22);
            this.TimeMaskedBox.TabIndex = 9;
            this.TimeMaskedBox.ValidatingType = typeof(System.DateTime);
            // 
            // DateMaskedTextBox
            // 
            this.DateMaskedTextBox.Location = new System.Drawing.Point(106, 110);
            this.DateMaskedTextBox.Mask = "00/00/0000";
            this.DateMaskedTextBox.Name = "DateMaskedTextBox";
            this.DateMaskedTextBox.Size = new System.Drawing.Size(184, 22);
            this.DateMaskedTextBox.TabIndex = 6;
            this.DateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // WhereBox
            // 
            this.WhereBox.FormattingEnabled = true;
            this.WhereBox.Items.AddRange(new object[] {
            "Elazığ",
            "Malatya",
            "Gaziantep"});
            this.WhereBox.Location = new System.Drawing.Point(106, 70);
            this.WhereBox.Name = "WhereBox";
            this.WhereBox.Size = new System.Drawing.Size(184, 24);
            this.WhereBox.TabIndex = 8;
            // 
            // WhereFromComboBox
            // 
            this.WhereFromComboBox.FormattingEnabled = true;
            this.WhereFromComboBox.Items.AddRange(new object[] {
            "Elazığ",
            "Malatya",
            "Gaziantep"});
            this.WhereFromComboBox.Location = new System.Drawing.Point(106, 31);
            this.WhereFromComboBox.Name = "WhereFromComboBox";
            this.WhereFromComboBox.Size = new System.Drawing.Size(184, 24);
            this.WhereFromComboBox.TabIndex = 7;
            // 
            // Jupiter
            // 
            this.Jupiter.AutoSize = true;
            this.Jupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Jupiter.Location = new System.Drawing.Point(372, 82);
            this.Jupiter.Name = "Jupiter";
            this.Jupiter.Size = new System.Drawing.Size(372, 46);
            this.Jupiter.TabIndex = 10;
            this.Jupiter.Text = "JÜPİTER FİRMASI";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(134, 466);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(184, 36);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Yolculuğu Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TravelCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Jupiter);
            this.Controls.Add(this.TripGroupBox);
            this.Controls.Add(this.PassengerGroupBox);
            this.Controls.Add(this.PrintAllListBox);
            this.Name = "TravelCompanyForm";
            this.Text = "Jüpiter Firmasına Hoşgeldiniz.";
            this.PassengerGroupBox.ResumeLayout(false);
            this.PassengerGroupBox.PerformLayout();
            this.TripGroupBox.ResumeLayout(false);
            this.TripGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PrintAllListBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label TCNoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox PassengerGroupBox;
        private System.Windows.Forms.GroupBox TripGroupBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedBox;
        private System.Windows.Forms.MaskedTextBox TCNoMaskedBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.MaskedTextBox TimeMaskedBox;
        private System.Windows.Forms.MaskedTextBox DateMaskedTextBox;
        private System.Windows.Forms.ComboBox WhereBox;
        private System.Windows.Forms.ComboBox WhereFromComboBox;
        private System.Windows.Forms.Label Jupiter;
        private System.Windows.Forms.Button AddButton;
    }
}

