using HotelTDD.Domain.Core;
using HotelTDD.Utils;

namespace HotelTDD.Domain
{
    public class TypeRooms : DomainBase
    {
        public TypeRooms(string description, double value)
        {
            RolesValidator.New()
                .When(string.IsNullOrEmpty(description), "Descrição inválida")
                .When(value <= 0.00, "Valor inválido")
                .ThrowExceptionIfExists();


            Description = description;
            Value = value;
        }

        public TypeRooms()
        {
        }

        public string Description { get; }
        public double Value { get; }
    }
}
