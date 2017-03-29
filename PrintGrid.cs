using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    static class PrintGrid
    {
        /// <summary>
        /// Метод рисования сетки на главной форме
        /// </summary>
        /// <param name="mainFormGraphics"> Элемент Graphics главной формы</param>
        public static void PrintGridFromForm(BufferedGraphics mainFormGraphics)
        {
            //Заливка формы стандартным цветом
            //mainFormGraphics.Graphics.Clear(Color.LightGray);
            //Рисование сетки
            Pen myPen = new Pen(Color.DarkGray);

            for (int xx = 0; xx < GameForm.WIDTH * GameForm.SCALE; xx += GameForm.SCALE)
            {
                mainFormGraphics.Graphics.DrawLine(myPen, xx, 0, xx, GameForm.HEIGHT * GameForm.SCALE);
            }
            for (int yy = 0; yy <= GameForm.HEIGHT * GameForm.SCALE; yy += GameForm.SCALE)
            {
                mainFormGraphics.Graphics.DrawLine(myPen, 0, yy, GameForm.WIDTH * GameForm.SCALE, yy);
            }

            myPen.Dispose();
        }
    }
}
