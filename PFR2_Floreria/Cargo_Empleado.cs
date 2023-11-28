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
    public partial class Cargo_Empleado : Form
    {
        public Cargo_Empleado()
        {
            InitializeComponent();
        }
        private void Cargo_Empleado_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Puesto_Empleado order by id");
        }

        private void BtnAgregarCargo_Click(object sender, EventArgs e)
        {
           
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Puesto_Empleado(descripcion,salario) values (@descripcion,@salario)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text);
            xd.Parameters.AddWithValue("@salario", Convert.ToDecimal(TxtSalario.Text));
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Puesto_Empleado order by id");
        }
        private void BtnActualizarCargo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Puesto_Empleado set descripcion=@descripcion, salario=@salario where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text);
            xd.Parameters.AddWithValue("@salario", Convert.ToDecimal(TxtSalario.Text));
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Puesto_Empleado order by id");
        }

        private void BtnEliminarCargo_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Puesto_Empleado set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Puesto_Empleado order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
