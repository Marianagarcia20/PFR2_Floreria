using Npgsql;
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
using static System.Net.Mime.MediaTypeNames;

namespace PFR2_Floreria
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }
        
        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            CmbxCliente.DataSource = Conexionn.Query("Select * from Cliente");
            CmbxCliente.ValueMember = "id";
            CmbxCliente.DisplayMember = "nombre";
            CmbxTipoVenta.DataSource = Conexionn.Query("Select * from Tipo_Venta");
            CmbxTipoVenta.ValueMember = "id";
            CmbxTipoVenta.DisplayMember = "descripcion";
            CmbxTipoPago.DataSource = Conexionn.Query("Select * from Tipo_Pago");
            CmbxTipoPago.ValueMember = "id";
            CmbxTipoPago.DisplayMember = "descripcion";
        }
        private void BtnAgregarVenta_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Conexionn.conexionn.Open();

                    // Obtener el último ID de venta
                    int id = UltimaVenta();

                    // Insertar venta principal
                    NpgsqlCommand xd = new NpgsqlCommand("INSERT INTO Venta (id, fecha_venta, id_cliente, id_tipo_venta, id_tipo_pago, empleado_crea, empleado_actualiza) VALUES (@id, @fecha_venta, @id_cliente, @id_tipo_venta, @id_tipo_pago, @empleado_crea, @empleado_actualiza)", Conexionn.conexionn);
                    xd.Parameters.AddWithValue("@id", id);
                    xd.Parameters.AddWithValue("@fecha_venta", DateTimePicker1.Value);
                    xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue);
                    xd.Parameters.AddWithValue("@id_tipo_venta", CmbxTipoVenta.SelectedValue);
                    xd.Parameters.AddWithValue("@id_tipo_pago", CmbxTipoPago.SelectedValue);
                    xd.Parameters.AddWithValue("@empleado_crea", 1);
                    xd.Parameters.AddWithValue("@empleado_actualiza", 1);
                    xd.ExecuteNonQuery();
                    xd.Dispose();

                    // Insertar detalles de venta
                    foreach (DataGridViewRow r in DataGridView1.Rows)
                    {
                        xd = new NpgsqlCommand("INSERT INTO Detalle_Venta (id_arreglo, cantidad, precio, id_venta, empleado_crea, empleado_actualiza) VALUES (@id_arreglo, @cantidad, @precio, @id_venta, @empleado_crea, @empleado_actualiza)", Conexionn.conexionn);
                        xd.Parameters.AddWithValue("@id_arreglo", r.Cells[0].Value);
                        xd.Parameters.AddWithValue("@cantidad", r.Cells[3].Value);
                        xd.Parameters.AddWithValue("@precio", r.Cells[2].Value);
                        xd.Parameters.AddWithValue("@id_venta", id);
                        xd.Parameters.AddWithValue("@empleado_crea", 1);
                        xd.Parameters.AddWithValue("@empleado_actualiza", 1);
                        xd.ExecuteNonQuery();
                        xd.Dispose();
                    }

                    MessageBox.Show("Venta registrada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar venta: " + ex.Message);
                }
                finally
                {
                    Conexionn.conexionn.Close();
                    DataGridView1.Rows.Clear();
                }
            }
            
        }

        public int UltimaVenta()
        {
            DataTable datos = new DataTable();
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter("select max(id) from Venta", Conexionn.conexionn);
            reader.Fill(datos);

            try
            {
                return Convert.ToInt32(datos.Rows[0][0]) + 1;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        private void TxtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable resultado = Conexionn.Query("select id, nombre, precio from Arreglo where id=" + TxtArticulo.Text);
                string id = resultado.Rows[0]["id"].ToString();
                string nombre = resultado.Rows[0]["nombre"].ToString();
                string costo = resultado.Rows[0]["precio"].ToString();
                DataGridView1.Rows.Add(id, nombre, costo, TxtCantidad.Text);
            }     
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
