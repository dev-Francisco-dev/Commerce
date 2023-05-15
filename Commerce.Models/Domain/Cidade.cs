using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models.Domain
{
    public class Cidade
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int EnderecoEntregaId { get; set; }
        public ICollection< EnderecoEntrega>? EnderecoEntrega { get; set; }
    }

}
