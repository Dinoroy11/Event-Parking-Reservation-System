namespace EventParkingReservation.Entities
{
    public class BookingSeat
    {
        public int BookingSeatId { get; set; }

        public int BookingId { get; set; }

        public int SeatId { get; set; }

        public decimal Price { get; set; }

        // Navigation Properties
        public Booking Booking { get; set; } = null!;

        public Seat Seat { get; set; } = null!;
    }
}