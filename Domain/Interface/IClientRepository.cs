namespace HotelTDD.Domain.Interface
{
    public interface IClientRepository
    {
        void Create(Clients client);
        Clients GetById(int id);
    }
}
