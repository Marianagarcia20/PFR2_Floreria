using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PFR2_Floreria
{
    public partial class Tipo_Flor : Form
    {
        public Tipo_Flor()
        {
            InitializeComponent();
        }

        private void Tipo_Flor_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Flor order by id");
        }

        private void BtnAgregarTFL_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Tipo_Flor(descripcion, empleado_crea, empleado_actualiza) values (@descripcion, @empleado_crea, @empleado_actualiza)", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTF.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Flor order by id");
        }
        private void BtnActualizarTF_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Flor set descripcion=@descripcion, empleado_crea=@empleado_crea, empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTF.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Flor order by id");
        }

        private void BtnEliminarTF_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Flor set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Flor order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
