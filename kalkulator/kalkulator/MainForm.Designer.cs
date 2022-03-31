/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/1/2022
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kalkulator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_tambah;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lablel3;
		private System.Windows.Forms.TextBox txt_bil1;
		private System.Windows.Forms.TextBox txt_bil2;
		private System.Windows.Forms.TextBox txt_hasil;
		private System.Windows.Forms.Button btn_kurang;
		private System.Windows.Forms.Button btn_kali;
		private System.Windows.Forms.Button btn_bagi;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_tambah = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_bil1 = new System.Windows.Forms.TextBox();
			this.txt_bil2 = new System.Windows.Forms.TextBox();
			this.lablel3 = new System.Windows.Forms.Label();
			this.txt_hasil = new System.Windows.Forms.TextBox();
			this.btn_kurang = new System.Windows.Forms.Button();
			this.btn_kali = new System.Windows.Forms.Button();
			this.btn_bagi = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_tambah
			// 
			this.btn_tambah.Location = new System.Drawing.Point(59, 209);
			this.btn_tambah.Name = "btn_tambah";
			this.btn_tambah.Size = new System.Drawing.Size(75, 23);
			this.btn_tambah.TabIndex = 0;
			this.btn_tambah.Text = "+";
			this.btn_tambah.UseVisualStyleBackColor = true;
			this.btn_tambah.Click += new System.EventHandler(this.Btn_tambahClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Angka 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Angka 2";
			// 
			// txt_bil1
			// 
			this.txt_bil1.Location = new System.Drawing.Point(138, 62);
			this.txt_bil1.Name = "txt_bil1";
			this.txt_bil1.Size = new System.Drawing.Size(100, 22);
			this.txt_bil1.TabIndex = 6;
			// 
			// txt_bil2
			// 
			this.txt_bil2.Location = new System.Drawing.Point(138, 102);
			this.txt_bil2.Name = "txt_bil2";
			this.txt_bil2.Size = new System.Drawing.Size(100, 22);
			this.txt_bil2.TabIndex = 7;
			// 
			// lablel3
			// 
			this.lablel3.Location = new System.Drawing.Point(32, 144);
			this.lablel3.Name = "lablel3";
			this.lablel3.Size = new System.Drawing.Size(100, 23);
			this.lablel3.TabIndex = 8;
			this.lablel3.Text = "Hasil";
			// 
			// txt_hasil
			// 
			this.txt_hasil.Location = new System.Drawing.Point(138, 141);
			this.txt_hasil.Name = "txt_hasil";
			this.txt_hasil.Size = new System.Drawing.Size(100, 22);
			this.txt_hasil.TabIndex = 9;
			// 
			// btn_kurang
			// 
			this.btn_kurang.Location = new System.Drawing.Point(188, 209);
			this.btn_kurang.Name = "btn_kurang";
			this.btn_kurang.Size = new System.Drawing.Size(75, 23);
			this.btn_kurang.TabIndex = 10;
			this.btn_kurang.Text = "-";
			this.btn_kurang.UseVisualStyleBackColor = true;
			this.btn_kurang.Click += new System.EventHandler(this.Btn_kurangClick);
			// 
			// btn_kali
			// 
			this.btn_kali.Location = new System.Drawing.Point(59, 273);
			this.btn_kali.Name = "btn_kali";
			this.btn_kali.Size = new System.Drawing.Size(75, 23);
			this.btn_kali.TabIndex = 11;
			this.btn_kali.Text = "x";
			this.btn_kali.UseVisualStyleBackColor = true;
			this.btn_kali.Click += new System.EventHandler(this.Btn_kaliClick);
			// 
			// btn_bagi
			// 
			this.btn_bagi.Location = new System.Drawing.Point(188, 273);
			this.btn_bagi.Name = "btn_bagi";
			this.btn_bagi.Size = new System.Drawing.Size(75, 23);
			this.btn_bagi.TabIndex = 12;
			this.btn_bagi.Text = "/";
			this.btn_bagi.UseVisualStyleBackColor = true;
			this.btn_bagi.Click += new System.EventHandler(this.Btn_bagiClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 28);
			this.label4.TabIndex = 13;
			this.label4.Text = "Kalkulator";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 443);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_bagi);
			this.Controls.Add(this.btn_kali);
			this.Controls.Add(this.btn_kurang);
			this.Controls.Add(this.txt_hasil);
			this.Controls.Add(this.lablel3);
			this.Controls.Add(this.txt_bil2);
			this.Controls.Add(this.txt_bil1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_tambah);
			this.Name = "MainForm";
			this.Text = "kalkulator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
