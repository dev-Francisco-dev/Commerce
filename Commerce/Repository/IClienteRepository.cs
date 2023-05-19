using Commerce.Models.Domain;

namespace Commerce.API.Repository
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente Get(int id);
        void Insert(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);

    }
}
