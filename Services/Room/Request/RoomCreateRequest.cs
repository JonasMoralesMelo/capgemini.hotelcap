namespace HotelTDD.Services.Room.Request
{
    public class RoomCreateRequest
    {
        public int BuildingFloor { get; set; }
        public int RoomNum { get; set; }
        public string Situation { get; set; }
        public int TypeRoomId { get; set; }
    }
}
