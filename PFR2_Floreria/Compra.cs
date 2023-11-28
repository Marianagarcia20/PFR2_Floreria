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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Compra_Flor order by id");
            CmbxProveedor.DataSource = Conexionn.Query("Select * from Proveedor");
            CmbxProveedor.ValueMember = "id";
            CmbxProveedor.DisplayMember = "nombre_empresa";
            CmbxFlor.DataSource = Conexionn.Query("Select * from Flor");
            CmbxFlor.ValueMember = "id";
            CmbxFlor.DisplayMember = "color";
        }
        private void BtnAgregarCompra_Click(object sender, EventArgs e)
        {
 
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Compra_Flor(fecha_surtido,precio,cantidad,id_proveedor,id_flor,empleado_crea,empleado_actualiza) values (@fecha_surtido,@precio,@cantidad,@id_proveedor,@id_flor,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@fecha_surtido", DateTimePicker1.Value);
            xd.Parameters.AddWithValue("@precio", Convert.ToDecimal(TxtPrecio.Text));
            xd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(TxtCantidad.Text));
            xd.Parameters.AddWithValue("@id_proveedor", CmbxProveedor.SelectedValue);
            xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Compra_Flor order by id");
        }

        private void BtnActualizarCompra_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Compra_Flor set fecha_surtido=@fecha_surtido, precio=@precio,cantidad=@cantidad,id_proveedor=@id_proveedor, id_flor=@id_flor, empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id= @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@fecha_surtido", DateTimePicker1.Value);
            xd.Parameters.AddWithValue("@precio", Convert.ToDecimal(TxtPrecio.Text));
            xd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(TxtCantidad.Text));
            xd.Parameters.AddWithValue("@id_proveedor", CmbxProveedor.SelectedValue);
            xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Compra_Flor order by id");
        }

        private void BtnEliminarCompra_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Compra_Flor set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Compra_Flor order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
