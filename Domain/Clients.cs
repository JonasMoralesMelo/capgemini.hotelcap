using HotelTDD.Domain.Core;
using HotelTDD.Utils;

namespace HotelTDD.Domain
{
    public class Clients : DomainBase
    {
        public Clients(string name, string cPF, string hashs)
        {
            RolesValidator.New()
                .When(string.IsNullOrEmpty(name), "Nome inválido")
                .When(string.IsNullOrEmpty(cPF), "Nome inválido")
                .When(string.IsNullOrEmpty(hashs), "Nome inválido")
                .ThrowExceptionIfExists();

            Name = name;
            CPF = cPF;
            Hashs = hashs;
        }

        public string Name { get; set; }
        public string CPF { get; set; }
        public string Hashs { get; set; }
    }
}
