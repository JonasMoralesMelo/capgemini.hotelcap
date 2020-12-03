using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Infra.Context;
using HotelTDD.Repository.Core;
using System.Collections.Generic;
using System.Linq;

namespace HotelTDD.Repository
{
    public class RoomRepository : RepositoryCore,  IRoomRepository
    {
        public RoomRepository(HotelContext hotelContext) : base(hotelContext)
        {
        }

        public void Create(Rooms room)
        {
            _hotelContext.Rooms.Add(room);
            _hotelContext.SaveChanges();
        }

        public Rooms Get()
        {
            Rooms room = new Rooms(55, 201, "A", 1);

            return room;
        }

        public Rooms GetById(int id)
        {
            return _hotelContext.Rooms.Find(id);
        }

        public IEnumerable<Rooms> GetByTypeRoomId(int typeRoomId)
        {
            return _hotelContext.Rooms.Where(e => e.TypeRoomId == typeRoomId).ToList();
        }

        public void Update(Rooms room)
        {
            _hotelContext.Rooms.Update(room);
            _hotelContext.SaveChanges();
        }
    }
}
