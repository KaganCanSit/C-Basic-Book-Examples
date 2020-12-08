
namespace OperatorExamples
{
    partial class Operators
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
            this.ValueTextBox1 = new System.Windows.Forms.TextBox();
            this.ValueTextBox2 = new System.Windows.Forms.TextBox();
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ValueTextBox1
            // 
            this.ValueTextBox1.Location = new System.Drawing.Point(146, 28);
            this.ValueTextBox1.Name = "ValueTextBox1";
            this.ValueTextBox1.Size = new System.Drawing.Size(177, 22);
            this.ValueTextBox1.TabIndex = 0;
            // 
            // ValueTextBox2
            // 
            this.ValueTextBox2.Location = new System.Drawing.Point(146, 66);
            this.ValueTextBox2.Name = "ValueTextBox2";
            this.ValueTextBox2.Size = new System.Drawing.Size(177, 22);
            this.ValueTextBox2.TabIndex = 1;
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(46, 31);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(97, 17);
            this.Value1.TabIndex = 2;
            this.Value1.Text = "1.Sayı Değeri:";
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(46, 71);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(97, 17);
            this.Value2.TabIndex = 3;
            this.Value2.Text = "2.Sayı Değeri:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(170, 105);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(126, 27);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Hesapla";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 16;
            this.ValueListBox.Location = new System.Drawing.Point(12, 154);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(380, 276);
            this.ValueListBox.TabIndex = 5;
            // 
            // Operators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.ValueListBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.ValueTextBox2);
            this.Controls.Add(this.ValueTextBox1);
            this.Name = "Operators";
            this.Text = "Operatörler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueTextBox1;
        private System.Windows.Forms.TextBox ValueTextBox2;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox ValueListBox;
    }
}

