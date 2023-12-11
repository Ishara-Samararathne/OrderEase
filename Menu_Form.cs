using OrderEase.controller;
using OrderEase.Images;
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
    public partial class Menu_Form : Form
    {
        private OrderController _orderController;

        public Menu_Form(OrderController orderController)
        {
            InitializeComponent();
            _orderController = orderController;
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BestSellers_Form bestSellers = new BestSellers_Form(_orderController);
            bestSellers.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(bestSellers);
            bestSellers.BringToFront();
            bestSellers.Show();
        }

        private void labelBurger_Click(object sender, EventArgs e)
        {
            Burger_Form burger = new Burger_Form();
            burger.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(burger);
            burger.BringToFront();
            burger.Show();
        }

        private void labelPasta_Click(object sender, EventArgs e)
        {
            Pasta_Form pasta = new Pasta_Form();
            pasta.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(pasta);
            pasta.BringToFront();
            pasta.Show();
        }

        private void labelPizza_Click(object sender, EventArgs e)
        {
            Pizza_Form pizza = new Pizza_Form();
            pizza.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(pizza);
            pizza.BringToFront();
            pizza.Show();
        }

        private void labelDesserts_Click(object sender, EventArgs e)
        {
            Desserts_Form desserts = new Desserts_Form();
            desserts.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(desserts);
            desserts.BringToFront();
            desserts.Show();
        }

        private void labelBeverages_Click(object sender, EventArgs e)
        {
            Beverages_Form beverages = new Beverages_Form();
            beverages.TopLevel = false;
            if (panelMenu.Controls.Count > 0)
                panelMenu.Controls.Clear();
            panelMenu.Controls.Add(beverages);
            beverages.BringToFront();
            beverages.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new Cart_Form(_orderController).Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            new OrderList_Form(_orderController).Show();
        }
    }
}
