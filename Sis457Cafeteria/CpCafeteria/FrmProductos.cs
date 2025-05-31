using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            pctBuscarObscuro.Visible = true;
            pctBuscar.Visible = false;
            txtBuscar.Text = string.Empty;
            txtBuscar.ForeColor = Color.Black;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            pctBuscarObscuro.Visible = false;
            pctBuscar.Visible = true;
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtBuscar.Text.Trim());
            dgvProductos.DataSource = lista;
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns["idCategoria"].Visible = false;
            dgvProductos.Columns["estado"].Visible = false;
            dgvProductos.Columns["codigo"].HeaderText = "Código";
            dgvProductos.Columns["nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["descripcion"].HeaderText = "Descripción";
            dgvProductos.Columns["categoria"].HeaderText = "Categoria";
            dgvProductos.Columns["saldo"].HeaderText = "Saldo";
            dgvProductos.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvProductos.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvProductos.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            if (lista.Count > 0) dgvProductos.CurrentCell = dgvProductos.Rows[0].Cells["codigo"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            new FrmCategoria().ShowDialog();
        }


    }
}
