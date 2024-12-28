namespace Project.WinFormUI
{
    partial class AddForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstCekimAlanlari = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationDescription = new System.Windows.Forms.TextBox();
            this.txtLocationCity = new System.Windows.Forms.TextBox();
            this.txtLocationDistrict = new System.Windows.Forms.TextBox();
            this.txtLocationAddress = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstFotografcilar = new System.Windows.Forms.ListBox();
            this.btnPhotographerAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhotographerPhone = new System.Windows.Forms.TextBox();
            this.txtPhotographerLastName = new System.Windows.Forms.TextBox();
            this.txtPhotographerFirstName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstAlbümler = new System.Windows.Forms.ListBox();
            this.btnAlbumEkle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkIsPackage = new System.Windows.Forms.CheckBox();
            this.cmbCanvasSize = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstCekimAlanlari);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLocationDescription);
            this.tabPage1.Controls.Add(this.txtLocationCity);
            this.tabPage1.Controls.Add(this.txtLocationDistrict);
            this.tabPage1.Controls.Add(this.txtLocationAddress);
            this.tabPage1.Controls.Add(this.txtLocationName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çekim Alanı Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstCekimAlanlari
            // 
            this.lstCekimAlanlari.FormattingEnabled = true;
            this.lstCekimAlanlari.Location = new System.Drawing.Point(428, 51);
            this.lstCekimAlanlari.Name = "lstCekimAlanlari";
            this.lstCekimAlanlari.Size = new System.Drawing.Size(313, 277);
            this.lstCekimAlanlari.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(44, 195);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Mekan Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "İl :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlçe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mekan Adı :";
            // 
            // txtLocationDescription
            // 
            this.txtLocationDescription.Location = new System.Drawing.Point(144, 155);
            this.txtLocationDescription.Name = "txtLocationDescription";
            this.txtLocationDescription.Size = new System.Drawing.Size(264, 20);
            this.txtLocationDescription.TabIndex = 1;
            // 
            // txtLocationCity
            // 
            this.txtLocationCity.Location = new System.Drawing.Point(144, 129);
            this.txtLocationCity.Name = "txtLocationCity";
            this.txtLocationCity.Size = new System.Drawing.Size(264, 20);
            this.txtLocationCity.TabIndex = 1;
            // 
            // txtLocationDistrict
            // 
            this.txtLocationDistrict.Location = new System.Drawing.Point(144, 103);
            this.txtLocationDistrict.Name = "txtLocationDistrict";
            this.txtLocationDistrict.Size = new System.Drawing.Size(264, 20);
            this.txtLocationDistrict.TabIndex = 2;
            // 
            // txtLocationAddress
            // 
            this.txtLocationAddress.Location = new System.Drawing.Point(144, 77);
            this.txtLocationAddress.Name = "txtLocationAddress";
            this.txtLocationAddress.Size = new System.Drawing.Size(264, 20);
            this.txtLocationAddress.TabIndex = 0;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(144, 51);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(264, 20);
            this.txtLocationName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstFotografcilar);
            this.tabPage2.Controls.Add(this.btnPhotographerAdd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPhotographerPhone);
            this.tabPage2.Controls.Add(this.txtPhotographerLastName);
            this.tabPage2.Controls.Add(this.txtPhotographerFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fotoğrafçı Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstFotografcilar
            // 
            this.lstFotografcilar.FormattingEnabled = true;
            this.lstFotografcilar.Location = new System.Drawing.Point(336, 61);
            this.lstFotografcilar.Name = "lstFotografcilar";
            this.lstFotografcilar.Size = new System.Drawing.Size(405, 277);
            this.lstFotografcilar.TabIndex = 3;
            // 
            // btnPhotographerAdd
            // 
            this.btnPhotographerAdd.Location = new System.Drawing.Point(23, 156);
            this.btnPhotographerAdd.Name = "btnPhotographerAdd";
            this.btnPhotographerAdd.Size = new System.Drawing.Size(93, 23);
            this.btnPhotographerAdd.TabIndex = 2;
            this.btnPhotographerAdd.Text = "Fotoğrafçı Ekle";
            this.btnPhotographerAdd.UseVisualStyleBackColor = true;
            this.btnPhotographerAdd.Click += new System.EventHandler(this.btnPhotographerAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telefon Numarası :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ad :";
            // 
            // txtPhotographerPhone
            // 
            this.txtPhotographerPhone.Location = new System.Drawing.Point(141, 113);
            this.txtPhotographerPhone.Name = "txtPhotographerPhone";
            this.txtPhotographerPhone.Size = new System.Drawing.Size(173, 20);
            this.txtPhotographerPhone.TabIndex = 0;
            // 
            // txtPhotographerLastName
            // 
            this.txtPhotographerLastName.Location = new System.Drawing.Point(141, 87);
            this.txtPhotographerLastName.Name = "txtPhotographerLastName";
            this.txtPhotographerLastName.Size = new System.Drawing.Size(173, 20);
            this.txtPhotographerLastName.TabIndex = 0;
            // 
            // txtPhotographerFirstName
            // 
            this.txtPhotographerFirstName.Location = new System.Drawing.Point(141, 61);
            this.txtPhotographerFirstName.Name = "txtPhotographerFirstName";
            this.txtPhotographerFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtPhotographerFirstName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstAlbümler);
            this.tabPage3.Controls.Add(this.btnAlbumEkle);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.chkIsPackage);
            this.tabPage3.Controls.Add(this.cmbCanvasSize);
            this.tabPage3.Controls.Add(this.cmbSize);
            this.tabPage3.Controls.Add(this.cmbCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(747, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albüm Ekle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstAlbümler
            // 
            this.lstAlbümler.FormattingEnabled = true;
            this.lstAlbümler.Location = new System.Drawing.Point(262, 55);
            this.lstAlbümler.Name = "lstAlbümler";
            this.lstAlbümler.Size = new System.Drawing.Size(471, 277);
            this.lstAlbümler.TabIndex = 5;
            // 
            // btnAlbumEkle
            // 
            this.btnAlbumEkle.Location = new System.Drawing.Point(27, 174);
            this.btnAlbumEkle.Name = "btnAlbumEkle";
            this.btnAlbumEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAlbumEkle.TabIndex = 4;
            this.btnAlbumEkle.Text = "Albüm Ekle";
            this.btnAlbumEkle.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Aile Paketi Mi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kanvas Boyutu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Albüm Boyutu :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Albüm Kategorisi :";
            // 
            // chkIsPackage
            // 
            this.chkIsPackage.AutoSize = true;
            this.chkIsPackage.Location = new System.Drawing.Point(121, 140);
            this.chkIsPackage.Name = "chkIsPackage";
            this.chkIsPackage.Size = new System.Drawing.Size(48, 17);
            this.chkIsPackage.TabIndex = 2;
            this.chkIsPackage.Text = "Evet";
            this.chkIsPackage.UseVisualStyleBackColor = true;
            // 
            // cmbCanvasSize
            // 
            this.cmbCanvasSize.FormattingEnabled = true;
            this.cmbCanvasSize.Location = new System.Drawing.Point(121, 109);
            this.cmbCanvasSize.Name = "cmbCanvasSize";
            this.cmbCanvasSize.Size = new System.Drawing.Size(121, 21);
            this.cmbCanvasSize.TabIndex = 1;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(121, 82);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(121, 55);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 0;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationDescription;
        private System.Windows.Forms.TextBox txtLocationCity;
        private System.Windows.Forms.TextBox txtLocationDistrict;
        private System.Windows.Forms.TextBox txtLocationAddress;
        private System.Windows.Forms.ListBox lstCekimAlanlari;
        private System.Windows.Forms.Button btnPhotographerAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhotographerPhone;
        private System.Windows.Forms.TextBox txtPhotographerLastName;
        private System.Windows.Forms.TextBox txtPhotographerFirstName;
        private System.Windows.Forms.ListBox lstFotografcilar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkIsPackage;
        private System.Windows.Forms.ComboBox cmbCanvasSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lstAlbümler;
        private System.Windows.Forms.Button btnAlbumEkle;
    }
}