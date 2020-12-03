using System.Collections.Generic;

namespace HotelTDD.Domain.Interface
{
    public interface ITypeRoomRepository
    {
        void Create(TypeRooms typeRoom);
        TypeRooms GetById(int id);
        IEnumerable<TypeRooms> GetAll();
    }
}
