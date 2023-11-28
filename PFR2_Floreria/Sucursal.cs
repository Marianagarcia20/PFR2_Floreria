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
    public partial class Sucursal : Form
    {
        public Sucursal()
        {
            InitializeComponent();
        }
        private void Sucursal_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal order by id");
        }
        private void BtnAgregarSucursal_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Sucursal(direccion) values (@direccion)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal order by id");
        }

        private void BtnActualizarSucursal_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Sucursal set direccion=@direccion where id=@id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal order by id");
        }

        private void BtnEliminarSucursal_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Sucursal set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Sucursal order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
