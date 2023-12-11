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
    public partial class Cart_Form : Form
    {
        private OrderController _orderController;


        public Cart_Form(OrderController orderController)
        {
            InitializeComponent();
            _orderController = orderController;
            LoadOrderItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _orderController.submitCurrentOrder();
            MessageBox.Show("Your order has been successfully created");
            this.Close();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cart_Form_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrderItems()
        {
            // Assuming dgvOrderItems is the DataGridView control on your form
            dataGridView1.Rows.Clear();
            Order order = _orderController.getCurrentOrder();
            foreach (var orderItem in order.OrderItems)
            {
                // Assuming you have properties like ProductName, Quantity, and Price in your OrderItem class
                dataGridView1.Rows.Add(orderItem.Product.name, orderItem.quantity, orderItem.quantity * orderItem.Product.price);
            }
            txtTotal.Text = order.total.ToString();
        }
    }
}
