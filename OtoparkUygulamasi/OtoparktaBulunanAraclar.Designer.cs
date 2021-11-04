
namespace OtoparkUygulamasi
{
    partial class OtoparktaBulunanAraclar
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
            this.AracListesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AracListesi
            // 
            this.AracListesi.FormattingEnabled = true;
            this.AracListesi.ItemHeight = 22;
            this.AracListesi.Location = new System.Drawing.Point(27, 129);
            this.AracListesi.Name = "AracListesi";
            this.AracListesi.Size = new System.Drawing.Size(690, 202);
            this.AracListesi.TabIndex = 0;
            this.AracListesi.SelectedIndexChanged += new System.EventHandler(this.AracListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(232, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otoparkta Bulunan Araçlar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Görüntüle/Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtoparktaBulunanAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AracListesi);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OtoparktaBulunanAraclar";
            this.Text = "Otoparkta Bulunan Araclar";
            this.Load += new System.EventHandler(this.OtoparktaBulunanAraclar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AracListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}