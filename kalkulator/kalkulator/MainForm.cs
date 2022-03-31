/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/1/2022
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kalkulator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		} 
		void Btn_tambahClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1+bil2;
			txt_hasil.Text = hasil.ToString();
		}
		void Btn_kurangClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1-bil2;
			txt_hasil.Text = hasil.ToString();
		}
		void Btn_kaliClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1*bil2;
			txt_hasil.Text = hasil.ToString();
		}
		void Btn_bagiClick(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1/bil2;
			txt_hasil.Text = hasil.ToString();
		}
	}
}
