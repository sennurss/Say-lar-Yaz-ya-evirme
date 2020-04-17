namespace Arrys
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
            this.textBoxSayi = new System.Windows.Forms.TextBox();
            this.buttonYaziyaCevir = new System.Windows.Forms.Button();
            this.labelYazi = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSayi
            // 
            this.textBoxSayi.Location = new System.Drawing.Point(13, 53);
            this.textBoxSayi.Name = "textBoxSayi";
            this.textBoxSayi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSayi.TabIndex = 0;
            // 
            // buttonYaziyaCevir
            // 
            this.buttonYaziyaCevir.Location = new System.Drawing.Point(12, 127);
            this.buttonYaziyaCevir.Name = "buttonYaziyaCevir";
            this.buttonYaziyaCevir.Size = new System.Drawing.Size(75, 23);
            this.buttonYaziyaCevir.TabIndex = 1;
            this.buttonYaziyaCevir.Text = "Yazıya Çevir";
            this.buttonYaziyaCevir.UseVisualStyleBackColor = true;
            this.buttonYaziyaCevir.Click += new System.EventHandler(this.buttonYaziyaCevir_Click);
            // 
            // labelYazi
            // 
            this.labelYazi.AutoSize = true;
            this.labelYazi.Location = new System.Drawing.Point(12, 92);
            this.labelYazi.Name = "labelYazi";
            this.labelYazi.Size = new System.Drawing.Size(22, 13);
            this.labelYazi.TabIndex = 2;
            this.labelYazi.Text = ".....";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(117, 126);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 23);
            this.buttonTemizle.TabIndex = 3;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 298);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.labelYazi);
            this.Controls.Add(this.buttonYaziyaCevir);
            this.Controls.Add(this.textBoxSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSayi;
        private System.Windows.Forms.Button buttonYaziyaCevir;
        private System.Windows.Forms.Label labelYazi;
        private System.Windows.Forms.Button buttonTemizle;
    }
}

