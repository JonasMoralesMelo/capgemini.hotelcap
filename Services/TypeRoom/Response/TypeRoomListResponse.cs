namespace HotelTDD.Services.TypeRoom.Response
{
    public class TypeRoomListResponse
    {
        public TypeRoomListResponse(string description, double value)
        {
            Description = description;
            Value = value;
        }

        public string Description { get; set; }
        public double Value { get; set; }

    }
}
