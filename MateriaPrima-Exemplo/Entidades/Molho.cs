using MateriaPrima_Exemplo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class Molho : Ingrediente
    {
        public TipoMolho Tipo { get; set; }

        public Molho(string marca, decimal preco, TipoMolho tipo)
            : base(marca, preco)
        {
            Tipo = tipo;
        }
    }

}
