using Npgsql;
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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Proveedor");
            CmbxSucursal.DataSource = Conexionn.Query("Select * from Sucursal");
            CmbxSucursal.ValueMember = "id";
            CmbxSucursal.DisplayMember = "direccion";
            CmbxTipo.DataSource = Conexionn.Query("Select * from Tipo_Proveedor");
            CmbxTipo.ValueMember = "id";
            CmbxTipo.DisplayMember = "descripcion";
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Proveedor(nombre_empresa,correo,celular,id_sucursal,id_tipo_proveedor,empleado_crea,empleado_actualiza) values (@nombre_empresa,@correo,@celular,@id_sucursal,@id_tipo_proveedor,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@nombre_empresa", TxtNombreProveedor.Text);
            xd.Parameters.AddWithValue("@correo", TxtCorreoProveedor.Text);
            xd.Parameters.AddWithValue("@celular", TxtTelefonoProveedor.Text);
            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_tipo_proveedor", CmbxTipo.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Proveedor order by id");
        }

        private void BtnActualizarProveedor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Proveedor set nombre_empresa=@nombre_empresa,correo=@correo,celular=@celular,id_sucursal=@id_sucursal,id_tipo_proveedor=@id_tipo_proveedor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@nombre_empresa", TxtNombreProveedor.Text);
            xd.Parameters.AddWithValue("@correo", TxtCorreoProveedor.Text);
            xd.Parameters.AddWithValue("@celular", TxtTelefonoProveedor.Text);
            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_tipo_proveedor", CmbxTipo.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Proveedor order by id");
        }

        private void BtnEliminarProveedor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Proveedor set status=0 where id = @id", Conexionn.conexionn);
            
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Proveedor order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
