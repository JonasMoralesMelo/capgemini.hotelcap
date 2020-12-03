using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Infra.Context;
using HotelTDD.Repository.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelTDD.Repository
{
    public class ClientRepository : RepositoryCore, IClientRepository
    {
        public ClientRepository(HotelContext hotelContext) : base(hotelContext)
        {
        }

        public void Create(Clients client)
        {
            
            _hotelContext.Client.Add(client);
            _hotelContext.SaveChanges();
        }

        public Clients GetById(int id)
        {
            return _hotelContext.Client.AsNoTracking().Where(e => e.Id == id).FirstOrDefault();
        }
        public List<Clients> GetListClient()
        {
            return _hotelContext.Client.ToList();
        }

    }
}
