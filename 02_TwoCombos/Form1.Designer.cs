namespace _02_TwoCombos
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
            this.cboxFirst = new System.Windows.Forms.ComboBox();
            this.cboxSecond = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxFirst
            // 
            this.cboxFirst.FormattingEnabled = true;
            this.cboxFirst.Location = new System.Drawing.Point(66, 59);
            this.cboxFirst.Name = "cboxFirst";
            this.cboxFirst.Size = new System.Drawing.Size(121, 27);
            this.cboxFirst.TabIndex = 0;
            this.cboxFirst.SelectedIndexChanged += new System.EventHandler(this.cboxFirst_SelectedIndexChanged);
            // 
            // cboxSecond
            // 
            this.cboxSecond.FormattingEnabled = true;
            this.cboxSecond.Location = new System.Drawing.Point(66, 110);
            this.cboxSecond.Name = "cboxSecond";
            this.cboxSecond.Size = new System.Drawing.Size(121, 27);
            this.cboxSecond.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 354);
            this.Controls.Add(this.cboxSecond);
            this.Controls.Add(this.cboxFirst);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxFirst;
        private System.Windows.Forms.ComboBox cboxSecond;
    }
}

