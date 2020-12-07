
namespace GroupBox
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
            this.PersonGroupBox = new System.Windows.Forms.GroupBox();
            this.ContactGruopBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TCLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.TCNoMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.DateMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.PersonGroupBox.SuspendLayout();
            this.ContactGruopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonGroupBox
            // 
            this.PersonGroupBox.BackColor = System.Drawing.Color.LightCyan;
            this.PersonGroupBox.Controls.Add(this.PhoneMaskedBox);
            this.PersonGroupBox.Controls.Add(this.TCNoMaskedBox);
            this.PersonGroupBox.Controls.Add(this.AgeTextBox);
            this.PersonGroupBox.Controls.Add(this.NameTextBox);
            this.PersonGroupBox.Controls.Add(this.AgeLabel);
            this.PersonGroupBox.Controls.Add(this.PhoneLabel);
            this.PersonGroupBox.Controls.Add(this.TCLabel);
            this.PersonGroupBox.Controls.Add(this.NameLabel);
            this.PersonGroupBox.Location = new System.Drawing.Point(22, 64);
            this.PersonGroupBox.Name = "PersonGroupBox";
            this.PersonGroupBox.Size = new System.Drawing.Size(291, 314);
            this.PersonGroupBox.TabIndex = 0;
            this.PersonGroupBox.TabStop = false;
            this.PersonGroupBox.Text = "Kişisel Bilgiler";
            // 
            // ContactGruopBox
            // 
            this.ContactGruopBox.BackColor = System.Drawing.Color.LightCyan;
            this.ContactGruopBox.Controls.Add(this.DateMaskedBox);
            this.ContactGruopBox.Controls.Add(this.CityComboBox);
            this.ContactGruopBox.Controls.Add(this.JobTextBox);
            this.ContactGruopBox.Controls.Add(this.DateLabel);
            this.ContactGruopBox.Controls.Add(this.CityLabel);
            this.ContactGruopBox.Controls.Add(this.JobLabel);
            this.ContactGruopBox.Location = new System.Drawing.Point(331, 64);
            this.ContactGruopBox.Name = "ContactGruopBox";
            this.ContactGruopBox.Size = new System.Drawing.Size(324, 314);
            this.ContactGruopBox.TabIndex = 1;
            this.ContactGruopBox.TabStop = false;
            this.ContactGruopBox.Text = "İletişim Adresleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Bilgileri";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Ad Soyad";
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Location = new System.Drawing.Point(6, 106);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(60, 17);
            this.TCLabel.TabIndex = 1;
            this.TCLabel.Text = "T.C. No:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 139);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(60, 17);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Telefon:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 174);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 17);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Yaş:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(16, 154);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 17);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Doğum Tarihi:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(16, 119);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(56, 17);
            this.JobLabel.TabIndex = 5;
            this.JobLabel.Text = "Meslek:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(16, 86);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(45, 17);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "Şehir:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(82, 67);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(170, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(82, 171);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(170, 22);
            this.AgeTextBox.TabIndex = 5;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Location = new System.Drawing.Point(117, 116);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.Size = new System.Drawing.Size(170, 22);
            this.JobTextBox.TabIndex = 6;
            // 
            // TCNoMaskedBox
            // 
            this.TCNoMaskedBox.Location = new System.Drawing.Point(82, 100);
            this.TCNoMaskedBox.Mask = "00000000000";
            this.TCNoMaskedBox.Name = "TCNoMaskedBox";
            this.TCNoMaskedBox.Size = new System.Drawing.Size(170, 22);
            this.TCNoMaskedBox.TabIndex = 6;
            // 
            // PhoneMaskedBox
            // 
            this.PhoneMaskedBox.Location = new System.Drawing.Point(82, 136);
            this.PhoneMaskedBox.Mask = "(999) 000-0000";
            this.PhoneMaskedBox.Name = "PhoneMaskedBox";
            this.PhoneMaskedBox.Size = new System.Drawing.Size(170, 22);
            this.PhoneMaskedBox.TabIndex = 7;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "İstanbul",
            "İzmir",
            "Manisa",
            "Çanakkale",
            "Antalya",
            "Van",
            "Kars",
            "Trabzon",
            "Malatya",
            "Bilecik"});
            this.CityComboBox.Location = new System.Drawing.Point(117, 86);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(170, 24);
            this.CityComboBox.TabIndex = 7;
            // 
            // DateMaskedBox
            // 
            this.DateMaskedBox.Location = new System.Drawing.Point(117, 151);
            this.DateMaskedBox.Mask = "00/00/0000";
            this.DateMaskedBox.Name = "DateMaskedBox";
            this.DateMaskedBox.Size = new System.Drawing.Size(170, 22);
            this.DateMaskedBox.TabIndex = 8;
            this.DateMaskedBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(511, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 38);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(683, 70);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(496, 308);
            this.ListBox.TabIndex = 10;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactGruopBox);
            this.Controls.Add(this.PersonGroupBox);
            this.Name = "Form1";
            this.Text = "Kullanıcı Paneli";
            this.PersonGroupBox.ResumeLayout(false);
            this.PersonGroupBox.PerformLayout();
            this.ContactGruopBox.ResumeLayout(false);
            this.ContactGruopBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonGroupBox;
        private System.Windows.Forms.GroupBox ContactGruopBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedBox;
        private System.Windows.Forms.MaskedTextBox TCNoMaskedBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label TCLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MaskedTextBox DateMaskedBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ListBox;
    }
}

