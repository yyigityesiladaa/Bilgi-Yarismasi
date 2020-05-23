namespace BilgiYarismasi
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblPasSayısı = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblYanlisSayisi = new System.Windows.Forms.Label();
			this.lblDogruSayisi = new System.Windows.Forms.Label();
			this.lblSoruSayisi = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnA = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.Button();
			this.green = new System.Windows.Forms.PictureBox();
			this.red = new System.Windows.Forms.PictureBox();
			this.question = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBasla = new System.Windows.Forms.Button();
			this.btnSonraki = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.lblQ = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerPanel = new System.Windows.Forms.Panel();
			this.saniyee = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dakikaa = new System.Windows.Forms.Label();
			this.btnYariJoker = new System.Windows.Forms.Button();
			this.btnPas = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.lblPasHakkı = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.timerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblPasSayısı);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.lblYanlisSayisi);
			this.groupBox1.Controls.Add(this.lblDogruSayisi);
			this.groupBox1.Controls.Add(this.lblSoruSayisi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(665, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(279, 212);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Durum Tablosu";
			this.groupBox1.Visible = false;
			// 
			// lblPasSayısı
			// 
			this.lblPasSayısı.AutoSize = true;
			this.lblPasSayısı.Location = new System.Drawing.Point(176, 178);
			this.lblPasSayısı.Name = "lblPasSayısı";
			this.lblPasSayısı.Size = new System.Drawing.Size(19, 24);
			this.lblPasSayısı.TabIndex = 7;
			this.lblPasSayısı.Text = "0";
			this.lblPasSayısı.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(37, 178);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 24);
			this.label9.TabIndex = 6;
			this.label9.Text = "Pas Sayısı:";
			this.label9.Visible = false;
			// 
			// lblYanlisSayisi
			// 
			this.lblYanlisSayisi.AutoSize = true;
			this.lblYanlisSayisi.Location = new System.Drawing.Point(176, 130);
			this.lblYanlisSayisi.Name = "lblYanlisSayisi";
			this.lblYanlisSayisi.Size = new System.Drawing.Size(19, 24);
			this.lblYanlisSayisi.TabIndex = 5;
			this.lblYanlisSayisi.Text = "0";
			this.lblYanlisSayisi.Visible = false;
			// 
			// lblDogruSayisi
			// 
			this.lblDogruSayisi.AutoSize = true;
			this.lblDogruSayisi.Location = new System.Drawing.Point(176, 85);
			this.lblDogruSayisi.Name = "lblDogruSayisi";
			this.lblDogruSayisi.Size = new System.Drawing.Size(19, 24);
			this.lblDogruSayisi.TabIndex = 4;
			this.lblDogruSayisi.Text = "0";
			this.lblDogruSayisi.Visible = false;
			// 
			// lblSoruSayisi
			// 
			this.lblSoruSayisi.AutoSize = true;
			this.lblSoruSayisi.Location = new System.Drawing.Point(176, 43);
			this.lblSoruSayisi.Name = "lblSoruSayisi";
			this.lblSoruSayisi.Size = new System.Drawing.Size(19, 24);
			this.lblSoruSayisi.TabIndex = 3;
			this.lblSoruSayisi.Text = "0";
			this.lblSoruSayisi.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Yanlış Sayısı:";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Doğru Sayısı:";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Soru Sayısı: ";
			this.label1.Visible = false;
			// 
			// btnA
			// 
			this.btnA.Enabled = false;
			this.btnA.Location = new System.Drawing.Point(33, 423);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(211, 72);
			this.btnA.TabIndex = 2;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Visible = false;
			this.btnA.Click += new System.EventHandler(this.btnA_Click);
			// 
			// btnB
			// 
			this.btnB.Enabled = false;
			this.btnB.Location = new System.Drawing.Point(357, 423);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(211, 72);
			this.btnB.TabIndex = 3;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Visible = false;
			this.btnB.Click += new System.EventHandler(this.btnB_Click);
			// 
			// btnC
			// 
			this.btnC.Enabled = false;
			this.btnC.Location = new System.Drawing.Point(33, 520);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(211, 72);
			this.btnC.TabIndex = 4;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Visible = false;
			this.btnC.Click += new System.EventHandler(this.btnC_Click);
			// 
			// btnD
			// 
			this.btnD.Enabled = false;
			this.btnD.Location = new System.Drawing.Point(357, 520);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(211, 72);
			this.btnD.TabIndex = 5;
			this.btnD.Text = "D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.Visible = false;
			this.btnD.Click += new System.EventHandler(this.btnD_Click);
			// 
			// green
			// 
			this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
			this.green.Location = new System.Drawing.Point(706, 398);
			this.green.Name = "green";
			this.green.Size = new System.Drawing.Size(204, 194);
			this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.green.TabIndex = 6;
			this.green.TabStop = false;
			this.green.Visible = false;
			// 
			// red
			// 
			this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
			this.red.Location = new System.Drawing.Point(706, 398);
			this.red.Name = "red";
			this.red.Size = new System.Drawing.Size(204, 194);
			this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.red.TabIndex = 7;
			this.red.TabStop = false;
			this.red.Visible = false;
			// 
			// question
			// 
			this.question.Image = ((System.Drawing.Image)(resources.GetObject("question.Image")));
			this.question.Location = new System.Drawing.Point(706, 398);
			this.question.Name = "question";
			this.question.Size = new System.Drawing.Size(204, 194);
			this.question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.question.TabIndex = 8;
			this.question.TabStop = false;
			this.question.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Location = new System.Drawing.Point(12, 14);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(976, 74);
			this.panel1.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(150, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(796, 46);
			this.label10.TabIndex = 6;
			this.label10.Text = "Görsel Programlama Arasınav Ödevi - Bilgi Yarışması";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(12, 610);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(976, 53);
			this.panel2.TabIndex = 10;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(33, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 29);
			this.label8.TabIndex = 4;
			this.label8.Text = "Ad - Soyad:";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(355, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(147, 29);
			this.label7.TabIndex = 3;
			this.label7.Text = "Okul Numarası:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(648, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(321, 29);
			this.label6.TabIndex = 2;
			this.label6.Text = "Bolu Abant İzzet Baysal Üniversitesi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(494, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 29);
			this.label5.TabIndex = 1;
			this.label5.Text = "171906052";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(138, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Yakup Yiğit Yeşilada";
			// 
			// btnBasla
			// 
			this.btnBasla.Location = new System.Drawing.Point(357, 545);
			this.btnBasla.Name = "btnBasla";
			this.btnBasla.Size = new System.Drawing.Size(261, 59);
			this.btnBasla.TabIndex = 11;
			this.btnBasla.Text = "Başla";
			this.btnBasla.UseVisualStyleBackColor = true;
			this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
			// 
			// btnSonraki
			// 
			this.btnSonraki.Enabled = false;
			this.btnSonraki.Location = new System.Drawing.Point(665, 330);
			this.btnSonraki.Name = "btnSonraki";
			this.btnSonraki.Size = new System.Drawing.Size(279, 62);
			this.btnSonraki.TabIndex = 12;
			this.btnSonraki.Text = "Sonraki Soru";
			this.btnSonraki.UseVisualStyleBackColor = true;
			this.btnSonraki.Visible = false;
			this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(157, 94);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(678, 445);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// lblQ
			// 
			this.lblQ.AutoSize = true;
			this.lblQ.Location = new System.Drawing.Point(151, 268);
			this.lblQ.Name = "lblQ";
			this.lblQ.Size = new System.Drawing.Size(52, 24);
			this.lblQ.TabIndex = 13;
			this.lblQ.Text = "label4";
			this.lblQ.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timerPanel
			// 
			this.timerPanel.BackColor = System.Drawing.Color.DarkRed;
			this.timerPanel.Controls.Add(this.saniyee);
			this.timerPanel.Controls.Add(this.label11);
			this.timerPanel.Controls.Add(this.dakikaa);
			this.timerPanel.Location = new System.Drawing.Point(12, 94);
			this.timerPanel.Name = "timerPanel";
			this.timerPanel.Size = new System.Drawing.Size(171, 52);
			this.timerPanel.TabIndex = 14;
			this.timerPanel.Visible = false;
			// 
			// saniyee
			// 
			this.saniyee.AutoSize = true;
			this.saniyee.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.saniyee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.saniyee.Location = new System.Drawing.Point(117, 0);
			this.saniyee.Name = "saniyee";
			this.saniyee.Size = new System.Drawing.Size(47, 57);
			this.saniyee.TabIndex = 7;
			this.saniyee.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new System.Drawing.Point(75, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(36, 57);
			this.label11.TabIndex = 6;
			this.label11.Text = ":";
			// 
			// dakikaa
			// 
			this.dakikaa.AutoSize = true;
			this.dakikaa.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dakikaa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dakikaa.Location = new System.Drawing.Point(22, 0);
			this.dakikaa.Name = "dakikaa";
			this.dakikaa.Size = new System.Drawing.Size(47, 57);
			this.dakikaa.TabIndex = 5;
			this.dakikaa.Text = "0";
			// 
			// btnYariJoker
			// 
			this.btnYariJoker.Location = new System.Drawing.Point(22, 226);
			this.btnYariJoker.Name = "btnYariJoker";
			this.btnYariJoker.Size = new System.Drawing.Size(80, 56);
			this.btnYariJoker.TabIndex = 15;
			this.btnYariJoker.Text = "50:50";
			this.btnYariJoker.UseVisualStyleBackColor = true;
			this.btnYariJoker.Visible = false;
			this.btnYariJoker.Click += new System.EventHandler(this.yariJoker_Click);
			// 
			// btnPas
			// 
			this.btnPas.Location = new System.Drawing.Point(22, 300);
			this.btnPas.Name = "btnPas";
			this.btnPas.Size = new System.Drawing.Size(80, 56);
			this.btnPas.TabIndex = 16;
			this.btnPas.Text = "Pas";
			this.btnPas.UseVisualStyleBackColor = true;
			this.btnPas.Visible = false;
			this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(23, 368);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(136, 24);
			this.label12.TabIndex = 17;
			this.label12.Text = "Kalan Pas Hakkı:";
			this.label12.Visible = false;
			// 
			// lblPasHakkı
			// 
			this.lblPasHakkı.AutoSize = true;
			this.lblPasHakkı.Location = new System.Drawing.Point(151, 368);
			this.lblPasHakkı.Name = "lblPasHakkı";
			this.lblPasHakkı.Size = new System.Drawing.Size(19, 24);
			this.lblPasHakkı.TabIndex = 8;
			this.lblPasHakkı.Text = "3";
			this.lblPasHakkı.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 675);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblPasHakkı);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnPas);
			this.Controls.Add(this.btnYariJoker);
			this.Controls.Add(this.timerPanel);
			this.Controls.Add(this.lblQ);
			this.Controls.Add(this.btnSonraki);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.question);
			this.Controls.Add(this.red);
			this.Controls.Add(this.green);
			this.Controls.Add(this.btnD);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnBasla);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.timerPanel.ResumeLayout(false);
			this.timerPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblYanlisSayisi;
		private System.Windows.Forms.Label lblDogruSayisi;
		private System.Windows.Forms.Label lblSoruSayisi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnD;
		private System.Windows.Forms.PictureBox green;
		private System.Windows.Forms.PictureBox red;
		private System.Windows.Forms.PictureBox question;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBasla;
		private System.Windows.Forms.Button btnSonraki;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label lblQ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel timerPanel;
		private System.Windows.Forms.Label saniyee;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label dakikaa;
		private System.Windows.Forms.Button btnYariJoker;
		private System.Windows.Forms.Button btnPas;
		private System.Windows.Forms.Label lblPasSayısı;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblPasHakkı;
	}
}

