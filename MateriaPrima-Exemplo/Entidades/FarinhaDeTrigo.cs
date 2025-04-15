using MateriaPrima_Exemplo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class FarinhaDeTrigo : Ingrediente
    {
        public TipoFarinha Tipo { get; set; }

        public FarinhaDeTrigo(string marca, decimal preco, TipoFarinha tipo)
            : base(marca, preco)
        {
            Tipo = tipo;
        }
    }

}
