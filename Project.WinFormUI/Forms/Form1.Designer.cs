namespace Project.WinFormUI
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
            this.btnEkleme = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkleme
            // 
            this.btnEkleme.Location = new System.Drawing.Point(51, 161);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(75, 23);
            this.btnEkleme.TabIndex = 0;
            this.btnEkleme.Text = "Ekleme";
            this.btnEkleme.UseVisualStyleBackColor = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(51, 190);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelleme.TabIndex = 0;
            this.btnGuncelleme.Text = "Guncelleme";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(149, 190);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(75, 23);
            this.btnRaporlar.TabIndex = 1;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(149, 161);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(75, 23);
            this.btnSilme.TabIndex = 2;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 285);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.btnEkleme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnSilme;
    }
}

