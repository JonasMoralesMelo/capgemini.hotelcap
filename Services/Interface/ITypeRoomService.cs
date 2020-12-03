using HotelTDD.Services.TypeRoom.Request;
using HotelTDD.Services.TypeRoom.Response;
using System.Collections.Generic;

namespace HotelTDD.Services.Interface
{
    public interface ITypeRoomService
    {
        void Create(TypeRoomCreateRequest request);
        TypeRoomListResponse GetById(int id);
        IEnumerable<TypeRoomListResponse> GetAll();
    }
}
