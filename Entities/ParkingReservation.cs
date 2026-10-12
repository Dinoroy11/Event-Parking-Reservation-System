namespace EventParkingReservation.Entities
{
    public class ParkingReservation
    {
        public int ParkingReservationId { get; set; }

        public int BookingId { get; set; }

        public int ParkingSlotId { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Booking Booking { get; set; } = null!;

        public ParkingSlot ParkingSlot { get; set; } = null!;
    }
}