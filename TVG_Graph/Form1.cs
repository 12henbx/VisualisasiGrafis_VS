using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVG_Graph
{
    public partial class Form1 : Form
    {
        //TODO: Ubah direktori koordinat
        private string dir_awal = "D:\\Dev\\CSharp\\TVG_Tugas1_46360_46525\\coordinates\\awal.txt";
        private string dir_akhir = "D:\\Dev\\CSharp\\TVG_Tugas1_46360_46525\\coordinates\\akhir.txt";
        private string[] write_row = new string[500];
        private float read_axis_x=0, read_axis_y=0;
        private int iter = -1;
        private bool isTransform;

        private List<PointF> read_points = new List<PointF>();
        private List<PointF> points = new List<PointF>();
        private List<PointF> poin_awal = new List<PointF>();
        private List<PointF> poin_akhir = new List<PointF>();

        private PointF[] ptsAwal;
        private PointF[] ptsAkhir;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ptsAwal = poin_awal.ToArray();
            ptsAkhir = poin_akhir.ToArray();
            isTransform = false;

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            points.Clear();
            string[] text;
            var openFile = new System.Windows.Forms.OpenFileDialog();
            int size = -1, read_iter = 0;
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFile.FileName;
                Console.WriteLine("nama file: {0}", file);
                if (file == dir_awal)
                {
                    try
                    {
                        //read_iter = 0;
                        text = File.ReadAllLines(file);

                        while (text[read_iter] != "")
                        {
                            read_iter++;
                        }
                        //Console.WriteLine(float.Parse(text[0])-9);
                        for (int i = 0; i < read_iter; i++)
                        {
                            if (i % 2 == 0)
                            {
                                read_axis_x = float.Parse(text[i]);
                            }
                            else
                            {
                                read_axis_y = float.Parse(text[i]);
                                poin_awal.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                            }
                        }
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                    }

                    ptsAwal = poin_awal.ToArray();
                }

                if (file == dir_akhir)
                {
                    try
                    {
                        //read_iter = 0;
                        text = File.ReadAllLines(file);

                        while (text[read_iter] != "")
                        {
                            read_iter++;
                        }
                        //Console.WriteLine(float.Parse(text[0])-9);
                        for (int i = 0; i < read_iter; i++)
                        {
                            if (i % 2 == 0)
                            {
                                read_axis_x = float.Parse(text[i]);
                            }
                            else
                            {
                                read_axis_y = float.Parse(text[i]);
                                poin_akhir.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                            }
                        }
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                    }

                    ptsAkhir = poin_akhir.ToArray();
                    
                }
                panel1.Refresh();
                Invalidate();
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result);
        }

        private void button_transform_Click(object sender, EventArgs e)
        {
            isTransform = isTransform ? false : true;
            panel1.Refresh();
            Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Create a pen
            Pen greenPen = new Pen(Color.Green, 2);
            Pen redPen = new Pen(Color.Yellow, 5);

            Console.WriteLine("masuk onPaint");
            Console.WriteLine("isTransform: {0}", isTransform);


            if (isTransform)
            {

                for (int i = 0; i < ptsAkhir.Count(); i++)
                {
                    ptsAwal[i] = MovePointTo(ptsAwal[i], ptsAkhir[i]);
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

                // Dispose of object
                greenPen.Dispose();
                redPen.Dispose();

                if (!isFinish(ptsAwal, ptsAkhir))
                {
                    System.Threading.Thread.Sleep(10);
                    panel1.Refresh();
                    Invalidate();
                }
            }
            else
            {
                for (int i = 0; i < ptsAkhir.Count(); i++)
                {
                    ptsAwal[i] = MovePointTo(ptsAwal[i], ptsAkhir[i]);
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
                /*
                try
                {
                    if (ptsAkhir.Count() > 1)
                        g.DrawPolygon(greenPen, ptsAkhir);
                }
                catch (IOException p)
                {
                    Console.WriteLine("Error : {0}", p);
                }
                */

                // Dispose of object
                greenPen.Dispose();
                redPen.Dispose();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ptsAwal = poin_awal.ToArray();
            ptsAkhir = poin_akhir.ToArray();
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

        private void draw_button_Click(object sender, EventArgs e)
        {
            Form_draw drawForm = new Form_draw();
            drawForm.Show();
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
