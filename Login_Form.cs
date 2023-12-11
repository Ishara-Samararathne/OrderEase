using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Data.SqlClient;
using OrderEase.controller;
using OrderEase.model;

namespace OrderEase
{
    public partial class Login_Form : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KABNIEU\SQLEXPRESS;Initial Catalog=OrderEase;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        private UserController _userController;
        private OrderController _orderController;

        public Login_Form(UserController userController, OrderController orderController)
        {
            InitializeComponent();
            _userController = userController;
            _orderController = orderController;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelGetStarted.BackColor = Color.FromArgb(110,0,0,0);
            txtLoginPassword.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, password;
            email = txtLoginEmail.Text;
            password = txtLoginPassword.Text;

            try
            {
                User user = _userController.login(email, password);
                _orderController.setOrderUser(user);
                new Menu_Form(_orderController).Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void linkSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up_Form sign_Up_Form = new Sign_Up_Form(_userController);
            sign_Up_Form.Show();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}