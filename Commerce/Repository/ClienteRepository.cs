using Commerce.API.Data;
using Commerce.Models.Domain;

namespace Commerce.API.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private CommerceDbContext _db;
        public ClienteRepository(CommerceDbContext db)
        {
            _db = db;
        }

        public List<Cliente> GetAll()
        {
            return _db.Clientes.OrderBy(cl => cl.Id).ToList();
        }

        public Cliente Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
