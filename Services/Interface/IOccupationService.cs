using HotelTDD.Services.Occupation.Request;

namespace HotelTDD.Services.Interface
{
    public interface IOccupationService
    {
        void Create(OccupationCreateRequest request);
    }
}
