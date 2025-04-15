using MateriaPrima_Exemplo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class Mussarela : Ingrediente
    {
        public TipoQueijo Tipo { get; set; }

        public Mussarela(string marca, decimal preco, TipoQueijo tipo)
            : base(marca, preco)
        {
            Tipo = tipo;
        }
    }

}
