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
    public partial class Sucursal_Cliente : Form
    {
        public Sucursal_Cliente()
        {
            InitializeComponent();
        }

        private void Sucursal_Cliente_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal_Cliente order by id");
            CmbxSucursal.DataSource = Conexionn.Query("Select * from Sucursal");
            CmbxSucursal.ValueMember = "id";
            CmbxSucursal.DisplayMember = "direccion";
            CmbxCliente.DataSource = Conexionn.Query("Select * from Cliente");
            CmbxCliente.ValueMember = "id";
            CmbxCliente.DisplayMember = "nombre";
        }

        private void BtnAgregarSucCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Sucursal_Cliente (id_sucursal,id_cliente,empleado_crea,empleado_actualiza) values (@id_sucursal,@id_cliente,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal_Cliente order by id");
        }

        private void BtnActualizarSucCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Sucursal_Cliente set id_sucursal=@id_sucursal,id_cliente=@id_cliente,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal_Cliente order by id");
        }

        private void BtnEliminarSucCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Sucursal_Cliente set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal_Cliente order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
