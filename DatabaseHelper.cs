using OrderEase.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["OrderEaseConnectionString"].ConnectionString;
        }


        public void SaveUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string saveUserQuery = "INSERT INTO Users (UserName, Password, FirstName, LastName) VALUES (@UserName, @Password, @FirstName, @LastName)";
                SqlCommand saveUserCommand = new SqlCommand(saveUserQuery, connection);
                saveUserCommand.Parameters.AddWithValue("@UserName", user.email);
                saveUserCommand.Parameters.AddWithValue("@Password", user.password);
                saveUserCommand.Parameters.AddWithValue("@FirstName", user.firstName);
                saveUserCommand.Parameters.AddWithValue("@LastName", user.lastName);

                saveUserCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void CreateOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert the order
                string insertOrderQuery = "INSERT INTO Orders (CustomerId, OrderDate, OrderAmount) VALUES (@CustomerId, @OrderDate, @OrderAmount); SELECT SCOPE_IDENTITY();";
                SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                insertOrderCommand.Parameters.AddWithValue("@CustomerId", order.customer.userId);
                insertOrderCommand.Parameters.AddWithValue("@OrderAmount", order.total);
                insertOrderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                int orderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());

                // Insert order items
                foreach (var orderItem in order.OrderItems)
                {
                    string insertOrderItemQuery = "INSERT INTO OrderItems (OrderId, ProductId, Quantity, Price) VALUES (@OrderId, @ProductId, @Quantity, @Price)";
                    SqlCommand insertOrderItemCommand = new SqlCommand(insertOrderItemQuery, connection);
                    insertOrderItemCommand.Parameters.AddWithValue("@OrderId", orderId);
                    insertOrderItemCommand.Parameters.AddWithValue("@ProductId", orderItem.Product.id);
                    insertOrderItemCommand.Parameters.AddWithValue("@Quantity", orderItem.quantity);
                    insertOrderItemCommand.Parameters.AddWithValue("@Price", orderItem.price);
                    insertOrderItemCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        public User CheckLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkLoginQuery = "SELECT * FROM Users WHERE UserName = @Username AND Password = @Password";
                SqlCommand checkLoginCommand = new SqlCommand(checkLoginQuery, connection);
                checkLoginCommand.Parameters.AddWithValue("@Username", username);
                checkLoginCommand.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader itemReader = checkLoginCommand.ExecuteReader())
                {
                    while (itemReader.Read())
                    {
                        User user = new User();
                        user.userId = Convert.ToInt32(itemReader["UserId"]);
                        return user;
                    }
                }

                return null;
            }
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getOrdersQuery = "SELECT * FROM Orders WHERE CustomerId = @CustomerId";
                SqlCommand getOrdersCommand = new SqlCommand(getOrdersQuery, connection);
                getOrdersCommand.Parameters.AddWithValue("@CustomerId", customerId);

                using (SqlDataReader orderReader = getOrdersCommand.ExecuteReader())
                {
                    while (orderReader.Read())
                    {
                        Order order = new Order();
                        order.id = Convert.ToInt32(orderReader["OrderId"]);
                        order.createdDatetime = Convert.ToDateTime(orderReader["OrderDate"]);
                        order.total = Convert.ToDouble(orderReader["OrderAmount"]);
                        orders.Add(order);
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            string getOrderItemsQuery = "SELECT * FROM OrderItems WHERE OrderId = @OrderId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand getOrderItemsCommand = new SqlCommand(getOrderItemsQuery, connection);
                getOrderItemsCommand.Parameters.AddWithValue("@OrderId", orderId);

                using (SqlDataReader itemReader = getOrderItemsCommand.ExecuteReader())
                {
                    while (itemReader.Read())
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.Product = GetProductById(Convert.ToInt32(itemReader["ProductId"]));
                        orderItem.quantity = Convert.ToInt32(itemReader["Quantity"]);
                        orderItems.Add(orderItem);
                    }
                }

                connection.Close();
            }

            return orderItems;
        }

        private Product GetProductById(int productId)
        {
            string getProductByIdQuery = "SELECT * FROM Products WHERE ProductId = @ProductId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand getProductByIdCommand = new SqlCommand(getProductByIdQuery, connection);
                getProductByIdCommand.Parameters.AddWithValue("@ProductId", productId);

                using (SqlDataReader productReader = getProductByIdCommand.ExecuteReader())
                {
                    if (productReader.Read())
                    {
                        Product product = new Product();
                        product.id = Convert.ToInt32(productReader["ProductId"]);
                        product.name = productReader["ProductName"].ToString();
                        product.price = Convert.ToDouble(productReader["ProductPrice"]);
                        connection.Close();
                        return product;
                    }
                }

                connection.Close();
            }

            return null;
        }


        // Additional methods for retrieving products, orders, etc.
        public List<Product> GetAllProducts()
        {
            // Implement logic to retrieve products from the database
            throw new NotImplementedException();
        }

    }
}
