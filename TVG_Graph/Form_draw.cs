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
    public partial class Form_draw : Form
    {
        private string coordinate;
        private bool cek = true;
        private float tmp_x = 0, tmp_y = 0, read_axis_x = 0, read_axis_y = 0, count = 0;
        public static int iter = -1;
        private string[] write_row = new string[500];
        public static List<PointF> read_points = new List<PointF>();


        public Form_draw()
        {
            InitializeComponent();
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);
            //pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_preview preview = new Form_preview();
            preview.Show();
        }

        private void load_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureDraw.Image = new Bitmap(open.FileName);
            }
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            //c_x.Text = Cursor.Position.X.ToString();
            //c_y.Text = Cursor.Position.Y.ToString();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            Form_preview.points.Clear();
            string[] text;
            var openFile = new System.Windows.Forms.OpenFileDialog();
            int size = -1, read_iter = 0;
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFile.FileName;
                Console.WriteLine("nama file: {0}", file);
                if (file == "D:\\Dev\\CSharp\\VisualisasiGrafis_VS\\awal.txt")
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
                                Form_preview.poin_awal.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                            }
                        }
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                    }
                }

                else if (file == "D:\\Dev\\CSharp\\VisualisasiGrafis_VS\\akhir.txt")
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
                                Form_preview.poin_akhir.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                            }
                        }
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                    }
                }

                else
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
                                Form_preview.points.Add(new PointF((float)read_axis_x, (float)read_axis_y));
                            }
                        }
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save a File";

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, write_row);
            }
        }

        private void pictureDraw_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            coordinate = coordinates.ToString();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(coordinate);
            tmp_x = 0;
            tmp_y = 0;
            cek = true;
            for (int i = 0; i < coordinate.Length; i++)
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
            Form_preview.points.Add(new PointF((float)tmp_x, (float)tmp_y));
            c_x.Text = tmp_x.ToString();
            c_y.Text = tmp_y.ToString();
            iter = iter + 1;
            write_row[iter] = tmp_x.ToString();
            iter = iter + 1;
            write_row[iter] = tmp_y.ToString();
            count++;
            count_label.Text = count.ToString();
        }


    }
}
