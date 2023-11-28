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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Cliente order by id");          
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Cliente(nombre,ap_paterno, ap_materno,direccion,celular,empleado_crea,empleado_actualiza) values (@nombre,@ap_paterno, @ap_materno,@direccion,@celular,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text);
            xd.Parameters.AddWithValue("@ap_paterno", TxtAppCliente.Text);
            xd.Parameters.AddWithValue("@ap_materno", TxtApmCliente.Text);
            xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text);
            xd.Parameters.AddWithValue("@celular", TxtCelular.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Cliente order by id");
        }

        private void BtnActualizarCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Cliente set nombre=@nombre, ap_paterno=@ap_paterno, ap_materno= @ap_materno,direccion=@direccion, celular=@celular,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text);
            xd.Parameters.AddWithValue("@ap_paterno", TxtAppCliente.Text);
            xd.Parameters.AddWithValue("@ap_materno", TxtApmCliente.Text);
            xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text);
            xd.Parameters.AddWithValue("@celular", TxtCelular.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Cliente order by id");
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Cliente set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Cliente order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
