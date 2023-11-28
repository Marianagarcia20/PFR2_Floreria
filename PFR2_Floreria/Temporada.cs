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
    public partial class Temporada : Form
    {
        public Temporada()
        {
            InitializeComponent();
        } 
        
        private void Temporada_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Temporada order by id");
        }

        private void BtnAgregarTemporada_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Temporada(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionT.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Temporada order by id");
        }

        private void BtnActualizarTemporada_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Temporada set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcionT.Text);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Temporada order by id");
        }

        private void BtnEliminarTemporada_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Temporada set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Temporada order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
