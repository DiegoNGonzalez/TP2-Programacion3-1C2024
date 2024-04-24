using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using AccesoDataBase;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos Datos;

        public ArticuloNegocio()
        {
            Datos = new AccesoDatos();
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> Lista = new List<Articulo>();
            try
            {
                Datos.SetearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, c.Descripcion as 'Categoria', m.Descripcion as 'Marca', i.ImagenUrl FROM ARTICULOS a, Categorias c, Marcas m, Imagenes i where a.IdCategoria= c.Id and a.IdMarca = m.Id and a.Id= i.IdArticulo");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDArticulo = Datos.Lector.GetInt32(0);
                    aux.CodigoArticulo = (string)Datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)Datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)Datos.Lector["Descripcion"];
                    aux.PrecioArticulo = (decimal)Datos.Lector["Precio"];
                    aux.MarcaArticulo = new Marca();
                    aux.MarcaArticulo.NombreMarca= (string)Datos.Lector["Marca"];
                    aux.CategoriaArticulo = new Categoria();
                    aux.CategoriaArticulo.NombreCategoria = (string)Datos.Lector["Categoria"];
                    aux.Imagenes = new List<Imagen>();
                    aux.Imagenes.Add(new Imagen() { URLImagen = (string)Datos.Lector["ImagenUrl"] });

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

        public void AgregarArticulo(Articulo Nuevo)
        {
            try
            {
                Datos.SetearConsulta("INsERt INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio) values(@Codigo,@Nombre,@Descripcion,@Precio)");
                //,IdCategoria,IdMarca ,@IdCategoria,@IdMarca falta implementar marca y categoria
                Datos.SetearParametro("@Codigo", Nuevo.CodigoArticulo);
                Datos.SetearParametro("@Nombre", Nuevo.NombreArticulo);
                Datos.SetearParametro("@Descripcion", Nuevo.DescripcionArticulo);
                //Datos.SetearParametro("@IdCategoria", Nuevo.CategoriaArticulo.IDCategoria);
                //Datos.SetearParametro("@IdMarca", Nuevo.MarcaArticulo.IDMarca);
                Datos.SetearParametro("@Precio", Nuevo.PrecioArticulo);
                Datos.EjectucarLectura();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion();}
        }

        public void ModificarArticulo(Articulo Modificado)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarArticulo(int ID)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
