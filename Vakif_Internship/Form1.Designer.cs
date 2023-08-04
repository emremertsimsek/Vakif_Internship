namespace Vakif_Internship
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontrol Edilmek İçin Seçilen Dosyalar";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(592, 316);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(385, 69);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "2- Seçilen Dosyaları Tara";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(592, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(385, 69);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "1-Taranacak Dosyaları Seçiniz(Tek Seferde Hepsi Seçilmeli)";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 20;
            this.lbFiles.Location = new System.Drawing.Point(34, 118);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(943, 184);
            this.lbFiles.TabIndex = 3;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 20;
            this.lbResult.Location = new System.Drawing.Point(34, 398);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(943, 204);
            this.lbResult.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(592, 608);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(385, 69);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "3- ListBox\'ları Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hataların Bulundukları Cs Dosyalarının Yolları ve Bulundukları Satırların Numaral" +
    "arı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}

