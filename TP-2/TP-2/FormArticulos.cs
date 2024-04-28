using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;
using static System.Net.Mime.MediaTypeNames;

namespace TP_2
{
    public partial class FormArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private ArticuloNegocio negocio = new ArticuloNegocio();
        public FormArticulos()
        {
            InitializeComponent();
            negocio = new ArticuloNegocio();
        }


        private void FormArticulos_Load(object sender, EventArgs e)
        {

            CargarGrid();
            cBoxCampo.Items.Add("Nombre");
            cBoxCampo.Items.Add("Marca");
            cBoxCampo.Items.Add("Codigo");
            cBoxCampo.Items.Add("Precio");
            

        }
        private void CargarGrid()
        {
            try
            {
                listaArticulos = negocio.ListarArticulos();
                if (listaArticulos.Count == 0)
                {
                    dgvArticulos.DataSource = null;
                    pBoxArticulosFormArticulos.Load("https://i0.wp.com/static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg?ssl=1");
                }
                else
                {
                    dgvArticulos.DataSource = listaArticulos;
                    dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];                  
                    dgvArticulos.Columns["IdArticulo"].Visible = false;
                    dgvArticulos.Columns["DescripcionArticulo"].Visible = false;
                    dgvArticulos.Columns["CategoriaArticulo"].Visible = false;
                    dgvArticulos.Columns["PrecioArticulo"].DataGridView.Columns["PrecioArticulo"].DefaultCellStyle.Format = "$0.00";
                    pBoxArticulosFormArticulos.Load(listaArticulos[0].Imagenes[0].URLImagen);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo seleccionado =(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                pBoxArticulosFormArticulos.Load(seleccionado.Imagenes[0].URLImagen);
            }
            catch (Exception)
            {
                articuloNegocio.ModificarArticuloImagen(seleccionado);
                MessageBox.Show("Se ha modificado la URL de la imagen del articulo (por Default), porque la URL era Inexistente. Vuelva a abrir Articulos.", "URL INEXISTENTE",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CargarImagen(string imagen) 
        { 
            try
            {
                pBoxArticulosFormArticulos.Load(imagen); 
            }
            catch (Exception ex)
            {
                pBoxArticulosFormArticulos.Load("https://i0.wp.com/static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg?ssl=1");
            }
        }

        private void btnAgregarFormArticulos_Click(object sender, EventArgs e)
        {
            FormAddMod formAddMod = new FormAddMod();
            formAddMod.ShowDialog();
            CargarGrid();
            
        }

        private void btnModificarFormArticulos_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormAddMod formAddMod = new FormAddMod(seleccionado);
            formAddMod.ShowDialog();
            CargarGrid();
        }

        private void btnEliminarFormArticulos_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Articulo artSelec;
            try
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro que desea eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rta == DialogResult.No)
                {
                    return;
                }
                artSelec = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.EliminarArticulo(artSelec.IDArticulo);
                CargarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para ver sus imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int index = seleccionado.Imagenes.IndexOf(seleccionado.Imagenes.Find(x => x.URLImagen == pBoxArticulosFormArticulos.ImageLocation));
            if (index == seleccionado.Imagenes.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            CargarImagen(seleccionado.Imagenes[index].URLImagen);
        }

        private void btnAnteriorImg_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para ver sus imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int index = seleccionado.Imagenes.IndexOf(seleccionado.Imagenes.Find(x => x.URLImagen == pBoxArticulosFormArticulos.ImageLocation));
            if (index == 0)
            {
                index = seleccionado.Imagenes.Count - 1;
            }
            else
            {
                index--;
            }
            CargarImagen(seleccionado.Imagenes[index].URLImagen);
        }

        private void txtBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBusquedaRapida.Text;
            if (filtro.Length > 2)
            {
                listaFiltrada= listaArticulos.FindAll(articulo=>articulo.NombreArticulo.ToUpper().Contains(filtro.ToUpper())|| articulo.MarcaArticulo.NombreMarca.ToUpper().Contains(filtro.ToUpper()) || articulo.CategoriaArticulo.NombreCategoria.ToUpper().Contains(filtro.ToUpper())|| articulo.CodigoArticulo.ToUpper().Contains(filtro.ToUpper()));
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            formDetalles formDetalles = new formDetalles(seleccionado);
            formDetalles.ShowDialog();
            
            
        }

        private void cBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCampo.SelectedIndex != -1)
            {

                if (cBoxCampo.SelectedItem.ToString() == "Precio")
                {
                    cBoxCriterio.Items.Clear();
                    cBoxCriterio.Items.Add("Mayor a");
                    cBoxCriterio.Items.Add("Menor a");
                    cBoxCriterio.Items.Add("Igual a");
                }
                else
                {
                    cBoxCriterio.Items.Clear();
                    cBoxCriterio.Items.Add("Comienza con");
                    cBoxCriterio.Items.Add("Termina con");
                    cBoxCriterio.Items.Add("Contiene");
                }
            }
        }
        private List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            try
            {
                string consulta = "select  a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, c.ID IdCategoria, c.Descripcion as 'Categoria', m.Descripcion as 'Marca', m.ID IdMarca FROM ARTICULOS a, Categorias c, Marcas m where a.IdCategoria= c.Id and a.IdMarca = m.Id AND ";
                if(campo == "Precio")
                {
                    if (criterio == "Mayor a")
                    {
                        consulta += "a.Precio > " + filtro;
                    }
                    else if (criterio == "Menor a")
                    {
                        consulta +="a.Precio < " + filtro;
                    }
                    else
                    {
                        consulta +="a.Precio = " + filtro;
                    }
                }else if (campo == "Nombre")
                {
                    if (criterio == "Comienza con")
                    {
                        consulta +="a.Nombre like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con")
                    {
                        consulta +="a.Nombre like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta +="a.Nombre like '%" + filtro + "%'";
                    }
                }
                else if (campo == "Codigo")
                {
                    if (criterio == "Comienza con")
                    {
                        consulta += "a.Codigo like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con")
                    {
                        consulta += "a.Codigo like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "a.Codigo like '%" + filtro + "%'";
                    }
                }
                else
                {
                    if (criterio == "Comienza con")
                    {
                        consulta +="m.Descripcion like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con")
                    {
                        consulta +="m.Descripcion like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta +="m.Descripcion like '%" + filtro + "%'";
                    }
                }
                listaFiltrada = negocio.ListarArticulos(consulta);
                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscarFiltrado_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cBoxCampo.SelectedItem.ToString();
                string criterio = cBoxCriterio.SelectedItem.ToString();
                string filtro = txtBuscarFiltrado.Text;
                dgvArticulos.DataSource = Filtrar(campo, criterio, filtro);
            } catch
            {

            } 
        }
    }
}
