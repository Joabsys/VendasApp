using System;
using System.Collections.Generic;
using System.Text;
using VendasApp.Models.Enums;

namespace VendasApp.Models.Dto
{
    public class Inventario
    {
        public int Quantidade { get; set; }
        public OperacaoEnum.Operacao Operacao { get; set; }
    }
}
