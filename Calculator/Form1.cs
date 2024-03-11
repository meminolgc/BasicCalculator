using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private char _islem;
		bool _ekranTemizlenecekMi;
		int _ilkSayi;

		private void BtnNum1_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "1";
		}

		private void BtnNum2_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "2";
		}

		private void BtnNum3_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "3";
		}

		private void BtnNum4_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "4";
		}

		private void BtnNum5_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "5";
		}

		private void BtnNum6_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "6";
		}

		private void BtnNum7_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "7";
		}

		private void BtnNum8_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "8";
		}

		private void BtnNum9_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "9";
		}

		private void BtnNum0_Click(object sender, EventArgs e)
		{
			if (_ekranTemizlenecekMi)
			{
				LblEkran.Text = "";
				_ekranTemizlenecekMi = false;
			}
			if (LblEkran.Text == "0") LblEkran.Text = "";
			LblEkran.Text += "0";
		}

		private void BtnTopla_Click(object sender, EventArgs e)
		{
			_islem = '+';
			_ekranTemizlenecekMi = true;
			_ilkSayi = Convert.ToInt32(LblEkran.Text);
		}

		private void BtnEqual_Click(object sender, EventArgs e)
		{
			int ikinciSayi = Convert.ToInt32(LblEkran.Text);
			int sonuc;

			switch (_islem)
			{
				case '+':
					sonuc = _ilkSayi + ikinciSayi;
					break;
				case '-':
					sonuc = _ilkSayi - ikinciSayi;
					break;
				case '*':
					sonuc = _ilkSayi * ikinciSayi;
					break;
				case '/':
					sonuc = _ilkSayi / ikinciSayi;
					break;
				default:
					sonuc = 0; 
					break;

			}
			LblEkran.Text = Convert.ToString(sonuc);	
		}

		private void BtnCikar_Click(object sender, EventArgs e)
		{
			_islem = '-';
			_ekranTemizlenecekMi = true;
			_ilkSayi = Convert.ToInt32(LblEkran.Text);
		}

		private void BtnCarp_Click(object sender, EventArgs e)
		{
			_islem = '*';
			_ekranTemizlenecekMi = true;
			_ilkSayi = Convert.ToInt32(LblEkran.Text);
		}

		private void BtnBol_Click(object sender, EventArgs e)
		{
			_islem = '/';
			_ekranTemizlenecekMi = true;
			_ilkSayi = Convert.ToInt32(LblEkran.Text);
		}

		private void BtnC_Click(object sender, EventArgs e)
		{
			LblEkran.Text = "0";
		}
	}
}
