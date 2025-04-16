using MateriaPrima_Exemplo.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Entidades
{
    public class Pizza
    {
        public TipoMolho Molho { get; set; }
        public TipoQueijo Queijo { get; set; }
        public TipoCarne Carne { get; set; }
        public TipoFarinha Farinha { get; set; }
        
        public double PrecoTotal { get; set; }
        public double PrecoFarinha { get; set; }
        public double PrecoQueijo { get; set; }
        public double PrecoCarne { get; set; }
        public double PrecoMolho { get; set; }

        public Pizza(TipoQueijo queijo, TipoMolho molho, TipoCarne carne, TipoFarinha farinha) 
        {
            Molho = molho;
            Queijo = queijo;
            Carne = carne;
            Farinha = farinha;
        }

        public Double CalcularPreco()
        {
           switch(Molho)
            {
                case TipoMolho.Tomate:
                    PrecoMolho = 10;
                    break;
                case TipoMolho.Branco:
                    PrecoMolho = 15;
                    break;
                case TipoMolho.Pesto:
                    PrecoMolho = 20;
                    break;

            }
            switch (Queijo)
            {
                case TipoQueijo.Mussarela:
                    PrecoQueijo = 15;
                    break;
                case TipoQueijo.Catupiry:
                    PrecoQueijo = 10;
                    break;
                case TipoQueijo.Cheddar:
                    PrecoQueijo = 15;
                    break;
            }
            switch (Carne)
            {
                case TipoCarne.Peperoni:
                    PrecoCarne = 30;
                    break;
                case TipoCarne.Frango:
                    PrecoCarne = 25;
                    break;
                case TipoCarne.Calabresa:
                    PrecoCarne = 20;
                    break;
            }
            switch (Farinha)
            {
                case TipoFarinha.Integral:
                    PrecoFarinha = 15;
                    break;
                case TipoFarinha.Tradicional:
                    PrecoFarinha = 10;
                    break;
                case TipoFarinha.SemGluten:
                    PrecoFarinha = 20;
                    break;
            }

            PrecoTotal = PrecoCarne + PrecoMolho + PrecoQueijo + PrecoFarinha;
            return PrecoTotal;
        }
    }

}
