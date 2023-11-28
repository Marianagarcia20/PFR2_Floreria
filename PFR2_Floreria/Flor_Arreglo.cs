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
    public partial class Flor_Arreglo : Form
    {
        public Flor_Arreglo()
        {
            InitializeComponent();
        }

        private void Flor_Arreglo_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor_Arreglo order by id");
            CmbxArreglo.DataSource = Conexionn.Query("Select * from Arreglo");
            CmbxArreglo.ValueMember = "id";
            CmbxArreglo.DisplayMember = "nombre";
            CmbxFlor.DataSource = Conexionn.Query("Select * from Flor");
            CmbxFlor.ValueMember = "id";
            CmbxFlor.DisplayMember = "color";
        }

        private void BtnAgregarFlorArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Flor_Arreglo(cantidad,id_arreglo,id_flor,empleado_crea,empleado_actualiza) values (@cantidad,@id_arreglo,@id_flor,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(TxtCantidadFlorArreglo.Text));
            xd.Parameters.AddWithValue("@id_arreglo", CmbxArreglo.SelectedValue);
            xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor_Arreglo order by id");
        }
        

        private void BtnActualizarFlorArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Flor_Arreglo set cantidad=@cantidad,id_arreglo=@id_arreglo,id_flor=@id_flor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(TxtCantidadFlorArreglo.Text));
            xd.Parameters.AddWithValue("@id_arreglo", CmbxArreglo.SelectedValue);
            xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor_Arreglo order by id");
        }

        private void BtnEliminarFlorArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Flor_Arreglo set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Flor_Arreglo order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
