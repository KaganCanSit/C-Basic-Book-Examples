
namespace SimpleVariableExamples
{
    partial class Veriables
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
            this.ShortTotalLabel = new System.Windows.Forms.Label();
            this.ShortTotalButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UShortLabel = new System.Windows.Forms.Label();
            this.UShortButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FloatLabel = new System.Windows.Forms.Label();
            this.FloatButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DecimalLabel = new System.Windows.Forms.Label();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BoolLabel = new System.Windows.Forms.Label();
            this.BollButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BoolNumLabel = new System.Windows.Forms.Label();
            this.BoolNumButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShortTotalLabel);
            this.groupBox1.Controls.Add(this.ShortTotalButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ShortExample";
            // 
            // ShortTotalLabel
            // 
            this.ShortTotalLabel.AutoSize = true;
            this.ShortTotalLabel.Location = new System.Drawing.Point(29, 79);
            this.ShortTotalLabel.Name = "ShortTotalLabel";
            this.ShortTotalLabel.Size = new System.Drawing.Size(97, 17);
            this.ShortTotalLabel.TabIndex = 1;
            this.ShortTotalLabel.Text = "Short Toplam:";
            // 
            // ShortTotalButton
            // 
            this.ShortTotalButton.Location = new System.Drawing.Point(32, 31);
            this.ShortTotalButton.Name = "ShortTotalButton";
            this.ShortTotalButton.Size = new System.Drawing.Size(193, 36);
            this.ShortTotalButton.TabIndex = 0;
            this.ShortTotalButton.Text = "Toplam(Short Değeri İçin)";
            this.ShortTotalButton.UseVisualStyleBackColor = true;
            this.ShortTotalButton.Click += new System.EventHandler(this.ShortTotalButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UShortLabel);
            this.groupBox2.Controls.Add(this.UShortButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UShortExample";
            // 
            // UShortLabel
            // 
            this.UShortLabel.AutoSize = true;
            this.UShortLabel.Location = new System.Drawing.Point(29, 84);
            this.UShortLabel.Name = "UShortLabel";
            this.UShortLabel.Size = new System.Drawing.Size(133, 17);
            this.UShortLabel.TabIndex = 1;
            this.UShortLabel.Text = "UShort Sayı Değeri:";
            // 
            // UShortButton
            // 
            this.UShortButton.Location = new System.Drawing.Point(32, 32);
            this.UShortButton.Name = "UShortButton";
            this.UShortButton.Size = new System.Drawing.Size(193, 36);
            this.UShortButton.TabIndex = 0;
            this.UShortButton.Text = "UShort Değer Al";
            this.UShortButton.UseVisualStyleBackColor = true;
            this.UShortButton.Click += new System.EventHandler(this.UShortButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FloatLabel);
            this.groupBox3.Controls.Add(this.FloatButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 114);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FloatExample";
            // 
            // FloatLabel
            // 
            this.FloatLabel.AutoSize = true;
            this.FloatLabel.Location = new System.Drawing.Point(29, 80);
            this.FloatLabel.Name = "FloatLabel";
            this.FloatLabel.Size = new System.Drawing.Size(120, 17);
            this.FloatLabel.TabIndex = 1;
            this.FloatLabel.Text = "Float Sayı Değeri:";
            // 
            // FloatButton
            // 
            this.FloatButton.Location = new System.Drawing.Point(32, 32);
            this.FloatButton.Name = "FloatButton";
            this.FloatButton.Size = new System.Drawing.Size(193, 36);
            this.FloatButton.TabIndex = 0;
            this.FloatButton.Text = "Float Değer Al";
            this.FloatButton.UseVisualStyleBackColor = true;
            this.FloatButton.Click += new System.EventHandler(this.FloatButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DecimalLabel);
            this.groupBox4.Controls.Add(this.DecimalButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 369);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 138);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DecimalExample";
            // 
            // DecimalLabel
            // 
            this.DecimalLabel.AutoSize = true;
            this.DecimalLabel.Location = new System.Drawing.Point(29, 82);
            this.DecimalLabel.Name = "DecimalLabel";
            this.DecimalLabel.Size = new System.Drawing.Size(139, 17);
            this.DecimalLabel.TabIndex = 1;
            this.DecimalLabel.Text = "Decimal Sayı Değeri:";
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(32, 32);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(193, 36);
            this.DecimalButton.TabIndex = 0;
            this.DecimalButton.Text = "Deciamal Değer Al";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BoolLabel);
            this.groupBox5.Controls.Add(this.BollButton);
            this.groupBox5.Location = new System.Drawing.Point(289, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 114);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BoolExample";
            // 
            // BoolLabel
            // 
            this.BoolLabel.AutoSize = true;
            this.BoolLabel.Location = new System.Drawing.Point(29, 79);
            this.BoolLabel.Name = "BoolLabel";
            this.BoolLabel.Size = new System.Drawing.Size(86, 17);
            this.BoolLabel.TabIndex = 1;
            this.BoolLabel.Text = "Bool Değeri:";
            // 
            // BollButton
            // 
            this.BollButton.Location = new System.Drawing.Point(32, 31);
            this.BollButton.Name = "BollButton";
            this.BollButton.Size = new System.Drawing.Size(193, 36);
            this.BollButton.TabIndex = 0;
            this.BollButton.Text = "Bool Değer Al";
            this.BollButton.UseVisualStyleBackColor = true;
            this.BollButton.Click += new System.EventHandler(this.BollButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BoolNumLabel);
            this.groupBox6.Controls.Add(this.BoolNumButton);
            this.groupBox6.Location = new System.Drawing.Point(289, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(271, 114);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BoolExample";
            // 
            // BoolNumLabel
            // 
            this.BoolNumLabel.AutoSize = true;
            this.BoolNumLabel.Location = new System.Drawing.Point(29, 79);
            this.BoolNumLabel.Name = "BoolNumLabel";
            this.BoolNumLabel.Size = new System.Drawing.Size(86, 17);
            this.BoolNumLabel.TabIndex = 1;
            this.BoolNumLabel.Text = "Bool Değeri:";
            // 
            // BoolNumButton
            // 
            this.BoolNumButton.Location = new System.Drawing.Point(32, 31);
            this.BoolNumButton.Name = "BoolNumButton";
            this.BoolNumButton.Size = new System.Drawing.Size(193, 36);
            this.BoolNumButton.TabIndex = 0;
            this.BoolNumButton.Text = "Bool Kontrol Et";
            this.BoolNumButton.UseVisualStyleBackColor = true;
            this.BoolNumButton.Click += new System.EventHandler(this.BoolNumButton_Click);
            // 
            // Veriables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Veriables";
            this.Text = "Veriables";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShortTotalButton;
        private System.Windows.Forms.Label ShortTotalLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label UShortLabel;
        private System.Windows.Forms.Button UShortButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label FloatLabel;
        private System.Windows.Forms.Button FloatButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label DecimalLabel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label BoolLabel;
        private System.Windows.Forms.Button BollButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label BoolNumLabel;
        private System.Windows.Forms.Button BoolNumButton;
    }
}

