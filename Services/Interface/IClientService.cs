using HotelTDD.Services.Client.Request;
using HotelTDD.Services.Client.Response;
using System.Collections.Generic;

namespace HotelTDD.Services.Interface
{
    public interface IClientService
    {
        void Create(ClientCreateRequest request);
        ClientListResponse GetById(int id);
    }
}
