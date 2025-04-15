using MateriaPrima_Exemplo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class Peperoni : Ingrediente
    {
        public TipoCarne Tipo { get; set; }

        public Peperoni(string marca, decimal preco, TipoCarne tipo)
            : base(marca, preco)
        {
            Tipo = tipo;
        }
    }

}
