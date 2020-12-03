using System;

namespace HotelTDD.Services.Occupation.Request
{
    public class OccupationCreateRequest
    {
        public OccupationCreateRequest(int dailyAmount, DateTime date, string situation, int clientId, int roomId)
        {
            DailyAmount = dailyAmount;
            Date = date;
            Situation = situation;
            ClientId = clientId;
            RoomId = roomId;
        }

        public int DailyAmount { get; set; }
        public DateTime Date { get; set; }
        public string Situation { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
    }
}
