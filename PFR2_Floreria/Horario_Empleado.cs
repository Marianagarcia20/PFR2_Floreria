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
    public partial class Horario_Empleado : Form
    {
        public Horario_Empleado()
        {
            InitializeComponent();
        }
        private void Horario_Empleado_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Horario_Empleado order by id");
        }

        private void BtnAgregarHorario_Click(object sender, EventArgs e)
        {

            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Horario_Empleado(hora_entrada,hora_salida) values (@hora_entrada,@hora_salida)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@hora_entrada", Convert.ToDateTime(TxtHrE.Text));
            xd.Parameters.AddWithValue("@hora_salida", Convert.ToDateTime(TxtHrS.Text));
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Horario_Empleado order by id");
        }

        private void BtnActualizarHorario_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Horario_Empleado set hora_entrada=@hora_entrada,hora_salida=@hora_salida where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@hora_entrada", Convert.ToDateTime(TxtHrE.Text));
            xd.Parameters.AddWithValue("@hora_salida", Convert.ToDateTime(TxtHrS.Text));
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Horario_Empleado order by id");
        }

        private void BtnEliminarHorario_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Horario_Empleado set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Horario_Empleado order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
