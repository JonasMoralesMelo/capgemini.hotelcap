using HotelTDD.Services.Interface;
using HotelTDD.Services.Invoice.Request;
using HotelTDD.Services.Invoice.Response;
using RestSharp;
using System.Threading.Tasks;

namespace HotelTDD.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {

        public Task<InvoiceTranferResponse> SendTranfer(InvoiceTransferRequest request)
        {
            var client = new RestClient("https://localhost:44387/");

            var requests = new RestRequest("/Operation/Tranfer").AddJsonBody(request);

            var response = client.PostAsync<InvoiceTranferResponse>(requests);

            return response;
        }
    }
}
