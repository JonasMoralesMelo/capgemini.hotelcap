using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Services.Interface;
using HotelTDD.Services.Occupation.Request;

namespace HotelTDD.Services.Occupation
{
    public class OccupationService : IOccupationService
    {
        private readonly IOccupationRepository _occupationRepository;

        public OccupationService(IOccupationRepository occupationRepository)
        {
            _occupationRepository = occupationRepository;
        }

        public void Create(OccupationCreateRequest request)
        {
            Occupations occupations = new Occupations(request.DailyAmount, request.Date, request.ClientId, request.RoomId);
            _occupationRepository.Create(occupations);
        }
    }
}
