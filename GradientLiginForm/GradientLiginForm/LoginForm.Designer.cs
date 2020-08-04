namespace GradientLiginForm
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.alphaBlendTextBox3 = new ZBobb.AlphaBlendTextBox();
			this.alphaBlendTextBox2 = new ZBobb.AlphaBlendTextBox();
			this.bunifuGradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuGradientPanel1
			// 
			this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
			this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
			this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuGradientPanel1.Controls.Add(this.label1);
			this.bunifuGradientPanel1.Controls.Add(this.bunifuCheckbox1);
			this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
			this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
			this.bunifuGradientPanel1.Controls.Add(this.panel2);
			this.bunifuGradientPanel1.Controls.Add(this.panel1);
			this.bunifuGradientPanel1.Controls.Add(this.alphaBlendTextBox3);
			this.bunifuGradientPanel1.Controls.Add(this.alphaBlendTextBox2);
			this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.Gray;
			this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
			this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Violet;
			this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Violet;
			this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumPurple;
			this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
			this.bunifuGradientPanel1.Quality = 10;
			this.bunifuGradientPanel1.Size = new System.Drawing.Size(387, 558);
			this.bunifuGradientPanel1.TabIndex = 0;
			this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(72, 365);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Remember me";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// bunifuCheckbox1
			// 
			this.bunifuCheckbox1.BackColor = System.Drawing.Color.White;
			this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
			this.bunifuCheckbox1.ForeColor = System.Drawing.Color.DimGray;
			this.bunifuCheckbox1.Location = new System.Drawing.Point(41, 365);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 7;
			this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::GradientLiginForm.Properties.Resources.icons8_user_80;
			this.pictureBox2.Location = new System.Drawing.Point(41, 277);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 41);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::GradientLiginForm.Properties.Resources.icons8_user_80;
			this.pictureBox1.Location = new System.Drawing.Point(41, 179);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel2
			// 
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(41, 327);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 3);
			this.panel2.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(41, 233);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(320, 3);
			this.panel1.TabIndex = 3;
			// 
			// alphaBlendTextBox3
			// 
			this.alphaBlendTextBox3.BackAlpha = 0;
			this.alphaBlendTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.alphaBlendTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.alphaBlendTextBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alphaBlendTextBox3.ForeColor = System.Drawing.Color.White;
			this.alphaBlendTextBox3.Location = new System.Drawing.Point(76, 179);
			this.alphaBlendTextBox3.Multiline = true;
			this.alphaBlendTextBox3.Name = "alphaBlendTextBox3";
			this.alphaBlendTextBox3.Size = new System.Drawing.Size(289, 54);
			this.alphaBlendTextBox3.TabIndex = 2;
			this.alphaBlendTextBox3.Text = "Username";
			this.alphaBlendTextBox3.TextChanged += new System.EventHandler(this.alphaBlendTextBox3_TextChanged);
			// 
			// alphaBlendTextBox2
			// 
			this.alphaBlendTextBox2.BackAlpha = 0;
			this.alphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.alphaBlendTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.alphaBlendTextBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alphaBlendTextBox2.ForeColor = System.Drawing.Color.White;
			this.alphaBlendTextBox2.Location = new System.Drawing.Point(76, 277);
			this.alphaBlendTextBox2.Multiline = true;
			this.alphaBlendTextBox2.Name = "alphaBlendTextBox2";
			this.alphaBlendTextBox2.Size = new System.Drawing.Size(289, 53);
			this.alphaBlendTextBox2.TabIndex = 1;
			this.alphaBlendTextBox2.Text = "Password";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 558);
			this.Controls.Add(this.bunifuGradientPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Text = "Login Form";
			this.bunifuGradientPanel1.ResumeLayout(false);
			this.bunifuGradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ZBobb.AlphaBlendTextBox alphaBlendTextBox3;
		private ZBobb.AlphaBlendTextBox alphaBlendTextBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
		private System.Windows.Forms.Label label1;
	}
}

