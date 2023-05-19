using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Commerce.Models.Domain
{
    public class Estado
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
    }
}
