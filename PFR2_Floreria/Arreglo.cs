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
    public partial class Arreglo : Form
    {
        public Arreglo()
        {
            InitializeComponent();
        }

        private void Arreglo_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Arreglo order by id");
            CmbxTamanio.DataSource = Conexionn.Query("Select * from Tamanio_Arreglo");
            CmbxTamanio.ValueMember = "id";
            CmbxTamanio.DisplayMember = "descripcion";
            CmbxTipoArreglo.DataSource = Conexionn.Query("Select * from Tipo_Arreglo");
            CmbxTipoArreglo.ValueMember = "id";
            CmbxTipoArreglo.DisplayMember = "descripcion";
        }

        private void BtnAgregarArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Arreglo(nombre,color,precio,id_tipo_arreglo,id_tamanio_arreglo,empleado_crea,empleado_actualiza) values (@nombre,@color,@precio,@id_tipo_arreglo,@id_tamanio_arreglo,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@nombre", TxtNombreArreglo.Text);
            xd.Parameters.AddWithValue("@color", TxtColorArreglo.Text);
            xd.Parameters.AddWithValue("@precio", Convert.ToDecimal(TxtPrecioArreglo.Text));
            xd.Parameters.AddWithValue("@id_tipo_arreglo", CmbxTipoArreglo.SelectedValue);
            xd.Parameters.AddWithValue("@id_tamanio_arreglo", CmbxTamanio.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Arreglo order by id");
        }

        private void BtnActualizarArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Arreglo set nombre=@nombre,color=@color, precio=@precio,id_tipo_arreglo=@id_tipo_arreglo,id_tamanio_arreglo=@id_tamanio_arreglo,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id= @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@nombre", TxtNombreArreglo.Text);
            xd.Parameters.AddWithValue("@color", TxtColorArreglo.Text);
            xd.Parameters.AddWithValue("@precio", Convert.ToDecimal(TxtPrecioArreglo.Text));
            xd.Parameters.AddWithValue("@id_tipo_arreglo", CmbxTipoArreglo.SelectedValue);
            xd.Parameters.AddWithValue("@id_tamanio_arreglo", CmbxTamanio.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Arreglo order by id");
        }

        private void BtnEliminarArreglo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Arreglo set status=0 where id = @id", Conexionn.conexionn);

            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Arreglo order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
