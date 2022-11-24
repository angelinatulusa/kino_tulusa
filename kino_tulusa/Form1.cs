using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kino_tulusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a="film";
        private void kava_btn_Click(object sender, EventArgs e)
        {
            if (a=="film")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film1.jpg");
                a = "film2";
            }
            else if (a=="film2")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film2.jpg");
                a = "film3";
            }
            else if (a == "film3")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film3.jpg");
                a = "film4";
            }
            else
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film4.jpg");
                a = "film";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == "film")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film1.jpg");
                a = "film4";
            }
            else if (a == "film4")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film4.jpg");
                a = "film3";
            }
            else if (a == "film3")
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film3.jpg");
                a = "film2";
            }
            else
            {
                filmid_pbox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Tulusa_Tarpv21\kino_tulusa\kino_tulusa\filmid\film2.jpg");
                a = "film";
            }
        }
    }
}
