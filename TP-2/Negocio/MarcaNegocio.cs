using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDataBase;
using dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos Datos;

        public MarcaNegocio()
        {
            Datos = new AccesoDatos();
        }

        public List<Marca> ListarMarcas()
        {
            List<Marca> Lista = new List<Marca>();
            try
            {
                Datos.SetearConsulta("select Id, Descripcion FROM MARCAS");
                Datos.EjectucarLectura();

                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IDMarca = Datos.Lector.GetInt32(0);
                    aux.NombreMarca = (string)Datos.Lector["Descripcion"];

                    Lista.Add(aux);
                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }   
    }
}
