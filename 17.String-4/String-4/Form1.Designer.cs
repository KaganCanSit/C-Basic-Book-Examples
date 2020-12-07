
namespace String_4
{
    partial class ComputerComponent
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ComponentTextBox = new System.Windows.Forms.TextBox();
            this.ComponentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(126, 117);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(221, 24);
            this.ComboBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(160, 168);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 32);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Listeye Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ComponentTextBox
            // 
            this.ComponentTextBox.Location = new System.Drawing.Point(126, 71);
            this.ComponentTextBox.Name = "ComponentTextBox";
            this.ComponentTextBox.Size = new System.Drawing.Size(221, 22);
            this.ComponentTextBox.TabIndex = 3;
            // 
            // ComponentLabel
            // 
            this.ComponentLabel.AutoSize = true;
            this.ComponentLabel.Location = new System.Drawing.Point(47, 74);
            this.ComponentLabel.Name = "ComponentLabel";
            this.ComponentLabel.Size = new System.Drawing.Size(73, 17);
            this.ComponentLabel.TabIndex = 2;
            this.ComponentLabel.Text = "Parça Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilgisayar Parçaları Ekleyiniz";
            // 
            // ComputerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComponentTextBox);
            this.Controls.Add(this.ComponentLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ComboBox);
            this.Name = "ComputerComponent";
            this.Text = "Bilgisayar Bileşenlerini Not Al";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ComponentTextBox;
        private System.Windows.Forms.Label ComponentLabel;
        private System.Windows.Forms.Label label1;
    }
}

