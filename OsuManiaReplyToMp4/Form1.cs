using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuManiaReplyToMp4
{
    public partial class Form1 : Form
    {
        bool firstStartup = false;
        game game = new game();
        public Form1()
        {
            InitializeComponent();
            startupFiles();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            game.clearCircles();
            printFrame($"frame0");

            Random random = new Random();
            for (int i = 1; i < 27; i++)
            {
                for (int n = 0; n < random.Next(1, 3); n++)
                {
                    game.addCircle(random.Next(1, 5), random.Next(-1, 1));
                }
                game.moveCircles();
                printFrame($"frame{i}");
            }
            game.moveCircles();
            printFrame($"frame27");
            game.moveCircles();
            printFrame($"frame28");
            game.moveCircles();
            printFrame($"frame29");
            game.moveCircles();
            printFrame($"frame30");
            game.moveCircles();
            printFrame($"frame31");
        }

        private void printFrame(string filename)
        {
            Bitmap bmp = new Bitmap(1920, 1080);
            Rectangle ImageSize = new Rectangle(0, 0, 1920, 1080);
            Graphics.FromImage(bmp).FillRectangle(Brushes.Black, ImageSize);

            using (Graphics image = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.White);
                pen.Width = 7;
                image.DrawLine(pen, 0, 815, 1920, 815); //hit line
                pen.Width = 2; //lane lines
                image.DrawLine(pen, 225, 0, 225, 1080);
                image.DrawLine(pen, 375, 0, 375, 1080);
                image.DrawLine(pen, 525, 0, 525, 1080);
                image.DrawLine(pen, 675, 0, 675, 1080);
                image.DrawLine(pen, 825, 0, 825, 1080);
            }

            foreach (game.circle circle in game.circles)
            {
              
                int xDraw = 0, yDraw = 0;
                switch (circle.lane)
                {
                    case 1:
                        xDraw = 250;
                        break;
                    case 2:
                        xDraw = 400;
                        break;
                    case 3:
                        xDraw = 550;
                        break;
                    case 4:
                        xDraw = 700;
                        break;
                    default:
                        continue;
                }

                Brush circleBrush = Brushes.White;
                if (circle.hitAccuracy == -1 && circle.y >= 3) { circleBrush = Brushes.Yellow; }
                if (circle.hitAccuracy == 0 && circle.y >= 4) { circleBrush = Brushes.Green; }
                if (circle.hitAccuracy == 1 && circle.y >= 5) { circleBrush = Brushes.Red; }

                yDraw = (circle.y * 220) - 140;
                ImageSize = new Rectangle(xDraw, yDraw, 100, 100);
                using (Graphics image = Graphics.FromImage(bmp))
                {
                    image.FillEllipse(circleBrush, ImageSize); //circle
                }   
            }

            bmp.Save($"Output/{filename}.jpg");
            pbFrame.Image = bmp;
        }

        private void startupFiles()
        {
            firstStartup = false;
            if (Directory.Exists("Output") == false)
            {
                firstStartup = true;
                Directory.CreateDirectory("Output");
            }
        }
    }
}
