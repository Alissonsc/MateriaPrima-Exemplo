using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class Pizza
    {
        public Molho Molho { get; set; }
        public Mussarela Queijo { get; set; }
        public Peperoni Carne { get; set; }
        public FarinhaDeTrigo Farinha { get; set; }

        public decimal CalcularPreco()
        {
            return Molho.Preco + Queijo.Preco + Carne.Preco + Farinha.Preco;
        }
    }

}
