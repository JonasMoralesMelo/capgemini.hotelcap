using HotelTDD.Services.Interface;
using HotelTDD.Services.Invoice.Request;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelTDD.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public IActionResult SendTranfer([FromBody] InvoiceTransferRequest request)
        {
            try
            {
                return Ok(_invoiceService.SendTranfer(request));
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel enviar o pedido de transferencia: {ex}");
            }
        }
    }
}
