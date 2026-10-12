namespace EventParkingReservation.Entities
{
    public class ParkingSlot
    {
        public int ParkingSlotId { get; set; }

        public int EventId { get; set; }

        public string SlotNumber { get; set; } = string.Empty;

        public string? Zone { get; set; }

        public string? VehicleType { get; set; }

        public decimal Fee { get; set; }

        public string Status { get; set; } = "Available";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Event Event { get; set; } = null!;

        public ICollection<ParkingReservation> ParkingReservations
        {
            get;
            set;
        } = new List<ParkingReservation>();
    }
}