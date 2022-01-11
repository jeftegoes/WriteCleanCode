using System.Net.Mail;

namespace Comments
{
    public class Comment
    {
        private int _pf;  // pay frequency
        private List<Order> _orders;

        public Comment()
        {
            _orders = new List<Order>();
        }

        // Returns list of customers in a country.
        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: We need to get rid of abcd once we revisit this method. Currently, it's 
            // creating a coupling betwen x and y and because of that we're not able to do 
            // xyz. 

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            // Save order to the database
            _orders.Add(order);

            // Send an email to the customer
            var client = new SmtpClient();
            var message = new MailMessage("noreply@site.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);

        }
    }
}