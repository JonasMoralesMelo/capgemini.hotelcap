using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Repository.Core;

namespace HotelTDD.Repository
{
    public class OccupationRepository : RepositoryCore, IOccupationRepository
    {
        public OccupationRepository(Infra.Context.HotelContext hotelContext) : base(hotelContext)
        {
        }

        public void Create(Occupations occupations)
        {
            _hotelContext.Occupation.Add(occupations);
            _hotelContext.SaveChanges();
        }
    }
}
