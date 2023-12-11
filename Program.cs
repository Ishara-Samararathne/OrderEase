using OrderEase.controller;

namespace OrderEase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            UserController userController = new UserController();   
            OrderController orderController = new OrderController();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login_Form(userController, orderController));
        }
    }
}