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
    public partial class Flor : Form
    {
        public Flor()
        {
            InitializeComponent();
        }

        private void Flor_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor order by id");
            CmbxTemporada.DataSource = Conexionn.Query("Select * from Temporada");
            CmbxTemporada.ValueMember = "id";
            CmbxTemporada.DisplayMember = "descripcion";
            CmbxTipo.DataSource = Conexionn.Query("Select * from Tipo_Flor");
            CmbxTipo.ValueMember = "id";
            CmbxTipo.DisplayMember = "descripcion";
        } 
        
        private void BtnAgregarFlor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Flor(color,costo,id_temporada_flor,id_tipo_flor,empleado_crea,empleado_actualiza) values (@color,@costo,@id_temporada_flor,@id_tipo_flor,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@color", TxtColor.Text);
            xd.Parameters.AddWithValue("@costo", Convert.ToDecimal(TxtCosto.Text));
            xd.Parameters.AddWithValue("@id_temporada_flor", CmbxTemporada.SelectedValue);
            xd.Parameters.AddWithValue("@id_tipo_flor", CmbxTipo.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor order by id");
        }

        private void BtnActualizarFlor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Flor set color=@color,costo=@costo,id_temporada_flor=@id_temporada_flor,id_tipo_flor=@id_tipo_flor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id ", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@color", TxtColor.Text);
            xd.Parameters.AddWithValue("@costo", Convert.ToDecimal(TxtCosto.Text));
            xd.Parameters.AddWithValue("@id_temporada_flor", CmbxTemporada.SelectedValue);
            xd.Parameters.AddWithValue("@id_tipo_flor", CmbxTipo.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor order by id");
        }

        private void BtnEliminarFlor_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Flor set status=0 where id = @id ", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
