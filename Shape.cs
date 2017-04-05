using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    internal abstract class Shape
    {
        public Block[] blocks = new Block[4];

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

        public void PaintShape(BufferedGraphics buffer)
        {
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i].PaintBlock(buffer);
            }
        }

        public bool Move()
        {
            bool flag = false;
            int tmpYY = 0;

            Block[] blocksTemp = new Block[4];

            for (int i = 0; i < blocks.Length; i++)
            {
                blocksTemp[i] = blocks[i].Clone() as Block;
            }

            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocksTemp[i] != null)
                {
                    tmpYY = blocksTemp[i].Y + 1;
                    if (!(tmpYY >= GameForm.HEIGHT))
                    {
                        blocksTemp[i].Y += 1;
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                blocks = blocksTemp;
            }
            return flag;
        }

        public void MoveLeft()
        {
            if (blocks[0].X > 0 && blocks[1].X > 0 && blocks[2].X > 0 && blocks[3].X > 0)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i].X--;
                }
            }
        }

        public void MoveRight()
        {
            if (blocks[0].X < GameForm.WIDTH - 1 && blocks[1].X < GameForm.WIDTH - 1 && blocks[2].X < GameForm.WIDTH - 1 && blocks[3].X < GameForm.WIDTH - 1)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i].X++;
                }
            }
        }

        public void Rotate()
        {
            if (this.GetType().Name != "OShape")
            {
                bool flag = true; //флаг проверки на границу поля
                Block[] blocksTemp = new Block[4];

                for (int i = 0; i < blocks.Length; i++)
                {
                    blocksTemp[i] = blocks[i].Clone() as Block;
                }

                for (int i = 1; i < blocksTemp.Length; i++)
                {
                    blocksTemp[i].X = blocks[0].X - (blocks[i].Y - blocks[0].Y);

                    if (blocksTemp[i].X < 0 || blocksTemp[i].X >= GameForm.WIDTH)
                    {
                        flag = false;
                        break;
                    }
                    blocksTemp[i].Y = blocks[0].Y + (blocks[i].X - blocks[0].X);
                }

                if (flag)
                {
                    blocks = blocksTemp;
                }
            }
        }
    }
}
