namespace NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }

        public bool IsGoldCustomer() =>
            LoyaltyPoints > 100;
    }
}