﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class FormChienThang : Form
    {
        public FormChienThang()
        {
            InitializeComponent();
        }


        private void tmdoimau_Tick(object sender, EventArgs e)
        {
            lbchienthang.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Random Random = new Random();
        int x = 20, a = 10, y = 260;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tmchuchay_Tick(object sender, EventArgs e)
        {
            x += a;
            lbwin.Location = new Point(x, y);
            if (x > 100)
                a = -10;
            lbwin.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
            if (x < 20)
            {
                a = 10;
                lbwin.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
            }
        }
    }
}
