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

namespace TVG_Graph
{
    public partial class Form_preview : Form
    {
        public static List<PointF> points = new List<PointF>();
        public static List<PointF> poin_awal = new List<PointF>();
        public static List<PointF> poin_akhir = new List<PointF>();

        private PointF[] ptsAwal;
        private PointF[] ptsAkhir;
        //public static PointF[] ptsArray;
        public Form_preview()
        {
            InitializeComponent();
            ptsAwal = poin_awal.ToArray();
            ptsAkhir = poin_akhir.ToArray();
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Create a pen
            Pen greenPen = new Pen(Color.Green, 12);
            Pen redPen = new Pen(Color.Red, 12);

            PointF[] ptsArray = points.ToArray();

            // Draw polygon
            try
            {
                if (ptsArray.Count() > 1)
                    g.DrawPolygon(redPen, ptsArray);
            }
            catch (IOException p)
            {
                Console.WriteLine("Error : {0}", p);
            }

            // Draw polygon awal
            try
            {
                if (ptsAwal.Count() > 1)
                    g.DrawPolygon(redPen, ptsAwal);
            }
            catch (IOException p)
            {
                Console.WriteLine("Error : {0}", p);
            }

            // Draw polygon akhir
            try
            {
                if (ptsAkhir.Count() > 1)
                    g.DrawPolygon(greenPen, ptsAkhir);
            }
            catch (IOException p)
            {
                Console.WriteLine("Error : {0}", p);
            }

            for (int i = 0; i < ptsAkhir.Count(); i++)
            {
                ptsAwal[i] = MovePointTo(ptsAwal[i], ptsAkhir[i]);
            }

            // Dispose of object
            greenPen.Dispose();
            redPen.Dispose();
            if (!isFinish(ptsAwal, ptsAkhir))
            {
                System.Threading.Thread.Sleep(10);
                Invalidate();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private PointF MovePointTo(PointF awal, PointF akhir)
        {
            double r = Math.Sqrt(Math.Pow((awal.X - akhir.X), 2) + Math.Pow((awal.Y - akhir.Y), 2));
            if (awal != akhir)
            {

                int dx = (int)Math.Round((akhir.X - awal.X) / r);
                int dy = (int)Math.Round((akhir.Y - awal.Y) / r);
                awal.X += dx;
                awal.Y += dy;
            }

            return awal;
        }

        private bool isFinish(PointF[] awal, PointF[] akhir)
        {
            for (int i = 0; i < ptsAkhir.Count(); i++)
            {
                if (ptsAwal[i] != ptsAkhir[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
