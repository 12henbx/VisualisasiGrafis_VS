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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.c_x = new System.Windows.Forms.Label();
            this.c_y = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_transform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelx.Location = new System.Drawing.Point(12, 9);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(56, 37);
            this.labelx.TabIndex = 0;
            this.labelx.Text = "X :";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labely.Location = new System.Drawing.Point(12, 76);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(57, 37);
            this.labely.TabIndex = 1;
            this.labely.Text = "Y :";
            // 
            // c_x
            // 
            this.c_x.AutoSize = true;
            this.c_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.c_x.Location = new System.Drawing.Point(65, 9);
            this.c_x.Name = "c_x";
            this.c_x.Size = new System.Drawing.Size(35, 37);
            this.c_x.TabIndex = 2;
            this.c_x.Text = "0";
            // 
            // c_y
            // 
            this.c_y.AutoSize = true;
            this.c_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.c_y.Location = new System.Drawing.Point(65, 76);
            this.c_y.Name = "c_y";
            this.c_y.Size = new System.Drawing.Size(35, 37);
            this.c_y.TabIndex = 3;
            this.c_y.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(198, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 392);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(19, 255);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(117, 56);
            this.button_browse.TabIndex = 6;
            this.button_browse.Text = "browse text..";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(19, 317);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(117, 58);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_transform
            // 
            this.button_transform.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_transform.Location = new System.Drawing.Point(19, 463);
            this.button_transform.Name = "button_transform";
            this.button_transform.Size = new System.Drawing.Size(117, 58);
            this.button_transform.TabIndex = 8;
            this.button_transform.Text = "Transform";
            this.button_transform.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(993, 533);
            this.Controls.Add(this.button_transform);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.c_y);
            this.Controls.Add(this.c_x);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coordinate_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label coordinate_y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label c_x;
        private System.Windows.Forms.Label c_y;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_transform;
    }
}

