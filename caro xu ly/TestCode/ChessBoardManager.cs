using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
	//Hàm xử lý bàn cờ caro
	public class ChessBoardManager
	{

		// Properties
		private Panel chessBoard;	//Khai báo Panel bàn cờ

		public Panel ChessBoard
		{
			get { return chessBoard; }
			set { chessBoard = value; }
		}

		private List<Player> player;		//Khai báo một danh sách người chơi

		public List<Player> Player
		{
			get { return player; }
			set { player = value; }
		}

		private int currentPlayer;          //Biến ghi nhớ người chơi hiện tại 
											//( curentPlayer = 0 : là người chơi thứ nhất, = 1 : người chơi thứ 2)

		public int CurrentPlayer
		{
			get { return currentPlayer; }
			set { currentPlayer = value; }
		}

		private TextBox playerName;			//Chứa đựng tên người chơi, đổi theo currentPlayer

		public TextBox PlayerName
		{
			get { return playerName; }
			set { playerName = value; }
		}

		private PictureBox playerMark;		//Ký hiệu để biết đến lượt ai đánh

		public PictureBox PlayerMark
		{
			get { return playerMark; }
			set { playerMark = value; }
		}



		////////////////////////////

		//Xử lý, khởi tạo
		public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
		{
			this.ChessBoard = chessBoard;
			this.PlayerName = playerName;
			this.PlayerMark = mark;

			this.Player = new List<Player>()
			{
				new Player("First Player", Image.FromFile("X.jpg")),
				new Player("Second Player", Image.FromFile("O.jpg"))
			};

			CurrentPlayer = 0;	 //Mặc định người thứ nhất đi trước ( X đi trước )

			ChangePlayer();		//Đổi người
		}

		/////////////////////

		#region Methods        
		public void DrawChessBoard()
		{

			Button oldButton = new Button()
			{
				Width = 0, Location = new Point(0, 0)   //Khởi tạo nút đầu làm mốc
			};	
			
			//Sử dụng hai vòng lặp lồng nhau để tạo ra bàn cờ, mỗi bàn cờ là một button
			for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)	//Đi hết hàng
			{

				for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)	//Đi hết cột
				{
					Button btn = new Button()
					{
						Width = Cons.CHESS_WIDTH,		//Tạo ra các nút có chiều rộng là cons.CHESS_WIDTH, chiều cao là cons.CHESS_HEIGHT
						Height = Cons.CHESS_HEIGHT,
						Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y), //Tạo nên button tiếp theo dựa vào oldButton
						BackgroundImageLayout = ImageLayout.Stretch,	//Định dạng lại ảnh cho vừa với PictureBox
					};

					btn.Click += btn_Click;		//Tạo event Click

					//Thêm button vào bàn phím
					ChessBoard.Controls.Add(btn);

					oldButton = btn;	//gán Button mới được tạo thành button cũ để tạo ra các button tiếp theo 
				}
				//Hết một hàng, khởi tạo lại hàng mới
				oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
				oldButton.Width = 0;
				oldButton.Height = 0;
			}
		}

		void btn_Click(object sender, EventArgs e)		//Event click cho button
		{
			Button btn = sender as Button;		//Ép kiểu lại với button

			if (btn.BackgroundImage != null)	//Kiểm tra xem button này đã được Click chưa
				return;		//đã được đánh, không được đánh lên nửa

			// Đổi background button theo người đánh
			Mark(btn);

			//Đổi người
			ChangePlayer();

		}


		private void Mark(Button btn)
		{
			btn.BackgroundImage = Player[CurrentPlayer].Mark;		//Đổi ký hiệu X O theo người chơi hiện tại.

			if (CurrentPlayer == 1)		//Sau mỗi lần đánh, đổi người chơi.
				CurrentPlayer = 0;
			else
				CurrentPlayer = 1;
		}

		private void ChangePlayer()		///Hàm đổi người chơi
		{
			PlayerName.Text = Player[CurrentPlayer].Name;		//Đổi tên và ký hiệu dựa trên current player

			PlayerMark.Image = Player[CurrentPlayer].Mark;
		}
		#endregion

	}
}
