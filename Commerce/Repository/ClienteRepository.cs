using Commerce.API.Data;
using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;

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
            return _db.Clientes.Include(cl => cl.Telefones).Include(cl => cl.enderecoEntregas).OrderBy(cl => cl.Id).ToList();
        }

        public Cliente Get(int id)
        {
            return _db.Clientes.Include(cl => cl.Telefones).Include(cl => cl.enderecoEntregas).Single(x => x.Id == id);
        }

        public void Insert(Cliente cliente)
        {
            _db.Add(cliente);
            _db.SaveChanges();            
        }

        public void Update(Cliente cliente)
        {
            _db.Entry(cliente).State = EntityState.Modified;            
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
            _db.SaveChanges();
        }       
    }
}
