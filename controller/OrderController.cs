using OrderEase.model;
using OrderEase.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.controller
{
    public class OrderController
    {
        private OrderService _orderService; 

        public OrderController()
        {
            _orderService = new OrderService();
        }

        public void addProductToOrder(Product product)
        {
           _orderService.addProductToOrder(product);
        }

        public void submitCurrentOrder()
        {
            _orderService.submitCurrentOrder();
        }

        public Order getCurrentOrder() {
            return _orderService.getCurrentOrder();
        }

        public List<Order> getCurrentUserOrders() {
            return _orderService.getCurrentUserOrders();
        }

        public List<OrderItem> getOrderItemsByOrderid(int orderId)
        {
            return _orderService.getOrderItemsByOrderid(orderId);
        }

        public void setOrderUser(User user) {
            _orderService.setOrderUser(user);
        }
    }
}
