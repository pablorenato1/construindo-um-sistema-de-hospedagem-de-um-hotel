using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construindo_um_sistema_de_hospedagem_de_um_hotel.models
{
    public class Suite
    {
        string TipoSuite { get; set; }
        int Capacidade { get; set; }
        decimal ValorDiaria {get;set;}
    }
}