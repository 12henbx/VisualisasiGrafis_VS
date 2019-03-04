namespace TVG_Graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_browse = new System.Windows.Forms.Button();
            this.button_transform = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.draw_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(12, 12);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(117, 56);
            this.button_browse.TabIndex = 6;
            this.button_browse.Text = "Upload Coordinates";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_transform
            // 
            this.button_transform.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_transform.Location = new System.Drawing.Point(12, 74);
            this.button_transform.Name = "button_transform";
            this.button_transform.Size = new System.Drawing.Size(117, 58);
            this.button_transform.TabIndex = 8;
            this.button_transform.Text = "Transform";
            this.button_transform.UseVisualStyleBackColor = false;
            this.button_transform.Click += new System.EventHandler(this.button_transform_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(157, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 705);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "After";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TVG_Graph.Properties.Resources.pikachu;
            this.pictureBox3.Location = new System.Drawing.Point(613, 326);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TVG_Graph.Properties.Resources.pichu;
            this.pictureBox2.Location = new System.Drawing.Point(613, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Red;
            this.button_reset.Location = new System.Drawing.Point(12, 138);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(117, 58);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(12, 555);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(117, 56);
            this.draw_button.TabIndex = 12;
            this.draw_button.Text = "Draw Coordinate";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1082, 742);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_transform);
            this.Controls.Add(this.button_browse);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label coordinate_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label coordinate_y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_transform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button draw_button;
    }
}

