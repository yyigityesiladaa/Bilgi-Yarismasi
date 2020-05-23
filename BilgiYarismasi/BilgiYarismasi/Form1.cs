using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruNo = 0, dogru = 0, yanlis = 0;
		int dakika = 0, saniye = 0;

		private void btnA_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			saniye = 0;
			dakika = 0;
			
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnYariJoker.Enabled = false;
			btnPas.Enabled = false;
			btnSonraki.Enabled = true;

			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{
				btnA.BackColor = Color.Green;
				btnA.ForeColor = Color.White;
				green.Visible = true;
				question.Visible = false;
				dogru++;
			}


			else if (soruNo == 1 || soruNo == 8)
			{
				btnB.BackColor = Color.Green;
				btnB.ForeColor = Color.White;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnD.BackColor = Color.Green;
				btnD.ForeColor = Color.White;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 11)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
				MessageBox.Show("Maalesef Altın Soruyu Yanlış Cevapladınız ve Yarışmayı Kaybettiniz!!!");
				Environment.Exit(0);
			}

		}

		private void btnB_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			saniye = 0;
			dakika = 0;
			
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnYariJoker.Enabled = false;
			btnPas.Enabled = false;
			btnSonraki.Enabled = true;

			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{
				btnA.BackColor = Color.Green;
				btnA.ForeColor = Color.White;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}


			else if (soruNo == 1 || soruNo == 8)
			{
				btnB.BackColor = Color.Green;
				btnB.ForeColor = Color.White;
				green.Visible = true;
				question.Visible = false;
				dogru++;
			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnD.BackColor = Color.Green;
				btnD.ForeColor = Color.White;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 11)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
				MessageBox.Show("Maalesef Altın Soruyu Yanlış Cevapladınız ve Yarışmayı Kaybettiniz!!!");
				Environment.Exit(0);
			}


		}

		private void btnC_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			saniye = 0;
			dakika = 0;
			
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnYariJoker.Enabled = false;
			btnPas.Enabled = false;
			btnSonraki.Enabled = true;

			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{
				btnA.BackColor = Color.Green;
				btnA.ForeColor = Color.White;
				btnC.BackColor = Color.Red;
				btnC.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}


			else if (soruNo == 1 || soruNo == 8)
			{
				btnB.BackColor = Color.Green;
				btnB.ForeColor = Color.White;
				btnC.BackColor = Color.Red;
				btnC.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				green.Visible = true;
				question.Visible = false;
				dogru++;
			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnD.BackColor = Color.Green;
				btnD.ForeColor = Color.White;
				btnC.BackColor = Color.Red;
				btnC.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 11)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				green.Visible = true;
				question.Visible = false;
				dogru++;
				MessageBox.Show("TEBRİKLER! Altın Soruyu Doğru Cevapladınız ve Yarışmayı Kazandınız!!!");
				Environment.Exit(0);
			}

		}

		private void btnD_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			saniye = 0;
			dakika = 0;
			
			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnYariJoker.Enabled = false;
			btnPas.Enabled = false;
			btnSonraki.Enabled = true;

			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{
				btnA.BackColor = Color.Green;
				btnA.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}
			
			
			else if (soruNo == 1 || soruNo == 8)
			{
				btnB.BackColor = Color.Green;
				btnB.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnD.BackColor = Color.Green;
				btnD.ForeColor = Color.White;
				green.Visible = true;
				question.Visible = false;
				red.Visible = true;
				question.Visible = false;
				dogru++;
			}

			else if(soruNo == 11)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;
				red.Visible = true;
				question.Visible = false;
				yanlis++;
				MessageBox.Show("Maalesef Altın Soruyu Yanlış Cevapladınız ve Yarışmayı Kaybettiniz!!!");
				Environment.Exit(0);
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			saniye++;
			saniyee.Text = saniye.ToString();
			if (saniye == 60)
			{
				dakika++;
				dakikaa.Text = dakika.ToString();
				saniye = 0;
			}

			if(dakika > 1)
			{
				
				timer1.Stop();
				saniye = 0;
				dakika = 0;
				if(soruNo != 11)
				{
					MessageBox.Show("Bu Soru İçin Süre Hakkınızı Doldurdunuz... Sonraki Soruya Geçmek İçin Önce" +
					" 'Tamam' Butonuna Daha Sonra 'Sonraki' Butonuna Tıklayın!!!");
				}
				
				yanlis++;
				btnA.Enabled = false;
				btnB.Enabled = false;
				btnC.Enabled = false;
				btnD.Enabled = false;
				btnSonraki.Enabled = true;


				if (soruNo == 4 || soruNo == 5 || soruNo == 10)
				{
					btnA.BackColor = Color.Green;
					btnA.ForeColor = Color.White;
					red.Visible = true;
					question.Visible = false;
					yanlis++;
				}


				else if (soruNo == 1 || soruNo == 8)
				{
					btnB.BackColor = Color.Green;
					btnB.ForeColor = Color.White;
					red.Visible = true;
					question.Visible = false;
					yanlis++;
				}

				else if (soruNo == 6 || soruNo == 9)
				{
					btnC.BackColor = Color.Green;
					btnC.ForeColor = Color.White;
					red.Visible = true;
					question.Visible = false;
					yanlis++;
				}

				else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
				{
					btnD.BackColor = Color.Green;
					btnD.ForeColor = Color.White;
					green.Visible = true;
					question.Visible = false;
					red.Visible = true;
					question.Visible = false;
					dogru++;
				}

				else if (soruNo == 11)
				{
					btnC.BackColor = Color.Green;
					btnC.ForeColor = Color.White;
					red.Visible = true;
					question.Visible = false;
					yanlis++;
					MessageBox.Show("Maalesef Altın Soruda Süreyi Aştınız ve Yarışmayı Kaybettiniz!!!");
					Environment.Exit(0);
				}

			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			
		}
		int yariJokerHakki = 1;
		private void yariJoker_Click(object sender, EventArgs e)
		{
			yariJokerHakki--;
			btnYariJoker.Enabled = false;
			
			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{

				btnC.Enabled = false;
				btnD.Enabled = false;
				btnC.BackColor = Color.Red;
				btnC.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;


			}


			else if (soruNo == 1 || soruNo == 8)
			{
				btnA.Enabled = false;
				btnD.Enabled = false;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;

			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnA.Enabled = false;
				btnB.Enabled = false;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;

			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnB.Enabled = false;
				btnC.Enabled = false;
				btnB.BackColor = Color.Red;
				btnB.ForeColor = Color.White;
				btnC.BackColor = Color.Red;
				btnC.ForeColor = Color.White;

			}

			else if (soruNo == 11)
			{
				btnA.Enabled = false;
				btnD.Enabled = false;
				btnA.BackColor = Color.Red;
				btnA.ForeColor = Color.White;
				btnD.BackColor = Color.Red;
				btnD.ForeColor = Color.White;
			}

			if(soruNo == 11)
			{
				btnYariJoker.Enabled = false;
			}
		}
		int pasSayısı = 0, pasHakkı = 3;
		private void btnPas_Click(object sender, EventArgs e)
		{
			btnYariJoker.Enabled = false;
			btnPas.Enabled = false;
			pasSayısı++;
			pasHakkı--;
			lblPasHakkı.Text = pasHakkı.ToString();

			if (soruNo == 4 || soruNo == 5 || soruNo == 10)
			{
				btnA.BackColor = Color.Green;
				btnA.ForeColor = Color.White;

			}


			else if (soruNo == 1 || soruNo == 8)
			{
				btnB.BackColor = Color.Green;
				btnB.ForeColor = Color.White;

			}

			else if (soruNo == 6 || soruNo == 9)
			{
				btnC.BackColor = Color.Green;
				btnC.ForeColor = Color.White;

			}

			else if (soruNo == 2 || soruNo == 3 || soruNo == 7)
			{
				btnD.BackColor = Color.Green;
				btnD.ForeColor = Color.White;

			}


			btnA.Enabled = false;
			btnB.Enabled = false;
			btnC.Enabled = false;
			btnD.Enabled = false;
			btnSonraki.Enabled = true;
			timer1.Stop();
			MessageBox.Show("Pas Hakkınızı Kullandınız. Bir Sonraki Soruya Geçmek İçin 'Sonraki Soru' Butonuna Tıklayın!");
			
			dakika = 0;
			saniye = 0;
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void btnBasla_Click(object sender, EventArgs e)
		{
			btnPas.Visible = true;
			btnYariJoker.Visible = true;
			timer1.Start();
			panel1.BackColor = Color.DarkRed;
			panel2.BackColor = Color.DarkRed;
			timerPanel.Visible = true;
			btnBasla.Visible = false;
			richTextBox1.Visible = false;
			btnSonraki.Visible = true;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label12.Visible = true;
			label9.Visible = true;
			lblPasSayısı.Visible = true;
			lblPasHakkı.Visible = true;
			lblSoruSayisi.Text = soruNo.ToString();
			btnA.Visible = true;
			btnB.Visible = true;
			btnC.Visible = true;
			btnD.Visible = true;
			lblDogruSayisi.Visible = true;
			lblQ.Visible = true;
			lblSoruSayisi.Visible = true;
			lblYanlisSayisi.Visible = true;
			question.Visible = true;
			panel1.Visible = true;
			panel2.Visible = true;
			groupBox1.Visible = true;
			btnA.Enabled = true;
			btnB.Enabled = true;
			btnC.Enabled = true;
			btnD.Enabled = true;
			soruNo++;
			btnA.BackColor = default;
			btnB.BackColor = default;
			btnC.BackColor = default;
			btnD.BackColor = default;

			lblSoruSayisi.Text = soruNo.ToString();

			if (soruNo == 1)
			{
				lblQ.Text = "Dünya'nın İlk Dijital Müzesi Nerededir?";
				btnA.Text = "Çin";
				btnB.Text = "Japonya"; //True Answer
				btnC.Text = "Fransa";
				btnD.Text = "Amerika";
			}
		}

		private void btnSonraki_Click(object sender, EventArgs e)
		{
			btnYariJoker.Enabled = false;
			lblPasSayısı.Text = pasSayısı.ToString();
			saniye = 0;
			dakika = 0;
			lblPasSayısı.Text = pasSayısı.ToString();
			btnYariJoker.Enabled = true;
			btnPas.Enabled = true;
			saniyee.Text = saniye.ToString();
			dakikaa.Text = dakika.ToString();
			timer1.Start();
			btnA.Enabled = true;
			btnB.Enabled = true;
			btnC.Enabled = true;
			btnD.Enabled = true;
			green.Visible = false;
			red.Visible = false;
			question.Visible = true;

			//Default Option Button Colors
			btnSonraki.Enabled = false;
			btnA.BackColor = default;
			btnA.ForeColor = Color.Black;
			btnB.BackColor = default;
			btnB.ForeColor = Color.Black;
			btnC.BackColor = default;
			btnC.ForeColor = Color.Black;
			btnD.BackColor = default;
			btnD.ForeColor = Color.Black;
			soruNo++;
			lblDogruSayisi.Text = dogru.ToString();
			lblYanlisSayisi.Text = yanlis.ToString();
			lblSoruSayisi.Text = soruNo.ToString();

			if(yariJokerHakki < 1)
			{
				btnYariJoker.Enabled = false;
			}

			if (soruNo == 11)
			{
				btnPas.Enabled = false;
				pasHakkı = 0;
				label12.Text = "Altın Soruda Pas Hakkı Kullanılamaz!";
				lblPasHakkı.Visible = false;


			}

			if (pasHakkı == 0)
			{
				btnPas.Enabled = false;
			}
			

			//Questions
			if(soruNo == 2)
			{
				lblQ.Text = "Dünya'nın En Eski Fosil Çiçeği Nerede Bulunmuştur?";
				btnA.Text = "Türkiye";
				btnB.Text = "Bulgaristan";
				btnC.Text = "Fransa";
				btnD.Text = "Çin"; //True Answer

			}

			if (soruNo == 3)
			{
				lblQ.Text = "Dünya'nın En Sıcak Yeri Neresidir?";
				btnA.Text = "Şam";
				btnB.Text = "Kahire";
				btnC.Text = "Kazablanka";
				btnD.Text = "El Aziziye"; //True Answer
			}

			if (soruNo == 4)
			{
				lblQ.Text = "Dünya'nın İlk Kütüphanesini Hangi Devlet Kurmuştur?";
				btnA.Text = "Asur"; //True Answer
				btnB.Text = "Sümer";
				btnC.Text = "Artuklu";
				btnD.Text = "Uygur";
			}

			if (soruNo == 5)
			{
				lblQ.Text = "Dünya'nın En Uzun Romanı Hangisidir?";
				btnA.Text = "Artamene"; //True Answer
				btnB.Text = "Suç ve Ceza";
				btnC.Text = "Sonsuz Jest";
				btnD.Text = "Clarissa";
			}

			if (soruNo == 6)
			{
				lblQ.Text = "Dünya'nın En Uzun Romanının Yazarı Kimdir?";
				btnA.Text = "Tolstoy";
				btnB.Text = "Dostoyevski"; 
				btnC.Text = "Medeleine"; //True Answer
				btnD.Text = "Albert Camus";
			}

			if (soruNo == 7)
			{
				lblQ.Text = "Vladimir Nabokov'un Uydurduğu Kelime Hangisidir?";
				btnA.Text = "Yosla";
				btnB.Text = "Koska";
				btnC.Text = "Dorza"; 
				btnD.Text = "Toska"; //True Answer
			}

			if (soruNo == 8)
			{
				lblQ.Text = "Istakozların Kanı Ne Renktir?";
				btnA.Text = "Mor";
				btnB.Text = "Mavi"; //True Answer
				btnC.Text = "Kırmızı";
				btnD.Text = "Turuncu"; 
			}

			if (soruNo == 9)
			{
				lblQ.Text = "Dünya'nın İlk Anayasası Hangi Yıl ve Ülkede Kabul Edlmiştir?";
				btnA.Text = "1221 / Fransa";
				btnB.Text = "1211 / İtalya";
				btnC.Text = "1215 / İngiltere"; //True Answer
				btnD.Text = "1213 / Hollanda"; 
			}

			if (soruNo == 10)
			{
				lblQ.Text = "Fransız İhtilali Hangi Yıllar Arasında Gerçekleşmiştir?";
				btnA.Text = "1789 - 1799"; //True Answer
				btnB.Text = "1768 - 1787";
				btnC.Text = "1876 - 1889";
				btnD.Text = "1910 - 1921";
			}


			
			if (soruNo > 10)
			{
				if (dogru > yanlis)
				{
					btnA.Visible = false;
					btnB.Visible = false;
					btnC.Visible = false;
					btnD.Visible = false;
					btnSonraki.Visible = false;
					lblDogruSayisi.Visible = false;
					lblQ.Visible = false;
					lblSoruSayisi.Visible = false;
					lblYanlisSayisi.Visible = false;
					soruNo = 0;
					dogru = 0;
					yanlis = 0;
					//soruPaneli.Visible = false;
					red.Visible = false;
					green.Visible = false;
					question.Visible = false;
					groupBox1.Visible = false;
					panel1.Visible = false;
					panel2.Visible = false;
					btnBasla.Visible = false;
					MessageBox.Show("Tebrikler, Yarışmayı Kazandınız !");

					Environment.Exit(0);
				}
				else if (yanlis > dogru)
				{
					MessageBox.Show("Maalesef Yarışmayı Kaybettiniz !");
					Environment.Exit(0);
				}

				else if (yanlis == dogru)
				{
					MessageBox.Show("Doğru ve Yanlış Sayınız Eşit. Altın Soruya Geçtiniz");

					lblQ.Text = "Hangi Şehir İskandinavya'da Değildir?";
					btnA.Text = "Kopenhag";
					btnB.Text = "Göteborg";
					btnC.Text = "Reykjavik"; //True Answer
					btnD.Text = "Oslo";
					
				}
			}
		}
	}
}
