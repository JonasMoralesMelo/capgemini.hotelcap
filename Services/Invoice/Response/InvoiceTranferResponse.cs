using System;

namespace HotelTDD.Services.Invoice.Response
{
    public class InvoiceTranferResponse
    {
        public InvoiceTranferResponse(DateTime dateTime, double value, string hashAccountSource, string hashContaDestiny)
        {
            DateTime = dateTime;
            Value = value;
            HashAccountSource = hashAccountSource;
            HashContaDestiny = hashContaDestiny;
        }

        public DateTime DateTime { get; set; }
        public double Value { get; set; }
        public string HashAccountSource { get; set; }
        public string HashContaDestiny { get; set; }

    }
}
