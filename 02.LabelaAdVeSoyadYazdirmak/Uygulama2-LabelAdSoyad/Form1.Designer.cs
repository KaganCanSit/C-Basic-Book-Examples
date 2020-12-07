
namespace Uygulama2_LabelAdSoyad
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
            this.NameSurnameButton = new System.Windows.Forms.Button();
            this.CityLabel = new System.Windows.Forms.Label();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(63, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Ad:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(63, 75);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 17);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Soyad:";
            // 
            // NameSurnameButton
            // 
            this.NameSurnameButton.Location = new System.Drawing.Point(66, 220);
            this.NameSurnameButton.Name = "NameSurnameButton";
            this.NameSurnameButton.Size = new System.Drawing.Size(131, 49);
            this.NameSurnameButton.TabIndex = 2;
            this.NameSurnameButton.Text = "Tıklayınız";
            this.NameSurnameButton.UseVisualStyleBackColor = true;
            this.NameSurnameButton.Click += new System.EventHandler(this.NameSurnameButton_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(63, 113);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(45, 17);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "Şehir:";
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(63, 149);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(33, 17);
            this.DistrictLabel.TabIndex = 4;
            this.DistrictLabel.Text = "İlçe:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(63, 184);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(56, 17);
            this.JobLabel.TabIndex = 5;
            this.JobLabel.Text = "Meslek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 301);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.NameSurnameButton);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Button NameSurnameButton;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Label JobLabel;
    }
}

