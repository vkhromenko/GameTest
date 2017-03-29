using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public enum ShapeKind
    {
        LShape = 0,
        JShape = 1,
        ZShape = 2,
        SShape = 3,
        TShape = 4,
        IShape = 5,
        OShape = 6,
    }

    public enum Direction
    {
        Right = 1,
        Left = -1,
        Down = 2,
    }

    public enum BlockColor
    {
        Blue,
        DarkGreen,
        Brown,
        DarkOrange,
        DarkSlateBlue,
        DimGray,
    }

    class Block
    {
        public int X { get; set; }
        public int Y { get; set; }

        private Brush[] brushColor = new SolidBrush[] { new SolidBrush(Color.Blue), new SolidBrush(Color.DarkGreen), new SolidBrush(Color.Brown),
                                      new SolidBrush(Color.DarkOrange), new SolidBrush(Color.DarkSlateBlue), new SolidBrush(Color.DimGray) };

        internal Brush brush;

        public Block(int startX, int startY, BlockColor color)
        {
            X = startX;
            Y = startY;
            brush = brushColor[(int)color];
        }

        public void PaintBlock(BufferedGraphics g)
        {
            g.Graphics.FillRectangle(brush, X * GameForm.SCALE + 1, Y * GameForm.SCALE + 1, GameForm.SCALE - 1, GameForm.SCALE - 1);
        }
    }
}
