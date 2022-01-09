namespace LongParameterList
{
    public class ReservationQuery
    {
        public DateRange DateRange { get; set; }
        public User user { get; set; }
        public int locationId { get; set; }
        public LocationType locationType { get; set; }
        public int? customerId = null;
    }
}