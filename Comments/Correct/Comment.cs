using System.Net.Mail;

namespace Comments
{
    public class Comment
    {
        private int _payFrequency;
        private List<Order> _orders;

        public Comment()
        {
            _orders = new List<Order>();
        }

        /// <summary>
        /// Returns list of customers.
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: We need to get rid of abcd once we revisit this method. Currently, it's 
            // creating a coupling betwen x and y and because of that we're not able to do 
            // xyz. 

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            SaveOrder(order);
            NotifyCustomer(order);
        }

        public void SaveOrder(Order order)
        {
            _orders.Add(order);
        }

        public void NotifyCustomer(Order order)
        {
            var client = new SmtpClient();
            var message = new MailMessage("noreply@site.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);
        }
    }
}