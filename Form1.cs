using System;
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
        public static int SCORE = 0;
        public static bool speedFlag = false;

        private int defaultInterval = 150;

        Shape shape;
        Shape prevShape;

        private Timer timer;

        public Graphics mainGraphics;
        public BufferedGraphicsContext mainContext;
        public static BufferedGraphics mainBuffer;

        public Graphics prevGraphics;
        public BufferedGraphicsContext prevContext;
        public static BufferedGraphics prevBuffer;

        public Random globalRandom;
        public Random prevRandom;

        List<Block> gameMap;


        public GameForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(WIDTH * SCALE + 130, HEIGHT * SCALE);
            pbMain.ClientSize = new Size(WIDTH * SCALE, HEIGHT * SCALE);
            pbMain.BackColor = Color.LightGray;

            mainGraphics = pbMain.CreateGraphics();
            mainContext = new BufferedGraphicsContext();
            mainBuffer = mainContext.Allocate(mainGraphics, new Rectangle(0, 0, pbMain.Width, pbMain.Height));

            prevGraphics = pnPrev.CreateGraphics();
            prevContext = new BufferedGraphicsContext();
            prevBuffer = prevContext.Allocate(prevGraphics, new Rectangle(0, 0, pnPrev.Width, pnPrev.Height));

            globalRandom = new Random(DateTime.Now.Millisecond);
            prevRandom = new Random(DateTime.Now.Millisecond + 365);
            gameMap = new List<Block>();

            timer = new Timer();
        }

        public void RepaintForm()
        {
            mainBuffer.Graphics.Clear(Color.Ivory);
            PrintGrid.PrintGridFromForm(mainBuffer);

            foreach (Block block in gameMap)
            {
                block.PaintBlock(mainBuffer);
            }
            shape.PaintShape(mainBuffer);
            mainBuffer.Render();
            lbScore.Text = SCORE.ToString();
        }

        private void ClearForm()
        {
            mainBuffer.Graphics.Clear(Color.Ivory);
            PrintGrid.PrintGridFromForm(mainBuffer);
            prevBuffer.Graphics.Clear(Color.LightGray);
            gameMap.Clear();
            shape = null;
            prevShape = null;
            timer.Dispose();
        }

        public void RepaintForm(BufferedGraphics prevBuffer)
        {
            prevBuffer.Graphics.Clear(Color.FromArgb(0xF0, 0xF0, 0xF0));

            if (prevShape != null)
            {
                for (int j = 0; j < prevShape.Count; j++)
                {
                    prevShape[j].Y += 4;
                    prevShape[j].X -= 6;
                }

                prevShape.PaintShape(prevBuffer);
                prevBuffer.Render();
                for (int j = 0; j < prevShape.Count; j++)
                {
                    prevShape[j].Y -= 4;
                    prevShape[j].X += 6;
                }
            }
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
            float multiplier = 0.5f;
            int preScore = 0;

            for (int i = 0; i < gameMap.Count; i++)
            {
                tmp = gameMap[i];
                counter = 1;

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
                    preScore += 15;
                    multiplier += 0.5f;
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
            SCORE += (int) (preScore * multiplier);
        }

        private void AddAndCreate()
        {
            AdditionBlocks(shape);
            shape = prevShape;
            prevShape = ShapeFactory.CreateShape(prevRandom.Next(7));
            SeekAndDestroy();
            //shape = ShapeFactory.CreateShape(globalRandom.Next(7));
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
            RepaintForm();
            RepaintForm(prevBuffer);
            GameLoop();
        }

        private void DoSpeed(bool speedFlag)
        {
            if (speedFlag)
            {
                timer.Interval = (int)(defaultInterval / 5);
            }else {
                timer.Interval = defaultInterval;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ClearForm();
                timer.Interval = defaultInterval;
                timer.Tick += Timer_Tick;

                shape = ShapeFactory.CreateShape(globalRandom.Next(7));
                prevShape = ShapeFactory.CreateShape(prevRandom.Next(7));
           
                timer.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (!ContainsBlock(shape, Direction.Left))
                    shape.MoveLeft();
                    RepaintForm();
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (!ContainsBlock(shape, Direction.Right))
                    shape.MoveRight();
                    RepaintForm();
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
            else if (e.KeyCode == Keys.Down)
            {
                speedFlag = true;
                DoSpeed(speedFlag);
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                speedFlag = false;
                DoSpeed(speedFlag);
            }
        }
    }
}
