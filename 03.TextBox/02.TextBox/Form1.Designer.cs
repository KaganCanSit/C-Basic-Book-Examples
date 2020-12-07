
namespace _02.TextBox
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
            this.TextPrintBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextPrintBox
            // 
            this.TextPrintBox.Location = new System.Drawing.Point(12, 12);
            this.TextPrintBox.Multiline = true;
            this.TextPrintBox.Name = "TextPrintBox";
            this.TextPrintBox.Size = new System.Drawing.Size(604, 121);
            this.TextPrintBox.TabIndex = 0;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(244, 153);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(150, 38);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Yazdır";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Location = new System.Drawing.Point(21, 224);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(38, 17);
            this.PrintLabel.TabIndex = 2;
            this.PrintLabel.Text = "Çıktı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 411);
            this.Controls.Add(this.PrintLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TextPrintBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextPrintBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label PrintLabel;
    }
}

