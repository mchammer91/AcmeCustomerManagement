namespace ACM.Win
{
    using System;
    using System.Windows.Forms;
    using ACM.BL;

    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PlaceOrder();
        }

        private void PlaceOrder()
        {
            Customer customer = new Customer();
            Order order = new Order();
            Payment payment = new Payment();

            bool allowSplitOrders = true;
            bool emailReceipt = true;

            OrderController orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReceipt);
        }
    }
}
