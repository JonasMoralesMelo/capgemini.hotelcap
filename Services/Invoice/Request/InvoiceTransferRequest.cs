namespace HotelTDD.Services.Invoice.Request
{
    public class InvoiceTransferRequest
    {
        public string HashDestiny { get; set; }
        public string HashSource { get; set; }
        public double Value { get; set; }
    }
}
