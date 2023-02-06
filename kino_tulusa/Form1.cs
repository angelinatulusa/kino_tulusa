using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kino_tulusa
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\kino_tulusa\kino_tulusa\AppData\kino.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\kino_tulusa\kino_tulusa\AppData\kino.mdf;Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void osta_btn_Click(object sender, EventArgs e)
        {
            kysimused saal = new kysimused();
            saal.ShowDialog();
        }
        public int lugemine_esindus()
        {
            int lugemine = 0;
            cmd = new SqlCommand("SELECT * FROM Film", connect);
            connect.Open();
            using (SqlDataReader luge = cmd.ExecuteReader())
            {
                while (luge.Read())
                {
                    lugemine++;
                }
            }
            connect.Close();
            return lugemine;

        }
        public int id_number = 0;
        private void kava_btn_Click(object sender, EventArgs e)
        {
            id_number += 1;
            if (id_number <= 0)
            {
                id_number = lugemine_esindus();

            }
            cmd = new SqlCommand("SELECT * FROM Film WHERE filmId=@id", connect);
            connect.Open();
            cmd.Parameters.AddWithValue("@id", id_number);
            try
            {
                using (SqlDataReader lug = cmd.ExecuteReader())
                {
                    while (lug.Read())
                    {
                        filmid_pbox.Image = System.Drawing.Image.FromFile(@"..\..\filmid\" + (lug["pilt"].ToString()));
                        filmid_pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        nimi_lbl.Text = "Nimi: " + (lug["nimetus"].ToString());
                        autor_lbl.Text = "Autor: " + (lug["autor"].ToString());
                        kestvus_lbl.Text = "Kestus: " + (lug["kestvus"].ToString());
                        zanr_lbl.Text = "Zanr: " + (lug["zanr"].ToString());
                    }

                }
            }
            finally
            {
                connect.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            id_number -= 1;
            if (id_number <= 0)
            {
                id_number = lugemine_esindus();

            }
            cmd = new SqlCommand("SELECT * FROM Film WHERE filmId=@id", connect);
            connect.Open();
            cmd.Parameters.AddWithValue("@id", id_number);
            try
            {
                using (SqlDataReader lug = cmd.ExecuteReader())
                {
                    while (lug.Read())
                    {
                        filmid_pbox.Image = System.Drawing.Image.FromFile(@"..\..\filmid\" + (lug["pilt"].ToString()));
                        filmid_pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        nimi_lbl.Text = "Nimi: " + (lug["nimetus"].ToString());
                        autor_lbl.Text = "Autor: " + (lug["autor"].ToString());
                        kestvus_lbl.Text = "Kestus: " + (lug["kestvus"].ToString());
                        zanr_lbl.Text = "Zanr: " + (lug["zanr"].ToString());
                    }

                }
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
