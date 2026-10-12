namespace EventParkingReservation.Entities
{
    public class Seat
    {
        public int SeatId { get; set; }

        public int EventId { get; set; }

        public string Row { get; set; } = string.Empty;

        public int SeatNumber { get; set; }

        public string SeatType { get; set; } = "Regular";

        public decimal? Price { get; set; }

        public string Status { get; set; } = "Available";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Event Event { get; set; } = null!;

        public ICollection<BookingSeat> BookingSeats { get; set; }
            = new List<BookingSeat>();
    }
}