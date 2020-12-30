namespace VeriTabaniProje
{
    partial class AracEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.aracTurComboBox = new System.Windows.Forms.ComboBox();
            this.vitesComboBox = new System.Windows.Forms.ComboBox();
            this.yakitComboBox = new System.Windows.Forms.ComboBox();
            this.renkComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.aracEkleBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.aracIptalBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aracResimBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.fiyatTxt = new System.Windows.Forms.TextBox();
            this.iptalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aracTurComboBox
            // 
            this.aracTurComboBox.FormattingEnabled = true;
            this.aracTurComboBox.Items.AddRange(new object[] {
            "OTOMOBİL",
            "SUV",
            "KAMYONET"});
            this.aracTurComboBox.Location = new System.Drawing.Point(114, 37);
            this.aracTurComboBox.Name = "aracTurComboBox";
            this.aracTurComboBox.Size = new System.Drawing.Size(151, 24);
            this.aracTurComboBox.TabIndex = 0;
            this.aracTurComboBox.SelectedIndexChanged += new System.EventHandler(this.aracTurComboBox_SelectedIndexChanged);
            // 
            // vitesComboBox
            // 
            this.vitesComboBox.FormattingEnabled = true;
            this.vitesComboBox.Items.AddRange(new object[] {
            "OTOMATİK",
            "MANUEL",
            "YARI-OTOMATİK"});
            this.vitesComboBox.Location = new System.Drawing.Point(114, 283);
            this.vitesComboBox.Name = "vitesComboBox";
            this.vitesComboBox.Size = new System.Drawing.Size(151, 24);
            this.vitesComboBox.TabIndex = 1;
            this.vitesComboBox.SelectedIndexChanged += new System.EventHandler(this.vitesComboBox_SelectedIndexChanged);
            // 
            // yakitComboBox
            // 
            this.yakitComboBox.FormattingEnabled = true;
            this.yakitComboBox.Items.AddRange(new object[] {
            "DİZEL",
            "BENZİN",
            "BENZİN-LPG"});
            this.yakitComboBox.Location = new System.Drawing.Point(114, 242);
            this.yakitComboBox.Name = "yakitComboBox";
            this.yakitComboBox.Size = new System.Drawing.Size(151, 24);
            this.yakitComboBox.TabIndex = 2;
            this.yakitComboBox.SelectedIndexChanged += new System.EventHandler(this.yakitComboBox_SelectedIndexChanged);
            // 
            // renkComboBox
            // 
            this.renkComboBox.FormattingEnabled = true;
            this.renkComboBox.Items.AddRange(new object[] {
            "GRİ",
            "SİYAH",
            "BEYAZ",
            "LACİVERT",
            "GÜMÜŞ GRİ",
            "KIRMIZI",
            "YEŞİL"});
            this.renkComboBox.Location = new System.Drawing.Point(114, 160);
            this.renkComboBox.Name = "renkComboBox";
            this.renkComboBox.Size = new System.Drawing.Size(151, 24);
            this.renkComboBox.TabIndex = 4;
            this.renkComboBox.SelectedIndexChanged += new System.EventHandler(this.renkComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(114, 119);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(151, 24);
            this.modelComboBox.TabIndex = 5;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // markaComboBox
            // 
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Items.AddRange(new object[] {
            "FORD",
            "MERCEDES",
            "BMW",
            "HONDA",
            "RENAULT",
            "OPEL"});
            this.markaComboBox.Location = new System.Drawing.Point(114, 78);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(151, 24);
            this.markaComboBox.TabIndex = 6;
            this.markaComboBox.SelectedIndexChanged += new System.EventHandler(this.markaComboBox_SelectedIndexChanged);
            // 
            // aracEkleBtn
            // 
            this.aracEkleBtn.BackColor = System.Drawing.Color.White;
            this.aracEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracEkleBtn.ImageIndex = 0;
            this.aracEkleBtn.ImageList = this.ımageList1;
            this.aracEkleBtn.Location = new System.Drawing.Point(34, 364);
            this.aracEkleBtn.Name = "aracEkleBtn";
            this.aracEkleBtn.Size = new System.Drawing.Size(122, 67);
            this.aracEkleBtn.TabIndex = 7;
            this.aracEkleBtn.Text = "EKLE";
            this.aracEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aracEkleBtn.UseVisualStyleBackColor = false;
            this.aracEkleBtn.Click += new System.EventHandler(this.aracEkleBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (10).jpg");
            this.ımageList1.Images.SetKeyName(1, "iptallll.jpg");
            this.ımageList1.Images.SetKeyName(2, "exit.jpg");
            // 
            // aracIptalBtn
            // 
            this.aracIptalBtn.BackColor = System.Drawing.Color.White;
            this.aracIptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracIptalBtn.ImageIndex = 2;
            this.aracIptalBtn.ImageList = this.ımageList1;
            this.aracIptalBtn.Location = new System.Drawing.Point(349, 364);
            this.aracIptalBtn.Name = "aracIptalBtn";
            this.aracIptalBtn.Size = new System.Drawing.Size(104, 67);
            this.aracIptalBtn.TabIndex = 8;
            this.aracIptalBtn.Text = "ÇIKIŞ";
            this.aracIptalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aracIptalBtn.UseVisualStyleBackColor = false;
            this.aracIptalBtn.Click += new System.EventHandler(this.aracIptalBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(283, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // aracResimBtn
            // 
            this.aracResimBtn.BackColor = System.Drawing.Color.White;
            this.aracResimBtn.Location = new System.Drawing.Point(349, 226);
            this.aracResimBtn.Name = "aracResimBtn";
            this.aracResimBtn.Size = new System.Drawing.Size(111, 52);
            this.aracResimBtn.TabIndex = 10;
            this.aracResimBtn.Text = "RESİM EKLE";
            this.aracResimBtn.UseVisualStyleBackColor = false;
            this.aracResimBtn.Click += new System.EventHandler(this.aracResimBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "MARKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "YAKIT TÜRÜ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "VİTES TÜRÜ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "ARAÇ TÜRÜ";
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(114, 204);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(151, 22);
            this.kmTxt.TabIndex = 18;
            this.kmTxt.TextChanged += new System.EventHandler(this.kmTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bütün alanlar doldurulmak zorundadır!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "FİYAT";
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.Location = new System.Drawing.Point(114, 324);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(151, 22);
            this.fiyatTxt.TabIndex = 22;
            this.fiyatTxt.TextChanged += new System.EventHandler(this.fiyatTxt_TextChanged);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.White;
            this.iptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptalBtn.ImageIndex = 1;
            this.iptalBtn.ImageList = this.ımageList1;
            this.iptalBtn.Location = new System.Drawing.Point(174, 364);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(116, 67);
            this.iptalBtn.TabIndex = 23;
            this.iptalBtn.Text = "İPTAL";
            this.iptalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(485, 443);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.fiyatTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aracResimBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aracIptalBtn);
            this.Controls.Add(this.aracEkleBtn);
            this.Controls.Add(this.markaComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.renkComboBox);
            this.Controls.Add(this.yakitComboBox);
            this.Controls.Add(this.vitesComboBox);
            this.Controls.Add(this.aracTurComboBox);
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox aracTurComboBox;
        private System.Windows.Forms.ComboBox vitesComboBox;
        private System.Windows.Forms.ComboBox yakitComboBox;
        private System.Windows.Forms.ComboBox renkComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.Button aracEkleBtn;
        private System.Windows.Forms.Button aracIptalBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aracResimBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fiyatTxt;
        private System.Windows.Forms.Button iptalBtn;
    }
}