
namespace Array_Methods
{
    partial class ArrayMethods
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
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReverseListBox = new System.Windows.Forms.ListBox();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexOfLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LengthLabel);
            this.groupBox1.Controls.Add(this.LengthButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length Metodu";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(22, 83);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(146, 17);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Dizinin Eleman Sayısı:";
            // 
            // LengthButton
            // 
            this.LengthButton.Location = new System.Drawing.Point(49, 37);
            this.LengthButton.Name = "LengthButton";
            this.LengthButton.Size = new System.Drawing.Size(97, 32);
            this.LengthButton.TabIndex = 0;
            this.LengthButton.Text = "Göster";
            this.LengthButton.UseVisualStyleBackColor = true;
            this.LengthButton.Click += new System.EventHandler(this.LengthButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortListBox);
            this.groupBox2.Controls.Add(this.SortButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 251);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Metodu";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(49, 37);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(97, 32);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sırala";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.ShortButton_Click);
            // 
            // SortListBox
            // 
            this.SortListBox.FormattingEnabled = true;
            this.SortListBox.ItemHeight = 16;
            this.SortListBox.Location = new System.Drawing.Point(6, 75);
            this.SortListBox.Name = "SortListBox";
            this.SortListBox.Size = new System.Drawing.Size(188, 164);
            this.SortListBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinLabel);
            this.groupBox3.Controls.Add(this.MaxLabel);
            this.groupBox3.Controls.Add(this.IndexOfLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ReverseListBox);
            this.groupBox3.Controls.Add(this.ReverseButton);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 376);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reverse Metodu";
            // 
            // ReverseListBox
            // 
            this.ReverseListBox.FormattingEnabled = true;
            this.ReverseListBox.ItemHeight = 16;
            this.ReverseListBox.Location = new System.Drawing.Point(6, 75);
            this.ReverseListBox.Name = "ReverseListBox";
            this.ReverseListBox.Size = new System.Drawing.Size(188, 164);
            this.ReverseListBox.TabIndex = 2;
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(48, 34);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(111, 32);
            this.ReverseButton.TabIndex = 0;
            this.ReverseButton.Text = "Tersten Sırala";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aradığımız 58\'in index değeri\r\nolsun.(IndexOf komutu)\r\n";
            // 
            // IndexOfLabel
            // 
            this.IndexOfLabel.AutoSize = true;
            this.IndexOfLabel.Location = new System.Drawing.Point(6, 287);
            this.IndexOfLabel.Name = "IndexOfLabel";
            this.IndexOfLabel.Size = new System.Drawing.Size(169, 17);
            this.IndexOfLabel.TabIndex = 4;
            this.IndexOfLabel.Text = "58 Değerinin Index Sırası:";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(6, 316);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(80, 17);
            this.MaxLabel.TabIndex = 5;
            this.MaxLabel.Text = "Max Değer:";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(6, 347);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(77, 17);
            this.MinLabel.TabIndex = 6;
            this.MinLabel.Text = "Min Değer:";
            // 
            // ArrayMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArrayMethods";
            this.Text = "Dizi Metodları";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button LengthButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ListBox SortListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ReverseListBox;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Label IndexOfLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
    }
}

