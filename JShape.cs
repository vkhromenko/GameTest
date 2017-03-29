using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class JShape : Shape
    {
        public JShape(int startX, int startY, BlockColor color) : base(startX, startY, color){

            blocks[1] = new Block(startX, startY - 1, color);
            blocks[2] = new Block(startX, startY + 1, color);
            blocks[3] = new Block(startX - 1, startY + 1, color);
        }
    }
}
