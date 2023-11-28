using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFR2_Floreria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Cliente frmCliente = new Cliente();
            this.Hide();
            frmCliente.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado frmEmpleado = new Empleado();
            this.Hide();
            frmEmpleado.Show();
        }

        private void BtnPuestos_Click(object sender, EventArgs e)
        {
            Cargo_Empleado frmCargo = new Cargo_Empleado();
            this.Hide();
            frmCargo.Show();
        }

        private void BtnHorarios_Click(object sender, EventArgs e)
        {
            Horario_Empleado frmHorarios = new Horario_Empleado();
            this.Hide();
            frmHorarios.Show();
        }

        private void BtnSucursales_Click(object sender, EventArgs e)
        {
            Sucursal frmSucursal = new Sucursal();
            this.Hide();
            frmSucursal.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            this.Hide();
            frmProveedor.Show();
        }

        private void BtnTProveedor_Click(object sender, EventArgs e)
        {
            Tipo_Proveedor frmTProveedor = new Tipo_Proveedor();
            this.Hide();
            frmTProveedor.Show();
        }

        private void BtnSurtido_Click(object sender, EventArgs e)
        {
            Compra frmCompra = new Compra();
            this.Hide();
            frmCompra.Show();
        }

        private void BtnClienteSuc_Click(object sender, EventArgs e)
        {
            Sucursal_Cliente frmSCliente = new Sucursal_Cliente();
            this.Hide();
            frmSCliente.Show();
        }

        private void BtnFlores_Click(object sender, EventArgs e)
        {
            Flor frmFlor = new Flor();
            this.Hide();
            frmFlor.Show();
        }

        private void BtnTFlor_Click(object sender, EventArgs e)
        {
            Tipo_Flor frmTFlor= new Tipo_Flor();
            this.Hide();
            frmTFlor.Show();
        }

        private void BtnTemporadas_Click(object sender, EventArgs e)
        {
            Temporada frmTemporada = new Temporada();
            this.Hide();
            frmTemporada.Show();
        }

        private void BtnArreglos_Click(object sender, EventArgs e)
        {
            Arreglo frmArreglo = new Arreglo();
            this.Hide();
            frmArreglo.Show();
        }

        private void BtnFlorArreglo_Click(object sender, EventArgs e)
        {
            Flor_Arreglo frmFArreglo = new Flor_Arreglo();
            this.Hide();
            frmFArreglo.Show();
        }

        private void BtnTArreglo_Click(object sender, EventArgs e)
        {
            Tipo_Arreglo frmTArreglo = new Tipo_Arreglo();
            this.Hide();
            frmTArreglo.Show();
        }

        private void BtnTamArreglo_Click(object sender, EventArgs e)
        {
            Tamanio_Arreglo frmTmArreglo = new Tamanio_Arreglo();
            this.Hide();
            frmTmArreglo.Show();
        }

        private void BtnDVenta_Click(object sender, EventArgs e)
        {
            DetalleVenta frmDetalleV = new DetalleVenta();
            this.Hide();
            frmDetalleV.Show();
        }

        private void BtnTVenta_Click(object sender, EventArgs e)
        {
            Tipo_Venta frmTVenta = new Tipo_Venta();
            this.Hide();
            frmTVenta.Show();
        }

        private void BtnTPago_Click(object sender, EventArgs e)
        {
            Tipo_Pago frmTPago = new Tipo_Pago();
            this.Hide();
            frmTPago.Show();
        }
    }
}
