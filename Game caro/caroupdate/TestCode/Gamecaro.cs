using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameCaro
{
	public partial class Form1 : Form
	{
		XuLyBanCo BanCo;

        Random Random = new Random();

        private int sound = 0;

        public Form1()
		{
			InitializeComponent();

			BanCo = new XuLyBanCo(pnlChessBoard, txbPlayerName, pctbMark);

			BanCo.VeBanCo();
			NhacNen.Play();
		}

		private void tmnote_Tick(object sender, EventArgs e)
		{
			NOTE.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
		}

		private void btnnewgame_Click(object sender, EventArgs e)
		{
            dem = 0;
            BanCo.Newgame();
            btnUndo.Enabled = true;
            XuLyBanCo.win = 0;
            tmmophong.Enabled = false;
            btnQueue.Text = "Mô phỏng lại";
            Tmthoigian.Enabled = true;
            XuLyBanCo.time = 30;
        }

		private string nhac = "Music ON";
		private SoundPlayer NhacNen = new SoundPlayer(@"NhacNen.wav");

		private void btnNhacNen_Click(object sender, EventArgs e)
		{
			if (sound == 1)
			{
				NhacNen.Play();
				sound = 0;
				btnNhacNen.Text = nhac;
			}
			else
			{
				NhacNen.Stop();
				sound = 1;
				btnNhacNen.Text = "Music OFF";
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
           FormThoat f = new FormThoat();
            f.Show();
		}

        public void btnUndo_Click(object sender, EventArgs e)
        {
            if (BanCo.STACK.Count == 0)
                return;
            if (XuLyBanCo.win == 0)
                BanCo.Undo();
            else
                btnUndo.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XuLyBanCo.Chan = 0;
            XuLyBanCo.time = 30;
        }

        int dem = 0;
        private void Queue_Click(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;

            if (tmmophong.Enabled == true)
            {
                tmmophong.Enabled = false;
                btnQueue.Text = "Tiếp Tục!";
            }
            else
            {
                tmmophong.Enabled = true;
                btnQueue.Text = "Tạm Dừng!";
            }
        }

        private void btnhuongdan_Click(object sender, EventArgs e)
        {
            FormHuongDan f = new FormHuongDan();
            f.Show();
        }

        private void tmmophong_Tick(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;
            if (dem == 0 && XuLyBanCo.win == 1)
            {
                BanCo.Xoabanco();
                dem = 1;
            }
            if (XuLyBanCo.win == 1)
            {
                BanCo.MoPhong();
            }
        }

        private void btnChanhaidau_Click(object sender, EventArgs e)
        {
            if (XuLyBanCo.Chan == 0)
            {
                XuLyBanCo.Chan = 1;
                MessageBox.Show("Đã áp dụng luật chặn hai đầu!");
                btnChanhaidau.Text = "Hủy luật chặn!";
            }
            else
            {
                XuLyBanCo.Chan = 0;
                MessageBox.Show("Đã Hủy luật chặn hai đầu!");
                btnChanhaidau.Text = "Chặn hai đầu!";
            }
        }

        private void Tmthoigian_Tick(object sender, EventArgs e)
        {
            XuLyBanCo.time--;
            this.tbxthoigian.Text = XuLyBanCo.time.ToString();
            if (XuLyBanCo.time == 0)
            {
                Tmthoigian.Enabled = false;
                pnlChessBoard.Enabled = false;
                BanCo.LuuVanCo();
                XuLyBanCo.win = 1;
                FormChienThang f1 = new FormChienThang();
                f1.Show();
            }
        }

    }
}
;