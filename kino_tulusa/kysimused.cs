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
    public partial class kysimused : Form
    {
        Label kysimus;
        Button vaike,keskmine,suur;
        public kysimused()
        {
            InitializeComponent();
            vaike = new Button
            {
                Text = "vaike",
                Size = new System.Drawing.Size(100, 60),
                Location = new System.Drawing.Point(50, 75),
                BackColor = System.Drawing.Color.RosyBrown,
                Font = new Font("Arial", 15, FontStyle.Bold),
            };
            keskmine = new Button
            {
                Text = "keskmine E",
                Size = new System.Drawing.Size(110, 60),
                Location = new System.Drawing.Point(180, 75),
                BackColor = System.Drawing.Color.RosyBrown,
                Font = new Font("Arial", 15, FontStyle.Bold),
            };
            suur = new Button
            {
                Text = "suur",
                Size = new System.Drawing.Size(100, 60),
                Location = new System.Drawing.Point(315, 75),
                BackColor = System.Drawing.Color.RosyBrown,
                Font = new Font("Arial", 15, FontStyle.Bold),
            };

            this.Controls.Add(vaike);
            this.Controls.Add(keskmine);
            this.Controls.Add(suur);
        }

    }
}
