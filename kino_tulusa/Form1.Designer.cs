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
            this.osta_btn = new System.Windows.Forms.Button();
            this.filmid_pbox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nimi_lbl = new System.Windows.Forms.Label();
            this.autor_lbl = new System.Windows.Forms.Label();
            this.kestvus_lbl = new System.Windows.Forms.Label();
            this.zanr_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmid_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kava_btn
            // 
            this.kava_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.kava_btn.Location = new System.Drawing.Point(688, 123);
            this.kava_btn.Margin = new System.Windows.Forms.Padding(4);
            this.kava_btn.Name = "kava_btn";
            this.kava_btn.Size = new System.Drawing.Size(83, 63);
            this.kava_btn.TabIndex = 1;
            this.kava_btn.Text = "Järgmine";
            this.kava_btn.UseVisualStyleBackColor = false;
            this.kava_btn.Click += new System.EventHandler(this.kava_btn_Click);
            // 
            // osta_btn
            // 
            this.osta_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.osta_btn.Location = new System.Drawing.Point(53, 123);
            this.osta_btn.Margin = new System.Windows.Forms.Padding(4);
            this.osta_btn.Name = "osta_btn";
            this.osta_btn.Size = new System.Drawing.Size(173, 68);
            this.osta_btn.TabIndex = 3;
            this.osta_btn.Text = "Vali piletid";
            this.osta_btn.UseVisualStyleBackColor = false;
            this.osta_btn.Click += new System.EventHandler(this.osta_btn_Click);
            // 
            // filmid_pbox
            // 
            this.filmid_pbox.Image = ((System.Drawing.Image)(resources.GetObject("filmid_pbox.Image")));
            this.filmid_pbox.Location = new System.Drawing.Point(328, 86);
            this.filmid_pbox.Margin = new System.Windows.Forms.Padding(4);
            this.filmid_pbox.Name = "filmid_pbox";
            this.filmid_pbox.Size = new System.Drawing.Size(181, 164);
            this.filmid_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmid_pbox.TabIndex = 4;
            this.filmid_pbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(573, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eelmine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nimi_lbl
            // 
            this.nimi_lbl.AutoSize = true;
            this.nimi_lbl.Location = new System.Drawing.Point(336, 254);
            this.nimi_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nimi_lbl.Name = "nimi_lbl";
            this.nimi_lbl.Size = new System.Drawing.Size(0, 16);
            this.nimi_lbl.TabIndex = 6;
            // 
            // autor_lbl
            // 
            this.autor_lbl.AutoSize = true;
            this.autor_lbl.Location = new System.Drawing.Point(336, 286);
            this.autor_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autor_lbl.Name = "autor_lbl";
            this.autor_lbl.Size = new System.Drawing.Size(0, 16);
            this.autor_lbl.TabIndex = 7;
            // 
            // kestvus_lbl
            // 
            this.kestvus_lbl.AutoSize = true;
            this.kestvus_lbl.Location = new System.Drawing.Point(336, 315);
            this.kestvus_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kestvus_lbl.Name = "kestvus_lbl";
            this.kestvus_lbl.Size = new System.Drawing.Size(0, 16);
            this.kestvus_lbl.TabIndex = 8;
            // 
            // zanr_lbl
            // 
            this.zanr_lbl.AutoSize = true;
            this.zanr_lbl.Location = new System.Drawing.Point(336, 342);
            this.zanr_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zanr_lbl.Name = "zanr_lbl";
            this.zanr_lbl.Size = new System.Drawing.Size(0, 16);
            this.zanr_lbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 411);
            this.Controls.Add(this.zanr_lbl);
            this.Controls.Add(this.kestvus_lbl);
            this.Controls.Add(this.autor_lbl);
            this.Controls.Add(this.nimi_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filmid_pbox);
            this.Controls.Add(this.osta_btn);
            this.Controls.Add(this.kava_btn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmid_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kava_btn;
        private System.Windows.Forms.Button osta_btn;
        private System.Windows.Forms.PictureBox filmid_pbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nimi_lbl;
        private System.Windows.Forms.Label autor_lbl;
        private System.Windows.Forms.Label kestvus_lbl;
        private System.Windows.Forms.Label zanr_lbl;
    }
}

