using OrderEase.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.service
{
    public class OrderService
    {
        private DatabaseHelper _dbHelper;
        private Order _order;
        private User _user;

        public OrderService()
        {
            _dbHelper = new DatabaseHelper();
            _order = new Order();
        }

        public void addProductToOrder(Product product)
        {
            if (product == null)
            {
                throw new Exception("invalid user details");
            }

            _order.total += product.price;
            foreach (OrderItem oi in _order.OrderItems) {
                if (oi.Product.id == product.id)
                {
                    oi.price += product.price;
                    oi.quantity++;
                    return;
                }
            }

            OrderItem orderItem = new OrderItem();
            orderItem.Product = product;
            orderItem.quantity = 1;
            orderItem.price = product.price;
            this._order.OrderItems.Add(orderItem);
        }

        public void submitCurrentOrder() {
            _dbHelper.CreateOrder(_order);
            this.clearCart();
        }

        public void clearCart()
        {
            this._order = new Order();
        }

        public Order getCurrentOrder() {
            return this._order;
        }

        public List<Order> getCurrentUserOrders()
        {
            return _dbHelper.GetOrdersByCustomerId(_user.userId);
        }

        public List<OrderItem> getOrderItemsByOrderid(int orderId)
        {
            return _dbHelper.GetOrderItemsByOrderId(orderId);
        }

        public void setOrderUser(User user)
        {
            _order.customer = user;
            _user = user;
        }
    }
}
