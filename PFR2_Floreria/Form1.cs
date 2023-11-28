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

namespace PFR2_Floreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            NpgsqlCommand comando = new NpgsqlCommand ();
            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                TxtUsuario.Select();
                MessageBox.Show("Favor de llenar todos los campos solicitados");
            }
            else if (string.IsNullOrEmpty(TxtContrasena.Text))
            {
                TxtContrasena.Select();
                MessageBox.Show("Favor de llenar todos los campos solicitados");
            }
            else if (string.IsNullOrEmpty(TxtContrasena.Text + TxtUsuario.Text))
                TxtUsuario.Select();
            else
            {
                Conexionn.conexionn.Open();
                string consulta = "Select id from empleado where usuario='" + TxtUsuario.Text + "'and contrasenia='" + TxtContrasena.Text + "'";
                comando = new NpgsqlCommand(consulta, Conexionn.conexionn);
                NpgsqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        MessageBox.Show("Se inicio la sesion");
                        Menu frmMenu = new Menu();
                        this.Hide();
                        frmMenu.Show();
                    }
                }
                else
                    MessageBox.Show("El usuario no existe o datos incorrectos");
                Conexionn.conexionn.Close();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado frmEmpleado = new Empleado();
            this.Hide();
            frmEmpleado.Show();
        }
    }
}
