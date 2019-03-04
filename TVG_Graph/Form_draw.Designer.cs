namespace TVG_Graph
{
    partial class Form_draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_draw));
            this.pictureDraw = new System.Windows.Forms.PictureBox();
            this.c_y = new System.Windows.Forms.Label();
            this.c_x = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.image_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDraw
            // 
            this.pictureDraw.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureDraw.Image = ((System.Drawing.Image)(resources.GetObject("pictureDraw.Image")));
            this.pictureDraw.InitialImage = null;
            this.pictureDraw.Location = new System.Drawing.Point(277, 12);
            this.pictureDraw.Name = "pictureDraw";
            this.pictureDraw.Size = new System.Drawing.Size(700, 661);
            this.pictureDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDraw.TabIndex = 5;
            this.pictureDraw.TabStop = false;
            this.pictureDraw.Click += new System.EventHandler(this.pictureDraw_Click);
            // 
            // c_y
            // 
            this.c_y.AutoSize = true;
            this.c_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.c_y.Location = new System.Drawing.Point(65, 79);
            this.c_y.Name = "c_y";
            this.c_y.Size = new System.Drawing.Size(35, 37);
            this.c_y.TabIndex = 9;
            this.c_y.Text = "0";
            // 
            // c_x
            // 
            this.c_x.AutoSize = true;
            this.c_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.c_x.Location = new System.Drawing.Point(65, 12);
            this.c_x.Name = "c_x";
            this.c_x.Size = new System.Drawing.Size(35, 37);
            this.c_x.TabIndex = 8;
            this.c_x.Text = "0";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labely.Location = new System.Drawing.Point(12, 79);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(57, 37);
            this.labely.TabIndex = 7;
            this.labely.Text = "Y :";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelx.Location = new System.Drawing.Point(12, 12);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(56, 37);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "X :";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.count_label.Location = new System.Drawing.Point(12, 142);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(0, 37);
            this.count_label.TabIndex = 14;
            // 
            // image_load
            // 
            this.image_load.BackColor = System.Drawing.SystemColors.Control;
            this.image_load.Location = new System.Drawing.Point(19, 475);
            this.image_load.Name = "image_load";
            this.image_load.Size = new System.Drawing.Size(117, 58);
            this.image_load.TabIndex = 13;
            this.image_load.Text = "browse image..";
            this.image_load.UseVisualStyleBackColor = false;
            this.image_load.Click += new System.EventHandler(this.load_image_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(19, 370);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(117, 58);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "save as..";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(19, 295);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(117, 56);
            this.button_browse.TabIndex = 11;
            this.button_browse.Text = "browse text..";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 575);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.image_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c_y);
            this.Controls.Add(this.c_x);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.pictureDraw);
            this.Name = "Form_draw";
            this.Text = "Form_draw";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDraw;
        private System.Windows.Forms.Label c_y;
        private System.Windows.Forms.Label c_x;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Button image_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button2;
    }
}