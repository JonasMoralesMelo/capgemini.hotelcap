using HotelTDD.Domain;
using HotelTDD.Domain.Interface;
using HotelTDD.Services.Client.Request;
using HotelTDD.Services.Client.Response;
using HotelTDD.Services.Interface;

namespace HotelTDD.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Create(ClientCreateRequest request)
        {
            var client = new Clients(request.Name, request.CPF, request.Hashs);

            _clientRepository.Create(client);
        }

        public ClientListResponse GetById(int id)
        {
            Clients client = _clientRepository.GetById(id);

            return new ClientListResponse(client.Name, client.CPF);
        }
    }
}
