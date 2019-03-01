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
        private string coordinate;
        private bool cek=true;
        private float tmp_x = 0, tmp_y = 0, read_axis_x=0, read_axis_y=0;
        public static int iter = -1;
        private string[] write_row = new string[500];
        public static List<PointF> read_points = new List<PointF>();


        public Form1()
        {
            InitializeComponent();
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);
            //pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        { 
            //c_x.Text = Cursor.Position.X.ToString();
            //c_y.Text = Cursor.Position.Y.ToString();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            string[] text;
            var openFile = new System.Windows.Forms.OpenFileDialog();
            int size = -1, read_iter = 0;
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFile.FileName;
                try
                {
                    //read_iter = 0;
                    text = File.ReadAllLines(@"C:\Users\Henbx\Desktop\WriteLines.txt");

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
                            Form2.points.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                        }
                    }
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\Users\Henbx\Desktop\WriteLines.txt", write_row);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            coordinate = coordinates.ToString();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(coordinate);
            tmp_x = 0;
            tmp_y = 0;
            cek = true;
            for (int i=0;i<coordinate.Length; i++)
            {
                if (asciiBytes[i] > 47 && asciiBytes[i] < 58)
                {
                    if (cek)
                    {
                        tmp_x = tmp_x * 10;
                    }
                    else
                    {
                        tmp_y = tmp_y * 10;
                    }
                    if (cek)
                    {
                        tmp_x = tmp_x + (asciiBytes[i] - 48);
                        if (asciiBytes[i + 1] < 48) cek = false;
                    }
                    else
                    {
                        tmp_y = tmp_y + (asciiBytes[i] - 48);
                    }
                }
            }
            Form2.points.Add(new PointF((float)tmp_x, (float)tmp_y));
            c_x.Text = tmp_x.ToString();
            c_y.Text = tmp_y.ToString();
            iter = iter + 1;
            write_row[iter] = tmp_x.ToString();
            iter = iter + 1;
            write_row[iter] = tmp_y.ToString();
        }
    }
}
