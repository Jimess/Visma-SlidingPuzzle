using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlidingPuzzleGame.Classes;

namespace SlidingPuzzleGame
{
    public partial class Form1 : Form
    {
        private PictureBox[] boxes = new PictureBox[9];
        Board board;

        private bool keyRestart = false;


        public Form1()
        {
            InitializeComponent();

            //initialize
            Init();
        }

        private void Init()
        {
            board = new Board();

            //adding click listeners
            box1.Click += new EventHandler(BoxButtonClick);
            box2.Click += new EventHandler(BoxButtonClick); ;
            box3.Click += new EventHandler(BoxButtonClick); ;
            box4.Click += new EventHandler(BoxButtonClick); ;
            box5.Click += new EventHandler(BoxButtonClick); ;
            box6.Click += new EventHandler(BoxButtonClick); ;
            box7.Click += new EventHandler(BoxButtonClick); ;
            box8.Click += new EventHandler(BoxButtonClick); ;
            box9.Click += new EventHandler(BoxButtonClick); ;

            //adding paint listeners
            box1.Paint += new PaintEventHandler(RefreshSquare);
            box2.Paint += new PaintEventHandler(RefreshSquare);
            box3.Paint += new PaintEventHandler(RefreshSquare);
            box4.Paint += new PaintEventHandler(RefreshSquare);
            box5.Paint += new PaintEventHandler(RefreshSquare);
            box6.Paint += new PaintEventHandler(RefreshSquare);
            box7.Paint += new PaintEventHandler(RefreshSquare);
            box8.Paint += new PaintEventHandler(RefreshSquare);
            box9.Paint += new PaintEventHandler(RefreshSquare);

            board.AddSquare(new Square(box1, 0, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box2, 1, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box3, 2, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box4, 3, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box5, 4, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box6, 5, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box7, 6, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box8, 7, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box9, 8, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));

            board.PositionSquares();
            
        }

        void EndGame()
        {
            gameTimer.Interval = 50;
            gameTimer.Tick += Update;
            gameTimer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            if (keyRestart)
            {
                winLabel.Visible = false;
                restartLabel.Visible = false;
                RestartGame();

                gameTimer.Stop();
            }

            keyRestart = false;
        }

        private void RestartGame()
        {
            board = new Board();

            board.AddSquare(new Square(box1, 0, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box2, 1, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box3, 2, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box4, 3, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box5, 4, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box6, 5, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box7, 6, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box8, 7, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));
            board.AddSquare(new Square(box9, 8, Constants.SQUARE_SIZE, Constants.SQUARE_SIZE));

            board.PositionSquares();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BoxButtonClick(object sender, EventArgs e)
        {

            string name = ((PictureBox)sender).Name.ToString();
            int ID = int.Parse(name.Substring(name.Length - 1, 1)) - 1;

            Console.WriteLine("Clicked on: " + name + " ID: " + ID);

            //board.ActivateSquare(ID);
            //((PictureBox)sender).Invalidate();

            //Console.WriteLine(board.GetSquare(ID).number);

            if (board.GetActiveSquares().Contains(board.GetSquare(ID)) && !board.isWon())
            {
                board.MoveSquareToSpace(board.GetSquare(ID));
                //board.isWon();
            } else if (board.isWon())
            {
                Console.WriteLine("YOU WIN");
                winLabel.Visible = true;
                restartLabel.Visible = true;
                EndGame();
            }
        }

        //refreshes boxes
        private void RefreshSquare(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            string name = ((PictureBox)sender).Name.ToString();
            int ID = int.Parse(name.Substring(name.Length - 1, 1)) - 1;
            
            //draw squares
            //board.squares[ID].Draw(g);
            board.GetSquare(ID).Draw(g);
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                keyRestart = true;
                Console.WriteLine("Restart key");
            }
        }
    }
}
