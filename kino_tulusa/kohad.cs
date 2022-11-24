using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kino_tulusa
{
    public class kohad : Form
    {
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
                this.Width = (koht.Width + 5) * kohad;
                this.Height = (koht.Height + 35) * read;
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
