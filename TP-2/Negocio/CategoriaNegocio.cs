using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDataBase;
using dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos datos;
        public CategoriaNegocio() { datos = new AccesoDatos(); }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                datos.SetearConsulta("select id, descripcion from categorias");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IDCategoria = datos.Lector.GetInt32(0);
                    aux.NombreCategoria = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch ( Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
    }
}
