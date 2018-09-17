using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro_2_Nguoi
{
    public partial class Form1 : Form
    {
        public const int SoHang = 20;
        public const int Socot = 23;

        public Form1()
        {
            InitializeComponent();
            veBanCo();
        }
        void veBanCo()      //Ve ban co caro
        {
            Button OldButton = new Button() { Width = 0, Location = new Point(0, 0) };          //Khởi tạo ô vị trí đầu tiên của bàn cờ
            for(int i=0;i<SoHang;i++)
            {
                for(int j=0;j<Socot;j++)
                {
                    Button btn = new Button()      //Khởi tạo từng ô của bàn cờ
                    {
                        Width = 30,     //chiều dài
                        Height = 30,    //chiều rộng
                        //Vị trí của ô mới sát bên ô cũ
                        Location = new Point(OldButton.Location.X + OldButton.Width, OldButton.Location.Y),
                        BackgroundImageLayout=ImageLayout.Stretch       //điều chỉnh hình ảnh phù hợp với ô caro
                    };
                    btn.Click += btn_Click;
                    ChessBroard.Controls.Add(btn);      //thêm ô mới vào bàn cờ
                    OldButton = btn;    //gắn ô mới tạo thành ô cũ để tạo ô tiếp theo
                }
                //tạo xong một dòng xuống dòng và khởi tạo lại hàng mới
                OldButton.Location = new Point(0, OldButton.Location.Y + 30);
                OldButton.Width = 0;
                OldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile("X.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
