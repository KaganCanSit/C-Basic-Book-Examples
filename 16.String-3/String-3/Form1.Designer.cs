
namespace String_3
{
    partial class AddBook
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
            this.AddButton = new System.Windows.Forms.Button();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.WriterTextBox = new System.Windows.Forms.TextBox();
            this.WriteListBox = new System.Windows.Forms.ListBox();
            this.BookName = new System.Windows.Forms.Label();
            this.WriterLabel = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(114, 177);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(176, 33);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(114, 94);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.BookNameTextBox.TabIndex = 1;
            // 
            // WriterTextBox
            // 
            this.WriterTextBox.Location = new System.Drawing.Point(114, 138);
            this.WriterTextBox.Name = "WriterTextBox";
            this.WriterTextBox.Size = new System.Drawing.Size(176, 22);
            this.WriterTextBox.TabIndex = 2;
            // 
            // WriteListBox
            // 
            this.WriteListBox.FormattingEnabled = true;
            this.WriteListBox.ItemHeight = 16;
            this.WriteListBox.Location = new System.Drawing.Point(309, 32);
            this.WriteListBox.Name = "WriteListBox";
            this.WriteListBox.Size = new System.Drawing.Size(210, 196);
            this.WriteListBox.TabIndex = 3;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(20, 99);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(68, 17);
            this.BookName.TabIndex = 4;
            this.BookName.Text = "Kitap Adı:";
            // 
            // WriterLabel
            // 
            this.WriterLabel.AutoSize = true;
            this.WriterLabel.Location = new System.Drawing.Point(20, 141);
            this.WriterLabel.Name = "WriterLabel";
            this.WriterLabel.Size = new System.Drawing.Size(88, 17);
            this.WriterLabel.TabIndex = 5;
            this.WriterLabel.Text = "Kitap Yazarı:";
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeadLabel.Location = new System.Drawing.Point(70, 44);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(137, 25);
            this.HeadLabel.TabIndex = 6;
            this.HeadLabel.Text = "KİTAP EKLE";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 264);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.WriterLabel);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.WriteListBox);
            this.Controls.Add(this.WriterTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.AddButton);
            this.Name = "AddBook";
            this.Text = "Kitap Ekleme Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox WriterTextBox;
        private System.Windows.Forms.ListBox WriteListBox;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label WriterLabel;
        private System.Windows.Forms.Label HeadLabel;
    }
}

