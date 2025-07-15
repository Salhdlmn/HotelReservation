namespace ReservationHotel.Models
{
    public class SearchHotelViewModel
    {
        public string City { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Adults { get; set; }
        public int Rooms { get; set; }
    }
}
