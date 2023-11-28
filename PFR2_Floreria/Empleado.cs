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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = Conexionn.Query("Select * from Empleado order by id");
            CmbxSucursal.DataSource = Conexionn.Query("Select * from Sucursal");
            CmbxSucursal.ValueMember = "id";
            CmbxSucursal.DisplayMember = "direccion";
            CmbxHorario.DataSource = Conexionn.Query("Select * from Horario_Empleado");
            CmbxHorario.ValueMember = "id";
            CmbxHorario.DisplayMember = "horario_entrada";
            CmbxCargo.DataSource = Conexionn.Query("Select * from Puesto_Empleado");
            CmbxCargo.ValueMember = "id";
            CmbxCargo.DisplayMember = "descripcion";

        }
        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Insert into Empleado(nombre,ap_paterno,ap_materno,direccion,celular,usuario,contrasenia,id_sucursal, id_puesto_empleado, id_horario_empleado,empleado_crea,empleado_actualiza) values (@nombre,@ap_paterno,@ap_materno,@direccion,@celular,@usuario,@contrasenia,@id_sucursal,@id_puesto_empleado, @id_horario_empleado,@empleado_crea,@empleado_actualiza)", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@nombre", TxtNombreEmpleado.Text);
            xd.Parameters.AddWithValue("@ap_paterno", TxtAPEmpleado.Text);
            xd.Parameters.AddWithValue("@ap_materno", TxtAMEmpleado.Text);
            xd.Parameters.AddWithValue("@direccion", TxtDireccionEmpleado.Text);
            xd.Parameters.AddWithValue("@celular", TxtTelefonoEmpleado.Text);
            xd.Parameters.AddWithValue("@usuario", TxtUsuario.Text);
            xd.Parameters.AddWithValue("@contrasenia", TxtContrasenia.Text);
            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_puesto_empleado", CmbxCargo.SelectedValue);
            xd.Parameters.AddWithValue("@id_horario_empleado", CmbxHorario.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Empleado order by id");
        }

        private void BtnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Empleado set nombre=@nombre, ap_paterno=@ap_paterno,ap_materno=@ap_materno,direccion=@direccion, celular=@celular,usuario=@usuario, contrasenia=@contrasenia,id_sucursal=@id_sucursal, id_puesto_empleado= @id_puesto_empleado, id_horario_empleado=@id_horario_empleado,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.Parameters.AddWithValue("@nombre", TxtNombreEmpleado.Text);
            xd.Parameters.AddWithValue("@ap_paterno", TxtAPEmpleado.Text);
            xd.Parameters.AddWithValue("@ap_materno", TxtAMEmpleado.Text);
            xd.Parameters.AddWithValue("@direccion", TxtDireccionEmpleado.Text);
            xd.Parameters.AddWithValue("@celular", TxtTelefonoEmpleado.Text);
            xd.Parameters.AddWithValue("@usuario", TxtUsuario.Text);
            xd.Parameters.AddWithValue("@contrasenia", TxtContrasenia.Text);
            xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue);
            xd.Parameters.AddWithValue("@id_puesto_empleado", CmbxCargo.SelectedValue);
            xd.Parameters.AddWithValue("@id_horario_empleado", CmbxHorario.SelectedValue);
            xd.Parameters.AddWithValue("@empleado_crea", 1);
            xd.Parameters.AddWithValue("@empleado_actualiza", 1);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Empleado order by id");
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        { 
            Conexionn.conexionn.Open();
            NpgsqlCommand xd = new NpgsqlCommand("Update Empleado set status=0 where id = @id", Conexionn.conexionn);
            xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows[0].Cells[0].Value);
            xd.ExecuteNonQuery();
            Conexionn.conexionn.Close();
            DataGridView1.DataSource = Conexionn.Query("Select * from Empleado order by id");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
