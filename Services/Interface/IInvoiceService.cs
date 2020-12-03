using HotelTDD.Services.Invoice.Request;
using HotelTDD.Services.Invoice.Response;
using System.Threading.Tasks;

namespace HotelTDD.Services.Interface
{
    public interface IInvoiceService
    {
        Task<InvoiceTranferResponse> SendTranfer(InvoiceTransferRequest request);
    }
}
