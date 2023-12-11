using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderEase.Images
{
    public partial class Desserts_Form : Form
    {
        public Desserts_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Desserts_Form_Load(object sender, EventArgs e)
        {
            labelPrice1.Parent = pictureBox2;
            labelPrice1.BackColor = Color.Transparent;

            labelPrice2.Parent = pictureBox3;
            labelPrice2.BackColor = Color.Transparent;

            labelPrice3.Parent = pictureBox4;
            labelPrice3.BackColor = Color.Transparent;

            labelPrice4.Parent = pictureBox1;
            labelPrice4.BackColor = Color.Transparent;

            labelPrice5.Parent = pictureBox6;
            labelPrice5.BackColor = Color.Transparent;

            labelPrice6.Parent = pictureBox7;
            labelPrice6.BackColor = Color.Transparent;
        }
    }
}
