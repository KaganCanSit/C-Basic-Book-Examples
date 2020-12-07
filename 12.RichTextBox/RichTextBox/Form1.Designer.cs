
namespace RichTextBox
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(157, 134);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(112, 42);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Göster";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(36, 32);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(370, 96);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 195);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.ShowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}

