using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Articulo
    {
        int IDArticulo { get; set; }
        string NombreArticulo { get; set; }
        string DescripcionArticulo { get; set; }
        decimal PrecioArticulo { get; set; }
        Marca MarcaArticulo { get; set; }
        Categoria CategoriaArticulo { get; set; }
        List<Imagen> Imagenes { get; set; }
    }
}
