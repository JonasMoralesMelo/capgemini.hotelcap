using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Infra.Context;
using HotelTDD.Repository.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelTDD.Repository
{
    public class TypeRoomRepository : RepositoryCore,  ITypeRoomRepository
    {
        public TypeRoomRepository(HotelContext hotelContext) : base(hotelContext)
        {
        }

        public void Create(TypeRooms typeRoom)
        {
            _hotelContext.TypeRoom.Add(typeRoom);
            _hotelContext.SaveChanges();
        }

        public IEnumerable<TypeRooms> GetAll()
        {
            return _hotelContext.TypeRoom.AsNoTracking().Where(e => e.Description != null);
        }

        public TypeRooms GetById(int id)
        {
            return _hotelContext.TypeRoom.AsNoTracking().Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
