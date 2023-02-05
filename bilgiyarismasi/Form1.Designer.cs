namespace bilgiyarismasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDogruSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblYanlisSayisi = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.PicDogru = new System.Windows.Forms.PictureBox();
            this.PicYanlis = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicDogru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYanlis)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(41, 173);
            this.BtnA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(215, 69);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(41, 250);
            this.BtnC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(215, 69);
            this.BtnC.TabIndex = 2;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(290, 173);
            this.BtnB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(215, 69);
            this.BtnB.TabIndex = 3;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(290, 250);
            this.BtnD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(215, 69);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Location = new System.Drawing.Point(647, 33);
            this.LblSoruNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(18, 20);
            this.LblSoruNo.TabIndex = 6;
            this.LblSoruNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru:";
            // 
            // LblDogruSayisi
            // 
            this.LblDogruSayisi.AutoSize = true;
            this.LblDogruSayisi.Location = new System.Drawing.Point(647, 73);
            this.LblDogruSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogruSayisi.Name = "LblDogruSayisi";
            this.LblDogruSayisi.Size = new System.Drawing.Size(18, 20);
            this.LblDogruSayisi.TabIndex = 8;
            this.LblDogruSayisi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yanlış:";
            // 
            // LblYanlisSayisi
            // 
            this.LblYanlisSayisi.AutoSize = true;
            this.LblYanlisSayisi.Location = new System.Drawing.Point(647, 111);
            this.LblYanlisSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYanlisSayisi.Name = "LblYanlisSayisi";
            this.LblYanlisSayisi.Size = new System.Drawing.Size(18, 20);
            this.LblYanlisSayisi.TabIndex = 10;
            this.LblYanlisSayisi.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(533, 139);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(215, 69);
            this.BtnSonraki.TabIndex = 11;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // PicDogru
            // 
            this.PicDogru.Image = ((System.Drawing.Image)(resources.GetObject("PicDogru.Image")));
            this.PicDogru.Location = new System.Drawing.Point(533, 224);
            this.PicDogru.Name = "PicDogru";
            this.PicDogru.Size = new System.Drawing.Size(96, 95);
            this.PicDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDogru.TabIndex = 12;
            this.PicDogru.TabStop = false;
            this.PicDogru.Visible = false;
            // 
            // PicYanlis
            // 
            this.PicYanlis.Image = ((System.Drawing.Image)(resources.GetObject("PicYanlis.Image")));
            this.PicYanlis.Location = new System.Drawing.Point(651, 224);
            this.PicYanlis.Name = "PicYanlis";
            this.PicYanlis.Size = new System.Drawing.Size(96, 95);
            this.PicYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicYanlis.TabIndex = 13;
            this.PicYanlis.TabStop = false;
            this.PicYanlis.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PicYanlis);
            this.Controls.Add(this.PicDogru);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.LblYanlisSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDogruSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)(this.PicDogru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYanlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDogruSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblYanlisSayisi;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox PicDogru;
        private System.Windows.Forms.PictureBox PicYanlis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

