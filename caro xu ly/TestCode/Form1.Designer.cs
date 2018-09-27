namespace GameCaro
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
			this.pnlChessBoard = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pctbAvatar = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pctbMark = new System.Windows.Forms.PictureBox();
			this.txbPlayerName = new System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlChessBoard
			// 
			this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
			this.pnlChessBoard.Location = new System.Drawing.Point(16, 15);
			this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
			this.pnlChessBoard.Name = "pnlChessBoard";
			this.pnlChessBoard.Size = new System.Drawing.Size(1045, 732);
			this.pnlChessBoard.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.pctbAvatar);
			this.panel2.Location = new System.Drawing.Point(1069, 15);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(359, 331);
			this.panel2.TabIndex = 1;
			// 
			// pctbAvatar
			// 
			this.pctbAvatar.BackColor = System.Drawing.SystemColors.Control;
			this.pctbAvatar.BackgroundImage = global::TestCode.Properties.Resources.BG_caro;
			this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pctbAvatar.Location = new System.Drawing.Point(4, 4);
			this.pctbAvatar.Margin = new System.Windows.Forms.Padding(4);
			this.pctbAvatar.Name = "pctbAvatar";
			this.pctbAvatar.Size = new System.Drawing.Size(351, 324);
			this.pctbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctbAvatar.TabIndex = 0;
			this.pctbAvatar.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pctbMark);
			this.panel3.Controls.Add(this.txbPlayerName);
			this.panel3.Location = new System.Drawing.Point(1069, 353);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(359, 263);
			this.panel3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 185);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 43);
			this.label1.TabIndex = 5;
			this.label1.Text = "5 in a line to win";
			// 
			// pctbMark
			// 
			this.pctbMark.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pctbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pctbMark.Location = new System.Drawing.Point(199, 4);
			this.pctbMark.Margin = new System.Windows.Forms.Padding(4);
			this.pctbMark.Name = "pctbMark";
			this.pctbMark.Size = new System.Drawing.Size(156, 158);
			this.pctbMark.TabIndex = 2;
			this.pctbMark.TabStop = false;
			// 
			// txbPlayerName
			// 
			this.txbPlayerName.Location = new System.Drawing.Point(4, 4);
			this.txbPlayerName.Margin = new System.Windows.Forms.Padding(4);
			this.txbPlayerName.Name = "txbPlayerName";
			this.txbPlayerName.Size = new System.Drawing.Size(185, 22);
			this.txbPlayerName.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1444, 760);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlChessBoard);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Game Caro LAN";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChessBoard;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pctbAvatar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pctbMark;
		private System.Windows.Forms.TextBox txbPlayerName;
		private System.Windows.Forms.Label label1;
	}
}

