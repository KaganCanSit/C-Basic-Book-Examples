
namespace Byte_Sbyte
{
    partial class Byte_Sbyte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ByteLabel = new System.Windows.Forms.Label();
            this.GetByteButton = new System.Windows.Forms.Button();
            this.SbyteGroupBox = new System.Windows.Forms.GroupBox();
            this.SbyteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SbyteTextBox = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SbyteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GetByteButton);
            this.groupBox1.Controls.Add(this.ByteLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uygulama23";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Byte değişkeni 0-256 arasındaki değerleri kapsar.\r\n(256 değeri dahil değildir!)";
            // 
            // ByteLabel
            // 
            this.ByteLabel.AutoSize = true;
            this.ByteLabel.Location = new System.Drawing.Point(6, 92);
            this.ByteLabel.Name = "ByteLabel";
            this.ByteLabel.Size = new System.Drawing.Size(129, 17);
            this.ByteLabel.TabIndex = 1;
            this.ByteLabel.Text = "Örnek Byte Değeri:";
            // 
            // GetByteButton
            // 
            this.GetByteButton.Location = new System.Drawing.Point(96, 126);
            this.GetByteButton.Name = "GetByteButton";
            this.GetByteButton.Size = new System.Drawing.Size(103, 33);
            this.GetByteButton.TabIndex = 2;
            this.GetByteButton.Text = "Değer Al";
            this.GetByteButton.UseVisualStyleBackColor = true;
            this.GetByteButton.Click += new System.EventHandler(this.GetByteButton_Click);
            // 
            // SbyteGroupBox
            // 
            this.SbyteGroupBox.Controls.Add(this.Value);
            this.SbyteGroupBox.Controls.Add(this.SbyteTextBox);
            this.SbyteGroupBox.Controls.Add(this.SbyteButton);
            this.SbyteGroupBox.Controls.Add(this.label2);
            this.SbyteGroupBox.Controls.Add(this.label3);
            this.SbyteGroupBox.Location = new System.Drawing.Point(12, 194);
            this.SbyteGroupBox.Name = "SbyteGroupBox";
            this.SbyteGroupBox.Size = new System.Drawing.Size(333, 197);
            this.SbyteGroupBox.TabIndex = 3;
            this.SbyteGroupBox.TabStop = false;
            this.SbyteGroupBox.Text = "Uygulama24";
            // 
            // SbyteButton
            // 
            this.SbyteButton.Location = new System.Drawing.Point(85, 120);
            this.SbyteButton.Name = "SbyteButton";
            this.SbyteButton.Size = new System.Drawing.Size(136, 33);
            this.SbyteButton.TabIndex = 2;
            this.SbyteButton.Text = "Değer Al";
            this.SbyteButton.UseVisualStyleBackColor = true;
            this.SbyteButton.Click += new System.EventHandler(this.SbyteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sbyte Değeri Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sbyte değişkeni -128 - +127 arasındaki değerleri\r\nkapsar.(Byte değişkeninin işare" +
    "tlenmiş halidir!)";
            // 
            // SbyteTextBox
            // 
            this.SbyteTextBox.Location = new System.Drawing.Point(150, 82);
            this.SbyteTextBox.Name = "SbyteTextBox";
            this.SbyteTextBox.Size = new System.Drawing.Size(171, 22);
            this.SbyteTextBox.TabIndex = 3;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(143, 166);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(20, 17);
            this.Value.TabIndex = 4;
            this.Value.Text = "...";
            // 
            // Byte_Sbyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 412);
            this.Controls.Add(this.SbyteGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Byte_Sbyte";
            this.Text = "Byte-Sbyte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SbyteGroupBox.ResumeLayout(false);
            this.SbyteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetByteButton;
        private System.Windows.Forms.Label ByteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SbyteGroupBox;
        private System.Windows.Forms.TextBox SbyteTextBox;
        private System.Windows.Forms.Button SbyteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Value;
    }
}

