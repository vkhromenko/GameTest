using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class ShapeFactory
    {
        public static Shape CreateShape(int randomNum)
        {
            //BlockColor color = (BlockColor)(new Random().Next(7));
            switch (randomNum)
            {
                case (int)ShapeKind.LShape:
                    return new LShape(7, -2, BlockColor.DarkGreen);
                case (int)ShapeKind.JShape:
                    return new JShape(7, -2, BlockColor.DarkSlateBlue);
                case (int)ShapeKind.IShape:
                    return new IShape(7, -2, BlockColor.OrangeRed);
                case (int)ShapeKind.TShape:
                    return new TShape(7, -2, BlockColor.Brown);
                case (int)ShapeKind.SShape:
                    return new SShape(7, -2, BlockColor.Blue);                   
                case (int)ShapeKind.ZShape:
                    return new ZShape(7, -2, BlockColor.Gold);
                default:
                    return new OShape(7, -2, BlockColor.DimGray);
            }
        }
    }
}
