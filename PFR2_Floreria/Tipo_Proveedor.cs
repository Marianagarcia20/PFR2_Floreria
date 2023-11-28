using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PFR2_Floreria
{
    public partial class Tipo_Proveedor : Form
    {
        public Tipo_Proveedor()
        {
            InitializeComponent();
        }
        private void Tipo_Proveedor_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Proveedor order by id");
        }
        private void BtnAgregarTipoP_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Tipo_Proveedor(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTP.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Proveedor order by id");
        }

        private void BtnActualizarTipoP_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Proveedor set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTP.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Proveedor order by id");
        }

        private void BtnEliminarTipoP_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Proveedor set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Proveedor order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
