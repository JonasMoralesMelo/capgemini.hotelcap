using HotelTDD.Domain;
using HotelTDD.Services.Room.Request;
using HotelTDD.Services.Room.Response;
using System.Collections.Generic;

namespace HotelTDD.Services.Interface
{
    public interface IRoomService
    {
        Rooms Get();
        void Create(RoomCreateRequest request);
        void Update(RoomUpdateRequest request);
        RoomListResponse GetById(int roomId);
        IEnumerable<RoomListResponse> GetByTypeRoomId(int typeRoomId);
    }
}
