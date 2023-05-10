
namespace Commerce.Models.Domain
{
    public class Telefone
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Celular { get; set; }
        public string Comercial { get; set; }
        public Cliente? Cliente { get; set;}
    }
}
