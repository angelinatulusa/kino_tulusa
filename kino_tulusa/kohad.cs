using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kino_tulusa
{
    public class kohad : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\kino_tulusa\kino_tulusa\AppData\kino.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\kino_tulusa\kino_tulusa\AppData\kino.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        enum Nimetus { vaike,keskmine,suur};
        int Read;
        int Kohad;
        Button koht;
        public kohad(int read, int kohad)
        {
            Read = read;
            Kohad = kohad;
            Plaan(read,kohad);
        }
        public void Plaan(int read,int kohad)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.AutoSize = true;
            tlp.ColumnCount = read;
            tlp.RowCount = kohad;
            for (int i = 0; i < kohad; i++)
            {
                for (int j = 0; j < read; j++)
                {
                    koht = new Button
                    {
                        Text = i.ToString() + j.ToString(),
                        BackColor = Color.Green,
                        Size = new Size(40, 40)
                    };
                    tlp.Controls.Add(koht,j,i);
                    koht.Click += new EventHandler(Koht_Click);
                }
                //this.Width = (koht.Width + 55) * kohad;
                //this.Height = (koht.Height + 10) * read;
                this.AutoSize = true;
                this.Controls.Add(tlp);
            }
        }
        private void Koht_Click(object sender, EventArgs e)
        {
            Button klik =sender as Button;
            klik.BackColor = Color.Red; 
        }
    }
}
