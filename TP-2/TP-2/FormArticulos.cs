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
            cBoxCampo.Items.Add("Categoria");
            cBoxCampo.Items.Add("Codigo");

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
    }
}
