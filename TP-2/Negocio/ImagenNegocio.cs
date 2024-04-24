using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using AccesoDataBase;

namespace Negocio
{
    public class ImagenNegocio
    {
		
		private AccesoDatos Datos;
		public ImagenNegocio()
		{
			   Datos = new AccesoDatos();

		}

        public List<Imagen> Listarimagenes(int IdArticulo)
        {
			List<Imagen> Lista = new List<Imagen>();
			try
			{
				
				Datos.SetearConsulta("select Id, IdArticulo, ImagenUrl FROM IMAGENES where IdArticulo ="+IdArticulo+"");
				Datos.EjecutarLectura();

				while (Datos.Lector.Read())
				{
                    Imagen aux = new Imagen();
                    aux.IDImagen = Datos.Lector.GetInt32(0);
                    aux.IDArticulo = Datos.Lector.GetInt32(1);
                    aux.URLImagen = (string)Datos.Lector["ImagenUrl"];
                    Lista.Add(aux);
                }
				

				return Lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { Datos.CerrarConexion(); }
        }
    }
}
