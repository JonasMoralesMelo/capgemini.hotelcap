using HotelTDD.Services.Occupation.Request;

namespace HotelTDD.Domain.Interface
{
    public interface IOccupationRepository
    {
        void Create(Occupations occupations);
    }
}
