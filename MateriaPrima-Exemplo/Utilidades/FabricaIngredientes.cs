using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaPrima_Exemplo.Utilidades
{
    using MateriaPrima_Exemplo.Entidades;
    using MateriaPrima_Exemplo.Enumeradores;
    using System.Collections.Generic;

    public static class FabricaIngredientes
    {
        public static List<Molho> ObterMolhos() => new List<Molho>
    {
        new Molho("Pomarola", 2.50m, TipoMolho.Tomate),
        new Molho("Tarantella", 3.00m, TipoMolho.Tomate),
        new Molho("Tradicional", 1.80m, TipoMolho.Branco)
    };

        public static List<Mussarela> ObterQueijos() => new List<Mussarela>
    {
        new Mussarela("Italac", 5.00m, TipoQueijo.Mussarela),
        new Mussarela("Scala", 6.50m, TipoQueijo.Prato),
        new Mussarela("Piracanjuba", 4.80m, TipoQueijo.Cheddar)
    };

        public static List<Peperoni> ObterCarnes() => new List<Peperoni>
    {
        new Peperoni("Sadia", 4.00m, TipoCarne.Peperoni),
        new Peperoni("Perdigão", 4.20m, TipoCarne.Frango),
        new Peperoni("Aurora", 3.80m, TipoCarne.Calabresa)
    };

        public static List<FarinhaDeTrigo> ObterFarinha() => new List<FarinhaDeTrigo>
    {
        new FarinhaDeTrigo("Dona Benta", 2.00m, TipoFarinha.Tradicional),
        new FarinhaDeTrigo("Anaconda", 2.50m, TipoFarinha.Integral),
        new FarinhaDeTrigo("Renata", 3.00m, TipoFarinha.SemGluten)
    };
    }

}
