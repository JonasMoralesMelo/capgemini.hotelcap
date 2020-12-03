using System.Collections.Generic;

namespace HotelTDD.Services.Client.Response
{
    public class ClientListResponse
    {
        public ClientListResponse(string name, string cPF)
        {
            Name = name;
            CPF = cPF;
        }

        public string Name { get; set; }
        public string CPF { get; set; }

    }
}
