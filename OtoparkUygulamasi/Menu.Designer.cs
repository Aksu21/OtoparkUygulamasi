
namespace OtoparkUygulamasi
{
    partial class Menu
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
            this.AbonelikTanimlaButton = new System.Windows.Forms.Button();
            this.AbonelikOlusturButton = new System.Windows.Forms.Button();
            this.TarifeTanimlaButton = new System.Windows.Forms.Button();
            this.AracGirisiButton = new System.Windows.Forms.Button();
            this.AracCikisButton = new System.Windows.Forms.Button();
            this.PlakaGirisCikisButton = new System.Windows.Forms.Button();
            this.OtoparktakiAracButton = new System.Windows.Forms.Button();
            this.AktifAracButton = new System.Windows.Forms.Button();
            this.AylikKazancButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AbonelikTanimlaButton
            // 
            this.AbonelikTanimlaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbonelikTanimlaButton.Location = new System.Drawing.Point(170, 159);
            this.AbonelikTanimlaButton.Name = "AbonelikTanimlaButton";
            this.AbonelikTanimlaButton.Size = new System.Drawing.Size(368, 53);
            this.AbonelikTanimlaButton.TabIndex = 0;
            this.AbonelikTanimlaButton.Text = "Abonelik Bilgisi Tanımla";
            this.AbonelikTanimlaButton.UseVisualStyleBackColor = true;
            this.AbonelikTanimlaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbonelikOlusturButton
            // 
            this.AbonelikOlusturButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbonelikOlusturButton.Location = new System.Drawing.Point(170, 100);
            this.AbonelikOlusturButton.Name = "AbonelikOlusturButton";
            this.AbonelikOlusturButton.Size = new System.Drawing.Size(368, 53);
            this.AbonelikOlusturButton.TabIndex = 1;
            this.AbonelikOlusturButton.Text = "Abonelik Oluştur";
            this.AbonelikOlusturButton.UseVisualStyleBackColor = true;
            this.AbonelikOlusturButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TarifeTanimlaButton
            // 
            this.TarifeTanimlaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TarifeTanimlaButton.Location = new System.Drawing.Point(170, 235);
            this.TarifeTanimlaButton.Name = "TarifeTanimlaButton";
            this.TarifeTanimlaButton.Size = new System.Drawing.Size(368, 53);
            this.TarifeTanimlaButton.TabIndex = 2;
            this.TarifeTanimlaButton.Text = "Tarife Tanımla";
            this.TarifeTanimlaButton.UseVisualStyleBackColor = true;
            this.TarifeTanimlaButton.Click += new System.EventHandler(this.TarifeTanimlaButton_Click);
            // 
            // AracGirisiButton
            // 
            this.AracGirisiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AracGirisiButton.Location = new System.Drawing.Point(170, 294);
            this.AracGirisiButton.Name = "AracGirisiButton";
            this.AracGirisiButton.Size = new System.Drawing.Size(368, 53);
            this.AracGirisiButton.TabIndex = 3;
            this.AracGirisiButton.Text = "Araç Girişi Ekle";
            this.AracGirisiButton.UseVisualStyleBackColor = true;
            this.AracGirisiButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // AracCikisButton
            // 
            this.AracCikisButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AracCikisButton.Location = new System.Drawing.Point(170, 353);
            this.AracCikisButton.Name = "AracCikisButton";
            this.AracCikisButton.Size = new System.Drawing.Size(368, 53);
            this.AracCikisButton.TabIndex = 4;
            this.AracCikisButton.Text = "Araç Çıkış ve Ücretlendirme";
            this.AracCikisButton.UseVisualStyleBackColor = true;
            this.AracCikisButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // PlakaGirisCikisButton
            // 
            this.PlakaGirisCikisButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlakaGirisCikisButton.Location = new System.Drawing.Point(170, 489);
            this.PlakaGirisCikisButton.Name = "PlakaGirisCikisButton";
            this.PlakaGirisCikisButton.Size = new System.Drawing.Size(368, 53);
            this.PlakaGirisCikisButton.TabIndex = 5;
            this.PlakaGirisCikisButton.Text = "Plaka Giriş/Çıkış Sorgula";
            this.PlakaGirisCikisButton.UseVisualStyleBackColor = true;
            this.PlakaGirisCikisButton.Click += new System.EventHandler(this.PlakaGirisCikisButton_Click);
            // 
            // OtoparktakiAracButton
            // 
            this.OtoparktakiAracButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OtoparktakiAracButton.Location = new System.Drawing.Point(170, 430);
            this.OtoparktakiAracButton.Name = "OtoparktakiAracButton";
            this.OtoparktakiAracButton.Size = new System.Drawing.Size(368, 53);
            this.OtoparktakiAracButton.TabIndex = 6;
            this.OtoparktakiAracButton.Text = "Otoparkta Bulunan Araçlar";
            this.OtoparktakiAracButton.UseVisualStyleBackColor = true;
            this.OtoparktakiAracButton.Click += new System.EventHandler(this.OtoparktakiAracButton_Click);
            // 
            // AktifAracButton
            // 
            this.AktifAracButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AktifAracButton.Location = new System.Drawing.Point(170, 608);
            this.AktifAracButton.Name = "AktifAracButton";
            this.AktifAracButton.Size = new System.Drawing.Size(368, 53);
            this.AktifAracButton.TabIndex = 7;
            this.AktifAracButton.Text = "Aboneliği Devam Eden Araçlar";
            this.AktifAracButton.UseVisualStyleBackColor = true;
            this.AktifAracButton.Click += new System.EventHandler(this.AktifAracButton_Click);
            // 
            // AylikKazancButton
            // 
            this.AylikKazancButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AylikKazancButton.Location = new System.Drawing.Point(170, 548);
            this.AylikKazancButton.Name = "AylikKazancButton";
            this.AylikKazancButton.Size = new System.Drawing.Size(368, 53);
            this.AylikKazancButton.TabIndex = 8;
            this.AylikKazancButton.Text = "Aylık Otopark Kazancı";
            this.AylikKazancButton.UseVisualStyleBackColor = true;
            this.AylikKazancButton.Click += new System.EventHandler(this.AylikKazancButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "OTOPARK YÖNETİM SİSTEMİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AylikKazancButton);
            this.Controls.Add(this.AktifAracButton);
            this.Controls.Add(this.OtoparktakiAracButton);
            this.Controls.Add(this.PlakaGirisCikisButton);
            this.Controls.Add(this.AracCikisButton);
            this.Controls.Add(this.AracGirisiButton);
            this.Controls.Add(this.TarifeTanimlaButton);
            this.Controls.Add(this.AbonelikOlusturButton);
            this.Controls.Add(this.AbonelikTanimlaButton);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbonelikTanimlaButton;
        private System.Windows.Forms.Button AbonelikOlusturButton;
        private System.Windows.Forms.Button TarifeTanimlaButton;
        private System.Windows.Forms.Button AracGirisiButton;
        private System.Windows.Forms.Button AracCikisButton;
        private System.Windows.Forms.Button PlakaGirisCikisButton;
        private System.Windows.Forms.Button OtoparktakiAracButton;
        private System.Windows.Forms.Button AktifAracButton;
        private System.Windows.Forms.Button AylikKazancButton;
        private System.Windows.Forms.Label label1;
    }
}

