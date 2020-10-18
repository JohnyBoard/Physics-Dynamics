using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamics
{
    public partial class Dynamics : Form
    {
        Vector v1, a1, v2, a2, v3, a3, r1, r2, r3, r0, rx;
        double m1 = 1;
        double m2 = 1;
        double m3 = 1;

        public Dynamics()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            v1 = new Vector(500, -300);
            a1 = new Vector(0, 1000);
            r1 = new Vector(Convert.ToInt32(pbBall1.Left), Convert.ToInt32(pbBall1.Top));
            r2 = new Vector(Convert.ToInt32(pbBall2.Left), Convert.ToInt32(pbBall2.Top));
            v2 = new Vector();
            r0 = new Vector(Convert.ToInt32(pbBall2.Left), Convert.ToInt32(pbBall2.Top + 100));
            r3 = new Vector(Convert.ToInt32(pbBall3.Left), Convert.ToInt32(pbBall3.Top));
            rx = new Vector(Convert.ToInt32(pbBall3.Left), Convert.ToInt32(pbBall3.Top + 100));
            v3 = new Vector();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            Vector g = new Vector(0, 980);
            Vector F1 = m1 * g; 
            a1 = F1 / m1;
            v1 += a1 * dt;
            r1 += v1 * dt;
            pbBall1.Location = new Point(Convert.ToInt32(r1.X), Convert.ToInt32(r1.Y));
            Vector F2 = 10 * (r0 - r2);
            a2 = F2 / m2;
            v2 += a2 * dt;
            r2 += v2 * dt;
            pbBall2.Location = new Point(Convert.ToInt32(r2.X), Convert.ToInt32(r2.Y));
            pbSpring.Height = pbBall2.Top - pbSpring.Top;
            pbSpring.Height = pbBall2.Top - pbSpring.Top;
            
            Vector F3 = 10 * (rx - r3);
            a3 = F3 / m3;
            v3 += a3 * dt;
            r3 += v3 * dt;
            pbBall3.Location = new Point(Convert.ToInt32(r3.X), Convert.ToInt32(r3.Y));
        }
    }
}