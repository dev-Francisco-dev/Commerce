using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { set;  get; }
        public string CpfOuCnpj { set;  get; }
        public ICollection<Telefone>? Telefones { get; set; }
        public ICollection<EnderecoEntrega>? enderecoEntregas { get; set; }
    }
}
