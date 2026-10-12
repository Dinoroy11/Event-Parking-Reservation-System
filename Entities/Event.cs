namespace EventParkingReservation.Entities
{
    public class Event
    {
        public int EventId { get; set; }

        public int VenueId { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime EventDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public decimal TicketPrice { get; set; }

        public decimal ParkingFee { get; set; }

        public int Capacity { get; set; }

        public string Status { get; set; } = "Upcoming";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Venue Venue { get; set; } = null!;

        public EventCategory EventCategory { get; set; } = null!;

        public ICollection<Seat> Seats { get; set; } = new List<Seat>();

        public ICollection<ParkingSlot> ParkingSlots { get; set; }
            = new List<ParkingSlot>();

        public ICollection<Booking> Bookings { get; set; }
            = new List<Booking>();
    }
}