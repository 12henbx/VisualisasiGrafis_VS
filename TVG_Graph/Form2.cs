using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVG_Graph
{
    public partial class Form2 : Form
    {
        public static List<PointF> points = new List<PointF>();
        //public static PointF[] ptsArray;
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Create a pen
            Pen greenPen = new Pen(Color.Green, 2);
            Pen redPen = new Pen(Color.Red, 9);

            // Create points for polygon

            //for (int i = 0; i < 2; i++)
            //    points.Add(new PointF((float)250+i, (float)250+i));

            PointF[] ptsArray = points.ToArray();
            
            // Draw polygon
            try
            {
                g.DrawPolygon(redPen, ptsArray);
            }catch(InvalidCastException p)
            {
                Console.WriteLine("error");
            }
            
            

            // Dispose of object
            greenPen.Dispose();
            redPen.Dispose();
        }
    }
}
