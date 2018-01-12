using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SlidingPuzzleGame.Classes
{
    class Square
    {
        public PictureBox box;
        public int number;
        public int Width, Height;
        public bool isActive = false; // active will be the squares that can be moved
        public bool isSpace = false; //empty squre

        public Square(PictureBox box, int number, int Width, int Height)
        {
            this.box = box;
            this.number = number;
            this.Width = Width;
            this.Height = Height;
        }

        public void Draw (Graphics g)
        {
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            if (isActive)
            {
                g.FillRectangle(Brushes.Blue, box.ClientRectangle);
            }

            if (!isSpace)
            {
                g.DrawString((number+1).ToString(), new Font("Arial", 15), Brushes.Black, box.ClientRectangle, format);
            }
        }
    }
}
