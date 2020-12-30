namespace VeriTabaniProje
{
    partial class Satislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satislar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toplamKazanTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kazancBtn = new System.Windows.Forms.Button();
            this.satislarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // toplamKazanTxt
            // 
            this.toplamKazanTxt.Location = new System.Drawing.Point(435, 261);
            this.toplamKazanTxt.Name = "toplamKazanTxt";
            this.toplamKazanTxt.Size = new System.Drawing.Size(149, 22);
            this.toplamKazanTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOPLAM KAZANÇ:";
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.White;
            this.cikisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisBtn.ImageIndex = 0;
            this.cikisBtn.ImageList = this.ımageList1;
            this.cikisBtn.Location = new System.Drawing.Point(679, 305);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(109, 56);
            this.cikisBtn.TabIndex = 3;
            this.cikisBtn.Text = "ÇIKIŞ";
            this.cikisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptallll.jpg");
            this.ımageList1.Images.SetKeyName(1, "kazanc.jpg");
            this.ımageList1.Images.SetKeyName(2, "satislar.png");
            // 
            // kazancBtn
            // 
            this.kazancBtn.BackColor = System.Drawing.Color.White;
            this.kazancBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kazancBtn.ImageIndex = 1;
            this.kazancBtn.ImageList = this.ımageList1;
            this.kazancBtn.Location = new System.Drawing.Point(36, 305);
            this.kazancBtn.Name = "kazancBtn";
            this.kazancBtn.Size = new System.Drawing.Size(271, 56);
            this.kazancBtn.TabIndex = 4;
            this.kazancBtn.Text = "TOPLAM KAZANCI GÖSTER";
            this.kazancBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kazancBtn.UseVisualStyleBackColor = false;
            this.kazancBtn.Click += new System.EventHandler(this.kazancBtn_Click);
            // 
            // satislarBtn
            // 
            this.satislarBtn.BackColor = System.Drawing.Color.White;
            this.satislarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.satislarBtn.ImageIndex = 2;
            this.satislarBtn.ImageList = this.ımageList1;
            this.satislarBtn.Location = new System.Drawing.Point(364, 305);
            this.satislarBtn.Name = "satislarBtn";
            this.satislarBtn.Size = new System.Drawing.Size(220, 56);
            this.satislarBtn.TabIndex = 5;
            this.satislarBtn.Text = "SATIŞLARI LİSTELE";
            this.satislarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.satislarBtn.UseVisualStyleBackColor = false;
            this.satislarBtn.Click += new System.EventHandler(this.satislarBtn_Click);
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 382);
            this.Controls.Add(this.satislarBtn);
            this.Controls.Add(this.kazancBtn);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toplamKazanTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAPILAN SATIŞLAR";
            this.Load += new System.EventHandler(this.Satislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox toplamKazanTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button kazancBtn;
        private System.Windows.Forms.Button satislarBtn;
    }
}