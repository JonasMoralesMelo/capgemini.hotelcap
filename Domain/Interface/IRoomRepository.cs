using HotelTDD.Services.Room.Request;
using System.Collections.Generic;

namespace HotelTDD.Domain.Interface
{
    public interface IRoomRepository
    {
        Rooms Get();
        void Create(Rooms room);
        Rooms GetById(int id);
        void Update(Rooms room);
        IEnumerable<Rooms> GetByTypeRoomId(int typeRoomId);
    }
}
