namespace LongParameterList
{
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(
            ReservationQuery reservationQuery)
        {
            if (reservationQuery.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateFrom");
            if (reservationQuery.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(
            ReservationQuery reservationQuery)
        {
            if (reservationQuery.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateFrom");
            if (reservationQuery.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(
            DateRange dateRange,
            ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(
            DateRange dateRange,
            int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateRange.DateTo");

            throw new NotImplementedException();
        }
    }
}