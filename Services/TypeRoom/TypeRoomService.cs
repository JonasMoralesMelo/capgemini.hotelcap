using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Services.Interface;
using HotelTDD.Services.TypeRoom.Request;
using HotelTDD.Services.TypeRoom.Response;
using System.Collections.Generic;

namespace HotelTDD.Services.TypeRoom
{
    public class TypeRoomService : ITypeRoomService
    {
        private readonly ITypeRoomRepository _typeRoomRepository;

        public TypeRoomService(ITypeRoomRepository typeRoomRepository)
        {
            _typeRoomRepository = typeRoomRepository;
        }

        public void Create(TypeRoomCreateRequest request)
        {
            var typeRoom = new TypeRooms(request.Description, request.Value);

            _typeRoomRepository.Create(typeRoom);
        }

        public IEnumerable<TypeRoomListResponse> GetAll()
        {
            var typeRooms = _typeRoomRepository.GetAll();

            var responses = new List<TypeRoomListResponse>();

            foreach (var typeRoom in typeRooms)
            {
                var response = new TypeRoomListResponse(typeRoom.Description, typeRoom.Value);
                responses.Add(response);
            }

            return responses;
        }

        public TypeRoomListResponse GetById(int id)
        {
            TypeRooms typeRoom = _typeRoomRepository.GetById(id);

            return new TypeRoomListResponse(typeRoom.Description, typeRoom.Value);
        }
    }
}
