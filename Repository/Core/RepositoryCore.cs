using HotelTDD.Infra.Context;

namespace HotelTDD.Repository.Core
{
    public class RepositoryCore
    {
        protected readonly HotelContext _hotelContext;

        public RepositoryCore(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }
    }
}
