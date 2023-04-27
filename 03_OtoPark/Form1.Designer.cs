namespace _03_OtoPark
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAracTuru = new System.Windows.Forms.ComboBox();
            this.btonHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalınan Süre (saat)";
            // 
            // tboxSure
            // 
            this.tboxSure.Location = new System.Drawing.Point(214, 27);
            this.tboxSure.Name = "tboxSure";
            this.tboxSure.Size = new System.Drawing.Size(41, 26);
            this.tboxSure.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araç Türü";
            // 
            // cboxAracTuru
            // 
            this.cboxAracTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAracTuru.FormattingEnabled = true;
            this.cboxAracTuru.Items.AddRange(new object[] {
            "--- Seçiniz ---",
            "Otomobil",
            "Minibüs",
            "Ticari Araç"});
            this.cboxAracTuru.Location = new System.Drawing.Point(214, 74);
            this.cboxAracTuru.Name = "cboxAracTuru";
            this.cboxAracTuru.Size = new System.Drawing.Size(166, 27);
            this.cboxAracTuru.TabIndex = 3;
            // 
            // btonHesapla
            // 
            this.btonHesapla.Location = new System.Drawing.Point(214, 122);
            this.btonHesapla.Name = "btonHesapla";
            this.btonHesapla.Size = new System.Drawing.Size(100, 41);
            this.btonHesapla.TabIndex = 4;
            this.btonHesapla.Text = "Hesapla";
            this.btonHesapla.UseVisualStyleBackColor = true;
            this.btonHesapla.Click += new System.EventHandler(this.btonHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 262);
            this.Controls.Add(this.btonHesapla);
            this.Controls.Add(this.cboxAracTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxSure);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAracTuru;
        private System.Windows.Forms.Button btonHesapla;
    }
}

