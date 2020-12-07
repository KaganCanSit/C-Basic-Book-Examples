
namespace ComboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddBttn = new System.Windows.Forms.Button();
            this.AddCityBttn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Bursa",
            "İzmir",
            "Gaziantep",
            "Balıkesir",
            "Şanlıurfa",
            "Elazığ"});
            this.comboBox1.Location = new System.Drawing.Point(77, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // AddBttn
            // 
            this.AddBttn.Location = new System.Drawing.Point(140, 170);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(137, 40);
            this.AddBttn.TabIndex = 1;
            this.AddBttn.Text = "Ekle";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // AddCityBttn
            // 
            this.AddCityBttn.Location = new System.Drawing.Point(77, 125);
            this.AddCityBttn.Name = "AddCityBttn";
            this.AddCityBttn.Size = new System.Drawing.Size(255, 22);
            this.AddCityBttn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eklemek İstediğiniz Şehrin Adını Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCityBttn);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Şehir Liste Düzenleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.TextBox AddCityBttn;
        private System.Windows.Forms.Label label1;
    }
}

