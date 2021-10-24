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
    class game 
    {
        public List<circle> circles = new List<circle>();

        //public string circleInstances;
        public class circle
        {
            public int y = 0;
            public int lane = 1;
            public int hitAccuracy = 0;
            public void New(int laneVal)
            {
                lane = laneVal;
            }
        }
        public void addCircle(int lane, int hitAccuracy)
        {
            circle newCircle = new circle() { lane = lane, hitAccuracy = hitAccuracy };
            circles.Add(newCircle);

        }
        public void moveCircles()
        {
            foreach (circle circle in circles)
            {
                circle.y += 1;
            }
        }
        public void clearCircles()
        {
            circles.Clear();
        }
    }

    
}