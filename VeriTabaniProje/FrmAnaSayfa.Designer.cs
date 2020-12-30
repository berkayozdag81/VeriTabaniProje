namespace VeriTabaniProje
{
    partial class FrmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.satisBtn = new System.Windows.Forms.Button();
            this.sozlesmeBtn = new System.Windows.Forms.Button();
            this.aracListeBtn = new System.Windows.Forms.Button();
            this.aracKayitBtn = new System.Windows.Forms.Button();
            this.müsteriListeBtn = new System.Windows.Forms.Button();
            this.müsteriEkleBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.satisBtn);
            this.panel1.Controls.Add(this.sozlesmeBtn);
            this.panel1.Controls.Add(this.aracListeBtn);
            this.panel1.Controls.Add(this.aracKayitBtn);
            this.panel1.Controls.Add(this.müsteriListeBtn);
            this.panel1.Controls.Add(this.müsteriEkleBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 121);
            this.panel1.TabIndex = 0;
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.White;
            this.cikisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikisBtn.ImageIndex = 0;
            this.cikisBtn.ImageList = this.ımageList1;
            this.cikisBtn.Location = new System.Drawing.Point(824, 12);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(124, 93);
            this.cikisBtn.TabIndex = 6;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images (3).jpg");
            this.ımageList1.Images.SetKeyName(1, "indir (6).jpg");
            this.ımageList1.Images.SetKeyName(2, "satis.png");
            this.ımageList1.Images.SetKeyName(3, "indir (7).jpg");
            this.ımageList1.Images.SetKeyName(4, "indir (8).jpg");
            this.ımageList1.Images.SetKeyName(5, "indir (5).jpg");
            this.ımageList1.Images.SetKeyName(6, "satis.png");
            this.ımageList1.Images.SetKeyName(7, "sözlesme.jpg");
            // 
            // satisBtn
            // 
            this.satisBtn.BackColor = System.Drawing.Color.White;
            this.satisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satisBtn.ImageIndex = 2;
            this.satisBtn.ImageList = this.ımageList1;
            this.satisBtn.Location = new System.Drawing.Point(689, 12);
            this.satisBtn.Name = "satisBtn";
            this.satisBtn.Size = new System.Drawing.Size(129, 93);
            this.satisBtn.TabIndex = 5;
            this.satisBtn.Text = "Satışlar";
            this.satisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisBtn.UseVisualStyleBackColor = false;
            this.satisBtn.Click += new System.EventHandler(this.satisBtn_Click);
            // 
            // sozlesmeBtn
            // 
            this.sozlesmeBtn.BackColor = System.Drawing.Color.White;
            this.sozlesmeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sozlesmeBtn.ImageIndex = 7;
            this.sozlesmeBtn.ImageList = this.ımageList1;
            this.sozlesmeBtn.Location = new System.Drawing.Point(560, 12);
            this.sozlesmeBtn.Name = "sozlesmeBtn";
            this.sozlesmeBtn.Size = new System.Drawing.Size(123, 93);
            this.sozlesmeBtn.TabIndex = 4;
            this.sozlesmeBtn.Text = "Sözleşme";
            this.sozlesmeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sozlesmeBtn.UseVisualStyleBackColor = false;
            this.sozlesmeBtn.Click += new System.EventHandler(this.sozlesmeBtn_Click);
            // 
            // aracListeBtn
            // 
            this.aracListeBtn.BackColor = System.Drawing.Color.White;
            this.aracListeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracListeBtn.ImageIndex = 1;
            this.aracListeBtn.ImageList = this.ımageList1;
            this.aracListeBtn.Location = new System.Drawing.Point(425, 12);
            this.aracListeBtn.Name = "aracListeBtn";
            this.aracListeBtn.Size = new System.Drawing.Size(129, 93);
            this.aracListeBtn.TabIndex = 3;
            this.aracListeBtn.Text = "Araç Listeleme";
            this.aracListeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracListeBtn.UseVisualStyleBackColor = false;
            this.aracListeBtn.Click += new System.EventHandler(this.aracListeBtn_Click);
            // 
            // aracKayitBtn
            // 
            this.aracKayitBtn.BackColor = System.Drawing.Color.White;
            this.aracKayitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracKayitBtn.ImageIndex = 3;
            this.aracKayitBtn.ImageList = this.ımageList1;
            this.aracKayitBtn.Location = new System.Drawing.Point(302, 12);
            this.aracKayitBtn.Name = "aracKayitBtn";
            this.aracKayitBtn.Size = new System.Drawing.Size(117, 93);
            this.aracKayitBtn.TabIndex = 2;
            this.aracKayitBtn.Text = "Araç Kayıt";
            this.aracKayitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracKayitBtn.UseVisualStyleBackColor = false;
            this.aracKayitBtn.Click += new System.EventHandler(this.aracKayitBtn_Click);
            // 
            // müsteriListeBtn
            // 
            this.müsteriListeBtn.BackColor = System.Drawing.Color.White;
            this.müsteriListeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.müsteriListeBtn.ImageIndex = 5;
            this.müsteriListeBtn.ImageList = this.ımageList1;
            this.müsteriListeBtn.Location = new System.Drawing.Point(148, 12);
            this.müsteriListeBtn.Name = "müsteriListeBtn";
            this.müsteriListeBtn.Size = new System.Drawing.Size(148, 93);
            this.müsteriListeBtn.TabIndex = 1;
            this.müsteriListeBtn.Text = "Müşteri Listeleme";
            this.müsteriListeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.müsteriListeBtn.UseVisualStyleBackColor = false;
            this.müsteriListeBtn.Click += new System.EventHandler(this.müsteriListeBtn_Click);
            // 
            // müsteriEkleBtn
            // 
            this.müsteriEkleBtn.BackColor = System.Drawing.Color.White;
            this.müsteriEkleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.müsteriEkleBtn.ImageIndex = 4;
            this.müsteriEkleBtn.ImageList = this.ımageList1;
            this.müsteriEkleBtn.Location = new System.Drawing.Point(12, 12);
            this.müsteriEkleBtn.Name = "müsteriEkleBtn";
            this.müsteriEkleBtn.Size = new System.Drawing.Size(130, 93);
            this.müsteriEkleBtn.TabIndex = 0;
            this.müsteriEkleBtn.Text = "Müşteri Ekleme";
            this.müsteriEkleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.müsteriEkleBtn.UseVisualStyleBackColor = false;
            this.müsteriEkleBtn.Click += new System.EventHandler(this.müsteriEkleBtn_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 724);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BER-CAR";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button satisBtn;
        private System.Windows.Forms.Button sozlesmeBtn;
        private System.Windows.Forms.Button aracListeBtn;
        private System.Windows.Forms.Button aracKayitBtn;
        private System.Windows.Forms.Button müsteriListeBtn;
        private System.Windows.Forms.Button müsteriEkleBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

