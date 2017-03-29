using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    abstract class Shape
    {
        internal Block[] blocks = new Block[4];

        public Block this[int index]
        {
            get
            {
                return blocks[index];
            }
        }
        public int Count
        {
            get
            {
                return blocks.Length;
            }
        }
        protected Shape(int startX, int startY, BlockColor color)
        {
            blocks[0] = new Block(startX, startY, color);
        }

        public void PaintShape()
        {
            for(int i = 0; i < blocks.Length; i++)
            {
                blocks[i].PaintBlock(GameForm.mainBuffer);
            }
        }

        public bool Move()
        {
            bool flag = false;
            int tmpYY = 0;

            Block[] blocksTemp = new Block[4];

            blocks.CopyTo(blocksTemp, 0);

            for (int i = 0; i < blocks.Length; i++)
            {
                tmpYY = blocksTemp[i].Y;
                if (!((tmpYY += 1 * GameForm.SPEED) >= GameForm.HEIGHT))
                {
                    blocksTemp[i].Y += 1 * GameForm.SPEED;
                }
                else
                {
                    flag = false;
                    break;
                }
                flag = true;
            }
            if (flag)
            {
                blocks = blocksTemp;
            }
            return flag;
        }

        public void Rotate()
        {

        }
    }
}
