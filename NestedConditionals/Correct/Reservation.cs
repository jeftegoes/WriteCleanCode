namespace NestedConditionals
{
    public class Reservation
    {
        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public void Cancel()
        {
            if (IsCancellationPeriodOver())
                throw new InvalidOperationException("It's too late to cancel.");

            IsCanceled = true;
        }

        private bool IsCancellationPeriodOver() =>
            Customer.IsGoldCustomer() && LessThan(24) || !Customer.IsGoldCustomer() && LessThan(48);

        private bool LessThan(int maxHours) =>
            ((From - DateTime.Now).TotalHours < maxHours);
    }
}