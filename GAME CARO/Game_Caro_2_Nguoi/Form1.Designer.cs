namespace Game_Caro_2_Nguoi
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.ChessBroard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptmark = new System.Windows.Forms.PictureBox();
            this.playername2 = new System.Windows.Forms.TextBox();
            this.playername1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptmark)).BeginInit();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Avatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Avatar.Image = global::Game_Caro_2_Nguoi.Properties.Resources.BG_caro;
            this.Avatar.Location = new System.Drawing.Point(939, 12);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(326, 338);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // ChessBroard
            // 
            this.ChessBroard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChessBroard.BackColor = System.Drawing.SystemColors.Info;
            this.ChessBroard.Location = new System.Drawing.Point(32, 12);
            this.ChessBroard.Name = "ChessBroard";
            this.ChessBroard.Size = new System.Drawing.Size(883, 759);
            this.ChessBroard.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ptmark);
            this.panel3.Controls.Add(this.playername2);
            this.panel3.Controls.Add(this.playername1);
            this.panel3.Location = new System.Drawing.Point(959, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 283);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(35, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "5 in a line to win!";
            // 
            // ptmark
            // 
            this.ptmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptmark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptmark.Location = new System.Drawing.Point(166, 31);
            this.ptmark.Name = "ptmark";
            this.ptmark.Size = new System.Drawing.Size(127, 130);
            this.ptmark.TabIndex = 2;
            this.ptmark.TabStop = false;
            // 
            // playername2
            // 
            this.playername2.Location = new System.Drawing.Point(166, 3);
            this.playername2.Name = "playername2";
            this.playername2.Size = new System.Drawing.Size(127, 22);
            this.playername2.TabIndex = 1;
            // 
            // playername1
            // 
            this.playername1.Location = new System.Drawing.Point(3, 3);
            this.playername1.Name = "playername1";
            this.playername1.Size = new System.Drawing.Size(119, 22);
            this.playername1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 773);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ChessBroard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptmark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChessBroard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.PictureBox ptmark;
        private System.Windows.Forms.TextBox playername2;
        private System.Windows.Forms.TextBox playername1;
        private System.Windows.Forms.Label label1;
    }
}

