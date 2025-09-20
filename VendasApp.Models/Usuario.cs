using System;
using System.Collections.Generic;
using System.Text;

namespace VendasApp.Models
{
    public class Usuario
    {
        public int? Id { get; set; }
        public bool? Ativo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
    }
}
