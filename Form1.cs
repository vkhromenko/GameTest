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

        Shape shape;

        private Timer timer;

        public Graphics mainGraphics;
        public BufferedGraphicsContext mainContext;
        public static BufferedGraphics mainBuffer;

        public GameForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(WIDTH * SCALE + 100, HEIGHT * SCALE);
            pbMain.ClientSize = new Size(WIDTH * SCALE, HEIGHT * SCALE);
            pbMain.BackColor = Color.LightGray;

            mainGraphics = pbMain.CreateGraphics();
            mainContext = new BufferedGraphicsContext();
            mainBuffer = mainContext.Allocate(mainGraphics, new Rectangle(0, 0, pbMain.Width, pbMain.Height));

            timer = new Timer();
        }

        public void RepaintForm(BufferedGraphics mainBuffer)
        {
            mainBuffer.Graphics.Clear(Color.Ivory);
            PrintGrid.PrintGridFromForm(mainBuffer);

            for(int i = 0; i < shape.Count; i++)
            {
                shape[i].PaintBlock(mainBuffer);
            }
            mainBuffer.Render();
        }

        public void GameLoop()
        {
            shape.Move();
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

                shape = new IShape(10, -2, BlockColor.DarkGreen);

                timer.Enabled = true;
            }

            if(e.KeyCode == Keys.Space)
            {
                
            }
        }
    }
}
