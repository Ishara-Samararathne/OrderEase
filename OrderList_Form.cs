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
    public partial class OrderList_Form : Form
    {
        private OrderController _orderController;

        public OrderList_Form(OrderController orderController)
        {
            InitializeComponent();
            _orderController = orderController;
            LoadOrders();
        }

        private void LoadOrders()
        {
            ordersGridView.Rows.Clear();
            List<Order> orders = _orderController.getCurrentUserOrders();
            foreach (var order in orders)
            {
                ordersGridView.Rows.Add(order.id, order.createdDatetime, order.total);
            }
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ordersGridView_MouseClick(object sender, MouseEventArgs e)
        {
            orderDetailGridView.Rows.Clear();
            if (ordersGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = ordersGridView.SelectedRows[0];


                int orderId = Convert.ToInt32(selectedRow.Cells["orderNo"].Value);


                List<OrderItem> orderItems = _orderController.getOrderItemsByOrderid(orderId);
                foreach (var item in orderItems)
                {
                    // Assuming you have properties like ProductName, Quantity, and Price in your OrderItem class
                    orderDetailGridView.Rows.Add(item.Product.name, item.quantity, item.quantity * item.price);
                }
            }
        }
    }
}
