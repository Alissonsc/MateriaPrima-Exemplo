using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public abstract class Ingrediente
    {
        public string Marca { get; set; }
        public decimal Preco { get; set; }

        protected Ingrediente(string marca, decimal preco)
        {
            Marca = marca;
            Preco = preco;
        }
    }

}
