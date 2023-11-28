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
    public partial class Tipo_Arreglo : Form
    {
        public Tipo_Arreglo()
        {
            InitializeComponent();
        }
        
        private void Tipo_Arreglo_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Arreglo order by id");
        }
        private void BtnAgregarTipoArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Tipo_Arreglo(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoArreglo.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Arreglo order by id");
        }

        private void BtnActualizarTipoArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Arreglo set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoArreglo.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Arreglo order by id");
        }

        private void BtnEliminarTipoArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Tipo_Arreglo set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Tipo_Arreglo order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
