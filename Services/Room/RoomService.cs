using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Services.Interface;
using HotelTDD.Services.Room.Request;
using HotelTDD.Services.Room.Response;
using System.Collections.Generic;

namespace HotelTDD.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void Create(RoomCreateRequest request)
        {
            var room = new Rooms(request.BuildingFloor, request.RoomNum, request.Situation, request.TypeRoomId);

            _roomRepository.Create(room);
        }

        public Rooms Get()
        {
            return _roomRepository.Get();
        }

        public RoomListResponse GetById(int roomId)
        {
            Rooms rooms = _roomRepository.GetById(roomId);

            return new RoomListResponse() { BuildingFloor = rooms.BuildingFloor, RoomNum = rooms.RoomNum, Situation = rooms.Situation, TypeRoomId = rooms.TypeRoomId };
        }

        public IEnumerable<RoomListResponse> GetByTypeRoomId(int typeRoomId)
        {
            IEnumerable<Rooms> rooms = _roomRepository.GetByTypeRoomId(typeRoomId);
            var responseList = new List<RoomListResponse>();

            foreach (var room in rooms)
            {
                var response = new RoomListResponse()
                {
                    BuildingFloor = room.BuildingFloor,
                    RoomNum = room.RoomNum,
                    Situation = room.Situation,
                    TypeRoomId = room.TypeRoomId
                };

                responseList.Add(response);
            }

            return responseList;
        }

        public void Update(RoomUpdateRequest request)
        {
            Rooms room = _roomRepository.GetById(request.Id);

            room.ChangeSituation(request.Situation);

            _roomRepository.Update(room);
        }
    }
}
