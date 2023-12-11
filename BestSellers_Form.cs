using OrderEase.controller;
using OrderEase.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderEase
{
    public partial class BestSellers_Form : Form
    {

        private OrderController _orderController;

        public BestSellers_Form(OrderController orderController)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this._orderController = orderController;
        }

        private void BestSellers_Form_Load(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTBCAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.id = 4;
            product.name = "Texas BBQ Chicken";
            product.price = 1099;
            _orderController.addProductToOrder(product);
            //product.set
        }

        private void btnTCBAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSSAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMFPAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCLCAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBCCBAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlbestsellers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
