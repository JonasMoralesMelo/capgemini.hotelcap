using HotelTDD.Domain.Core;
using HotelTDD.Utils;
using System;

namespace HotelTDD.Domain
{
    public class Occupations : DomainBase
    {
        public Occupations(int dailyAmount, DateTime date, int clientId, int roomId)
        {
            RolesValidator.New()
                .When(dailyAmount <= 0, "Número de diária inválida.")
                .When(clientId <= 0, "Cliente inválido.")
                .When(roomId <= 0, "Quarto inválida.")
                .ThrowExceptionIfExists();

            DailyAmount = dailyAmount;
            Date = date;
            ClientId = clientId;
            RoomId = roomId;
        }

        public int DailyAmount { get; set; }
        public DateTime Date { get; set; }
        public string Situation { get; set; }


        public int ClientId { get; set; }
        public Clients Client { get; set; }

        public int RoomId { get; set; }
        public Rooms Rooms { get; set; }
    }
}
