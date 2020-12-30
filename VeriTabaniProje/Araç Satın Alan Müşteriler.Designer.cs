namespace VeriTabaniProje
{
    partial class Müşteriler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListeBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.arananTxt = new System.Windows.Forms.TextBox();
            this.araLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.TCtxt = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.güncelBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.silinenMüsteriTcTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(287, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ListeBtn
            // 
            this.ListeBtn.BackColor = System.Drawing.Color.White;
            this.ListeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListeBtn.ImageIndex = 5;
            this.ListeBtn.ImageList = this.ımageList1;
            this.ListeBtn.Location = new System.Drawing.Point(17, 295);
            this.ListeBtn.Name = "ListeBtn";
            this.ListeBtn.Size = new System.Drawing.Size(101, 60);
            this.ListeBtn.TabIndex = 1;
            this.ListeBtn.Text = "Listele";
            this.ListeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListeBtn.UseVisualStyleBackColor = false;
            this.ListeBtn.Click += new System.EventHandler(this.ListeBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ara.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle.png");
            this.ımageList1.Images.SetKeyName(2, "images (3).jpg");
            this.ımageList1.Images.SetKeyName(3, "indir (5).jpg");
            this.ımageList1.Images.SetKeyName(4, "silme.png");
            this.ımageList1.Images.SetKeyName(5, "listele.png");
            // 
            // arananTxt
            // 
            this.arananTxt.Location = new System.Drawing.Point(659, 72);
            this.arananTxt.Name = "arananTxt";
            this.arananTxt.Size = new System.Drawing.Size(172, 22);
            this.arananTxt.TabIndex = 2;
            // 
            // araLbl
            // 
            this.araLbl.AutoSize = true;
            this.araLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.araLbl.Location = new System.Drawing.Point(535, 72);
            this.araLbl.Name = "araLbl";
            this.araLbl.Size = new System.Drawing.Size(107, 20);
            this.araLbl.TabIndex = 3;
            this.araLbl.Text = "Aranan Tc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "MAİL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "ADRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "TC";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(142, 146);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(139, 22);
            this.adtxt.TabIndex = 15;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(142, 183);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(139, 22);
            this.soyadTxt.TabIndex = 14;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(142, 257);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(139, 22);
            this.mailTxt.TabIndex = 13;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(142, 220);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(139, 22);
            this.adresTxt.TabIndex = 12;
            // 
            // TCtxt
            // 
            this.TCtxt.Location = new System.Drawing.Point(142, 109);
            this.TCtxt.Name = "TCtxt";
            this.TCtxt.Size = new System.Drawing.Size(139, 22);
            this.TCtxt.TabIndex = 11;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.White;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silBtn.ImageIndex = 4;
            this.silBtn.ImageList = this.ımageList1;
            this.silBtn.Location = new System.Drawing.Point(853, 12);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(74, 44);
            this.silBtn.TabIndex = 21;
            this.silBtn.Text = "SİL";
            this.silBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.White;
            this.iptalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptalBtn.ImageIndex = 2;
            this.iptalBtn.ImageList = this.ımageList1;
            this.iptalBtn.Location = new System.Drawing.Point(834, 375);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(92, 60);
            this.iptalBtn.TabIndex = 22;
            this.iptalBtn.Text = "ÇIKIŞ";
            this.iptalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // güncelBtn
            // 
            this.güncelBtn.BackColor = System.Drawing.Color.White;
            this.güncelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelBtn.ImageIndex = 1;
            this.güncelBtn.ImageList = this.ımageList1;
            this.güncelBtn.Location = new System.Drawing.Point(168, 295);
            this.güncelBtn.Name = "güncelBtn";
            this.güncelBtn.Size = new System.Drawing.Size(113, 60);
            this.güncelBtn.TabIndex = 23;
            this.güncelBtn.Text = "Güncelle";
            this.güncelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.güncelBtn.UseVisualStyleBackColor = false;
            this.güncelBtn.Click += new System.EventHandler(this.güncelBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.BackColor = System.Drawing.Color.White;
            this.araBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.araBtn.ImageIndex = 0;
            this.araBtn.ImageList = this.ımageList1;
            this.araBtn.Location = new System.Drawing.Point(852, 64);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(75, 39);
            this.araBtn.TabIndex = 24;
            this.araBtn.Text = "ARA";
            this.araBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(363, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Silmek istediğiniz müşteri Tc\'si:";
            // 
            // silinenMüsteriTcTxt
            // 
            this.silinenMüsteriTcTxt.Location = new System.Drawing.Point(659, 23);
            this.silinenMüsteriTcTxt.Name = "silinenMüsteriTcTxt";
            this.silinenMüsteriTcTxt.Size = new System.Drawing.Size(172, 22);
            this.silinenMüsteriTcTxt.TabIndex = 26;
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(938, 447);
            this.Controls.Add(this.silinenMüsteriTcTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.güncelBtn);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.TCtxt);
            this.Controls.Add(this.araLbl);
            this.Controls.Add(this.arananTxt);
            this.Controls.Add(this.ListeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Müşteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ListeBtn;
        private System.Windows.Forms.TextBox arananTxt;
        private System.Windows.Forms.Label araLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox TCtxt;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button güncelBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox silinenMüsteriTcTxt;
        private System.Windows.Forms.ImageList ımageList1;
    }
}