using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using OrderEase.model;
using OrderEase.controller;

namespace OrderEase
{
    public partial class Sign_Up_Form : Form
    {
      
        private UserController _userController;

        public Sign_Up_Form(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new Login_Form(_userController).ShowDialog();
            this.Close();
        }

        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
          
            try
            {
                User user = new User();
                user.firstName = txtFirstname.Text;
                user.lastName = txtLastname.Text;
                user.email = txtEmail.Text;
                user.password = txtPassword.Text;

                _userController.saveUser(user);
                MessageBox.Show("User Successfully Added");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
        }

        public void clear()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
