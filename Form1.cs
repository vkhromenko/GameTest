﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class GameForm : Form
    {
        public static int WIDTH = 15;
        public static int HEIGHT = 25;
        public static int SCALE = 30;
        public static int SPEED = 1;

        Shape shape;

        private Timer timer;

        public Graphics mainGraphics;
        public BufferedGraphicsContext mainContext;
        public static BufferedGraphics mainBuffer;

        public Random globalRandom;

        List<Block> gameMap;


        public GameForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(WIDTH * SCALE + 100, HEIGHT * SCALE);
            pbMain.ClientSize = new Size(WIDTH * SCALE, HEIGHT * SCALE);
            pbMain.BackColor = Color.LightGray;

            mainGraphics = pbMain.CreateGraphics();
            mainContext = new BufferedGraphicsContext();
            mainBuffer = mainContext.Allocate(mainGraphics, new Rectangle(0, 0, pbMain.Width, pbMain.Height));

            globalRandom = new Random(DateTime.Now.Millisecond);
            gameMap = new List<Block>();

            timer = new Timer();
        }

        public void RepaintForm(BufferedGraphics mainBuffer)
        {
            mainBuffer.Graphics.Clear(Color.Ivory);
            PrintGrid.PrintGridFromForm(mainBuffer);

            foreach (Block block in gameMap)
            {
                block.PaintBlock(mainBuffer);
            }
            shape.PaintShape();
            mainBuffer.Render();
        }

        private bool AdditionBlocks(Shape shape)
        {
            bool flag = false;
            for (int i = 0; i < shape.Count; i++)
            {
                if (shape[i].Y == 0)
                {
                    flag = false;
                    timer.Stop();
                    MessageBox.Show("Game Over!");
                    break;
                }
                else
                {
                    gameMap.Add(shape[i]);
                    flag = true;
                }
            }
            return flag;
        }

        private bool ContainsBlock(Shape shape)
        {
            bool flag = false;
            for (int i = 0; i < gameMap.Count; i++)
            {
                for (int j = 0; j < shape.Count; j++)
                {
                    if (shape[j].X == gameMap[i].X && shape[j].Y + 1 == gameMap[i].Y)
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        private bool ContainsBlock(Shape shape, Direction direction)
        {
            bool flag = false;
            if (direction != Direction.Down)
            {
                for (int i = 0; i < gameMap.Count; i++)
                {
                    for (int j = 0; j < shape.Count; j++)
                    {
                        if (shape[j].X + (int)direction == gameMap[i].X &&
                            shape[j].Y == gameMap[i].Y)
                        {
                            flag = true;
                        }
                    }
                }
            }
            return flag;
        }

        private void SeekAndDestroy()
        {
            Block tmp;
            int counter = 1;

            for (int i = 0; i < gameMap.Count; i++)
            {
                tmp = gameMap[i];
                counter =1;

                for (int j = 0; j < gameMap.Count; j++)
                {
                    if (tmp != gameMap[j])
                    {
                        if (tmp.Y == gameMap[j].Y)
                        {
                            counter++;
                        }
                    }
                }
                if(counter >= WIDTH)
                {
                    gameMap.RemoveAll(x => x.Y == tmp.Y);
                    for (int k = 0; k < gameMap.Count; k++)
                    {
                        if(gameMap[k].Y < tmp.Y)
                        {
                            gameMap[k].Y++;
                        }
                    }
                }
            }
        }

        private void AddAndCreate()
        {
            AdditionBlocks(shape);
            SeekAndDestroy();
            //shape = prevShape;
            shape = ShapeFactory.CreateShape(globalRandom.Next(7));
        }

        public void GameLoop()
        {
            bool isMoving = false;

            if (!ContainsBlock(shape))
            {
                isMoving = shape.Move();
                if (!isMoving)
                {
                    AddAndCreate();
                }
            }
            else
            {
                AddAndCreate();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RepaintForm(mainBuffer);
            GameLoop();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer.Interval = 100;
                timer.Tick += Timer_Tick;

                shape = ShapeFactory.CreateShape(globalRandom.Next(7));

                timer.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (!ContainsBlock(shape, Direction.Left))
                    shape.MoveLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (!ContainsBlock(shape, Direction.Right))
                    shape.MoveRight();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (!ContainsBlock(shape, Direction.Left) && !ContainsBlock(shape, Direction.Right))
                    shape.Rotate();
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (timer.Enabled)
                    timer.Stop();
                else timer.Start();
            }
        }
    }
}
