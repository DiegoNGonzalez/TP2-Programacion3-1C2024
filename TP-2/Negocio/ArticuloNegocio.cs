﻿using System;
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
        private ImagenNegocio Imagenes;

        public ArticuloNegocio()
        {
            Datos = new AccesoDatos();
            Imagenes = new ImagenNegocio();
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> Lista = new List<Articulo>();
            try
            {
                Datos.SetearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, c.Descripcion as 'Categoria', m.Descripcion as 'Marca' FROM ARTICULOS a, Categorias c, Marcas m where a.IdCategoria= c.Id and a.IdMarca = m.Id");
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
                    
                    
                                     
                                        
                    Lista.Add(aux);
                }   

                foreach (var articulo in Lista)
                {
                    articulo.Imagenes = Imagenes.Listarimagenes(articulo.IDArticulo);
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
                try
                {
                    Datos.SetearConsulta("INsERt INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca) values(@Codigo,@Nombre,@Descripcion,@Precio,@IdCategoria,@IdMarca)");
                    Datos.SetearParametro("@Codigo", Nuevo.CodigoArticulo);
                    Datos.SetearParametro("@Nombre", Nuevo.NombreArticulo);
                    Datos.SetearParametro("@Descripcion", Nuevo.DescripcionArticulo);
                    Datos.SetearParametro("@IdCategoria", Nuevo.CategoriaArticulo.IDCategoria);
                    Datos.SetearParametro("@IdMarca", Nuevo.MarcaArticulo.IDMarca);
                    Datos.SetearParametro("@Precio", Nuevo.PrecioArticulo);
                    Datos.EjecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally { Datos.CerrarConexion(); }
                int ID = ObtenerUltimoID();
                Imagenes.AgregarImagen(ID, Nuevo.Imagenes[0].URLImagen);
                
                
                
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

        public int ObtenerUltimoID()
        {
            try
            {
                Datos.SetearConsulta("SELECT MAX(Id) FROM ARTICULOS");
                Datos.EjecutarLectura();
                Datos.Lector.Read();
                return Datos.Lector.GetInt32(0);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }
        }
    }
}
