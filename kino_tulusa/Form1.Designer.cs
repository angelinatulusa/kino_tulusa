namespace kino_tulusa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kava_btn = new System.Windows.Forms.Button();
            this.vali_btn = new System.Windows.Forms.Button();
            this.osta_btn = new System.Windows.Forms.Button();
            this.filmid_pbox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmid_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kava_btn
            // 
            this.kava_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.kava_btn.Location = new System.Drawing.Point(519, 148);
            this.kava_btn.Name = "kava_btn";
            this.kava_btn.Size = new System.Drawing.Size(62, 51);
            this.kava_btn.TabIndex = 1;
            this.kava_btn.Text = "Järgmine";
            this.kava_btn.UseVisualStyleBackColor = false;
            this.kava_btn.Click += new System.EventHandler(this.kava_btn_Click);
            // 
            // vali_btn
            // 
            this.vali_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.vali_btn.Location = new System.Drawing.Point(25, 48);
            this.vali_btn.Name = "vali_btn";
            this.vali_btn.Size = new System.Drawing.Size(130, 55);
            this.vali_btn.TabIndex = 2;
            this.vali_btn.Text = "Vali";
            this.vali_btn.UseVisualStyleBackColor = false;
            // 
            // osta_btn
            // 
            this.osta_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.osta_btn.Location = new System.Drawing.Point(25, 125);
            this.osta_btn.Name = "osta_btn";
            this.osta_btn.Size = new System.Drawing.Size(130, 55);
            this.osta_btn.TabIndex = 3;
            this.osta_btn.Text = "Osta pilet";
            this.osta_btn.UseVisualStyleBackColor = false;
            // 
            // filmid_pbox
            // 
            this.filmid_pbox.Image = ((System.Drawing.Image)(resources.GetObject("filmid_pbox.Image")));
            this.filmid_pbox.Location = new System.Drawing.Point(246, 66);
            this.filmid_pbox.Name = "filmid_pbox";
            this.filmid_pbox.Size = new System.Drawing.Size(136, 133);
            this.filmid_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmid_pbox.TabIndex = 4;
            this.filmid_pbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(433, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eelmine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filmid_pbox);
            this.Controls.Add(this.osta_btn);
            this.Controls.Add(this.vali_btn);
            this.Controls.Add(this.kava_btn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmid_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kava_btn;
        private System.Windows.Forms.Button vali_btn;
        private System.Windows.Forms.Button osta_btn;
        private System.Windows.Forms.PictureBox filmid_pbox;
        private System.Windows.Forms.Button button1;
    }
}

