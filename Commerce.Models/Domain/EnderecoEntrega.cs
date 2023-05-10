﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models.Domain
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string  Logradouro { get; set; }
        public string  Numero { get; set; }
        public string  Complemento { get; set; }
        public string  Bairro { get; set; }
        public string  Cep { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
