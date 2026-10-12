namespace EventParkingReservation.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int CustomerId { get; set; }

        public int EventId { get; set; }

        public string BookingNumber { get; set; } = string.Empty;

        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = "Pending";

        public DateTime? HoldExpiresAt { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Customer Customer { get; set; } = null!;

        public Event Event { get; set; } = null!;

        public ICollection<BookingSeat> BookingSeats { get; set; }
            = new List<BookingSeat>();

        public ParkingReservation? ParkingReservation { get; set; }

        public Payment? Payment { get; set; }
    }
}