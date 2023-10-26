namespace MelihHocaOdev3.Hafta
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ad = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Yas = new System.Windows.Forms.Label();
            this.Unvan = new System.Windows.Forms.Label();
            this.MesaiSaati = new System.Windows.Forms.Label();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.YasTxt = new System.Windows.Forms.TextBox();
            this.AdresTxt = new System.Windows.Forms.RichTextBox();
            this.MesaiSaatiTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(70, 44);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(51, 32);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adres.Location = new System.Drawing.Point(70, 111);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(93, 32);
            this.Adres.TabIndex = 1;
            this.Adres.Text = "Adres";
            // 
            // Yas
            // 
            this.Yas.AutoSize = true;
            this.Yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yas.Location = new System.Drawing.Point(70, 179);
            this.Yas.Name = "Yas";
            this.Yas.Size = new System.Drawing.Size(66, 32);
            this.Yas.TabIndex = 2;
            this.Yas.Text = "Yaş";
            // 
            // Unvan
            // 
            this.Unvan.AutoSize = true;
            this.Unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Unvan.Location = new System.Drawing.Point(70, 268);
            this.Unvan.Name = "Unvan";
            this.Unvan.Size = new System.Drawing.Size(101, 32);
            this.Unvan.TabIndex = 3;
            this.Unvan.Text = "Unvan";
            // 
            // MesaiSaati
            // 
            this.MesaiSaati.AutoSize = true;
            this.MesaiSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MesaiSaati.Location = new System.Drawing.Point(70, 336);
            this.MesaiSaati.Name = "MesaiSaati";
            this.MesaiSaati.Size = new System.Drawing.Size(182, 32);
            this.MesaiSaati.TabIndex = 4;
            this.MesaiSaati.Text = "Mesai Saati ";
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(255, 54);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(274, 22);
            this.AdTxt.TabIndex = 5;
            // 
            // YasTxt
            // 
            this.YasTxt.Location = new System.Drawing.Point(255, 194);
            this.YasTxt.Name = "YasTxt";
            this.YasTxt.Size = new System.Drawing.Size(274, 22);
            this.YasTxt.TabIndex = 6;
            // 
            // AdresTxt
            // 
            this.AdresTxt.Location = new System.Drawing.Point(255, 102);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(274, 67);
            this.AdresTxt.TabIndex = 7;
            this.AdresTxt.Text = "";
            // 
            // MesaiSaatiTxt
            // 
            this.MesaiSaatiTxt.Location = new System.Drawing.Point(255, 336);
            this.MesaiSaatiTxt.Name = "MesaiSaatiTxt";
            this.MesaiSaatiTxt.Size = new System.Drawing.Size(274, 22);
            this.MesaiSaatiTxt.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İşçi",
            "Mühendis"});
            this.comboBox1.Location = new System.Drawing.Point(255, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Unvan Seçin...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MesaiSaatiTxt);
            this.Controls.Add(this.AdresTxt);
            this.Controls.Add(this.YasTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.MesaiSaati);
            this.Controls.Add(this.Unvan);
            this.Controls.Add(this.Yas);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Yas;
        private System.Windows.Forms.Label Unvan;
        private System.Windows.Forms.Label MesaiSaati;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.TextBox YasTxt;
        private System.Windows.Forms.RichTextBox AdresTxt;
        private System.Windows.Forms.TextBox MesaiSaatiTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

