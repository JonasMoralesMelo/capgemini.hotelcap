using HotelTDD.Domain.Core;
using HotelTDD.Utils;

namespace HotelTDD.Domain
{
    public class Rooms : DomainBase
    {
        public Rooms(int buildingFloor, int roomNum, string situation, int typeRoomId)
        {
            RolesValidator.New()
                    .When(buildingFloor <= 0, "Andar inválido")
                    .When(roomNum <= 0, "Número do quarto inválido")
                    .When(string.IsNullOrEmpty(situation), "Situação inválida")
                    .When(typeRoomId <= 0, "Tipo do quarto inválido");


            BuildingFloor = buildingFloor;
            RoomNum = roomNum;
            Situation = situation;
            TypeRoomId = typeRoomId;
        }

        public Rooms()
        {
        }

        public int BuildingFloor { get; }
        public int RoomNum { get; }
        public string Situation { get; private set; }

        public int TypeRoomId { get; }
        public TypeRooms TypeRoom { get; }


        public void ChangeSituation(string situation)
        {
            Situation = situation;
        }
    }
}
