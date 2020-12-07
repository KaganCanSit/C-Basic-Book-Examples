
namespace Integer
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
            this.WriteButton = new System.Windows.Forms.Button();
            this.CodeIntLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CupeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(188, 424);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(146, 38);
            this.WriteButton.TabIndex = 0;
            this.WriteButton.Text = "Yazdır";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // CodeIntLabel
            // 
            this.CodeIntLabel.AutoSize = true;
            this.CodeIntLabel.Location = new System.Drawing.Point(21, 61);
            this.CodeIntLabel.Name = "CodeIntLabel";
            this.CodeIntLabel.Size = new System.Drawing.Size(313, 17);
            this.CodeIntLabel.TabIndex = 1;
            this.CodeIntLabel.Text = "Kod kısmından girilen bir sayıyı label\'a yazdırınız:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(340, 61);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(144, 34);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Sayiyi Yazdıracağımız\r\nKısım\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kod kısmından girilen iki sayıyı toplayarak\r\nlabel\'a yazdırınız:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(340, 131);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(157, 34);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Toplamı Yazdıracağımız\r\nKısım\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kod kısmında değer vererek karenin \r\nalan ve çevresni hesaplayarak yazdırınız:";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(340, 203);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(53, 51);
            this.SquareLabel.TabIndex = 6;
            this.SquareLabel.Text = "Kare: \r\nAlan= \r\nÇevre=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kod kısmından iki sınav notu girilen öğrencinin\r\nnot ort. hesaplayan programı kod" +
    "layınız.";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(340, 289);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(66, 17);
            this.AverageLabel.TabIndex = 8;
            this.AverageLabel.Text = "Ortalama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kod kısmından girilen sayının kübünü alan \r\nprogramı kodlayınız";
            // 
            // CupeLabel
            // 
            this.CupeLabel.AutoSize = true;
            this.CupeLabel.Location = new System.Drawing.Point(340, 353);
            this.CupeLabel.Name = "CupeLabel";
            this.CupeLabel.Size = new System.Drawing.Size(52, 17);
            this.CupeLabel.TabIndex = 10;
            this.CupeLabel.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 486);
            this.Controls.Add(this.CupeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.CodeIntLabel);
            this.Controls.Add(this.WriteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Label CodeIntLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CupeLabel;
    }
}

