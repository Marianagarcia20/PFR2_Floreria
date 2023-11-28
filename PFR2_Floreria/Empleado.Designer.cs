namespace PFR2_Floreria
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbxCargo = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.CmbxSucursal = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.TxtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.TxtAMEmpleado = new System.Windows.Forms.TextBox();
            this.TxtAPEmpleado = new System.Windows.Forms.TextBox();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminarEmpleado = new System.Windows.Forms.Button();
            this.BtnActualizarEmpleado = new System.Windows.Forms.Button();
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmbxHorario = new System.Windows.Forms.ComboBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Location = new System.Drawing.Point(-10, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1132, 49);
            this.Panel1.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1055, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.Location = new System.Drawing.Point(12, 114);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(482, 303);
            this.DataGridView1.TabIndex = 77;
            // 
            // CmbxCargo
            // 
            this.CmbxCargo.DisplayMember = "descripcion";
            this.CmbxCargo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxCargo.FormattingEnabled = true;
            this.CmbxCargo.Location = new System.Drawing.Point(933, 195);
            this.CmbxCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxCargo.Name = "CmbxCargo";
            this.CmbxCargo.Size = new System.Drawing.Size(168, 26);
            this.CmbxCargo.TabIndex = 76;
            this.CmbxCargo.ValueMember = "id";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(841, 203);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(53, 18);
            this.Label12.TabIndex = 75;
            this.Label12.Text = "Cargo";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(842, 246);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(63, 18);
            this.Label11.TabIndex = 73;
            this.Label11.Text = "Horario";
            // 
            // CmbxSucursal
            // 
            this.CmbxSucursal.DisplayMember = "direccion";
            this.CmbxSucursal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxSucursal.FormattingEnabled = true;
            this.CmbxSucursal.Location = new System.Drawing.Point(933, 158);
            this.CmbxSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxSucursal.Name = "CmbxSucursal";
            this.CmbxSucursal.Size = new System.Drawing.Size(168, 26);
            this.CmbxSucursal.TabIndex = 72;
            this.CmbxSucursal.ValueMember = "id";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(840, 161);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(67, 18);
            this.Label10.TabIndex = 71;
            this.Label10.Text = "Sucursal";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(824, 156);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(0, 18);
            this.Label9.TabIndex = 70;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.Location = new System.Drawing.Point(933, 107);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(168, 31);
            this.TxtContrasenia.TabIndex = 69;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(652, 322);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(168, 31);
            this.TxtUsuario.TabIndex = 68;
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(652, 279);
            this.TxtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefonoEmpleado.MaxLength = 10;
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(168, 31);
            this.TxtTelefonoEmpleado.TabIndex = 67;
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(651, 233);
            this.TxtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(169, 31);
            this.TxtDireccionEmpleado.TabIndex = 66;
            // 
            // TxtAMEmpleado
            // 
            this.TxtAMEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAMEmpleado.Location = new System.Drawing.Point(652, 188);
            this.TxtAMEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAMEmpleado.Name = "TxtAMEmpleado";
            this.TxtAMEmpleado.Size = new System.Drawing.Size(168, 31);
            this.TxtAMEmpleado.TabIndex = 65;
            // 
            // TxtAPEmpleado
            // 
            this.TxtAPEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAPEmpleado.Location = new System.Drawing.Point(652, 148);
            this.TxtAPEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAPEmpleado.Name = "TxtAPEmpleado";
            this.TxtAPEmpleado.Size = new System.Drawing.Size(168, 31);
            this.TxtAPEmpleado.TabIndex = 64;
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(651, 107);
            this.TxtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(168, 31);
            this.TxtNombreEmpleado.TabIndex = 63;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(840, 120);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 18);
            this.Label8.TabIndex = 62;
            this.Label8.Text = "Contraseña";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(513, 335);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(62, 18);
            this.Label7.TabIndex = 61;
            this.Label7.Text = "Usuario";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(513, 292);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 18);
            this.Label6.TabIndex = 60;
            this.Label6.Text = "Telefono";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(513, 246);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 18);
            this.Label5.TabIndex = 59;
            this.Label5.Text = "Direccion";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(513, 201);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(135, 18);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "Apellido Materno";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(513, 161);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(131, 18);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Apellido Paterno";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(513, 120);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 18);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Nombre";
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(871, 379);
            this.BtnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(108, 38);
            this.BtnEliminarEmpleado.TabIndex = 55;
            this.BtnEliminarEmpleado.Text = "ELIMINAR";
            this.BtnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // BtnActualizarEmpleado
            // 
            this.BtnActualizarEmpleado.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarEmpleado.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarEmpleado.Location = new System.Drawing.Point(724, 379);
            this.BtnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarEmpleado.Name = "BtnActualizarEmpleado";
            this.BtnActualizarEmpleado.Size = new System.Drawing.Size(114, 38);
            this.BtnActualizarEmpleado.TabIndex = 54;
            this.BtnActualizarEmpleado.Text = "ACTUALIZAR";
            this.BtnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.BtnActualizarEmpleado.Click += new System.EventHandler(this.BtnActualizarEmpleado_Click);
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarEmpleado.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(595, 379);
            this.BtnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(94, 38);
            this.BtnAgregarEmpleado.TabIndex = 53;
            this.BtnAgregarEmpleado.Text = "AGREGAR";
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.BtnAgregarEmpleado.Click += new System.EventHandler(this.BtnAgregarEmpleado_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(764, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 25);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "EMPLEADOS";
            // 
            // CmbxHorario
            // 
            this.CmbxHorario.FormattingEnabled = true;
            this.CmbxHorario.Location = new System.Drawing.Point(933, 240);
            this.CmbxHorario.Name = "CmbxHorario";
            this.CmbxHorario.Size = new System.Drawing.Size(168, 24);
            this.CmbxHorario.TabIndex = 79;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 57);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 80;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 447);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.CmbxHorario);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CmbxCargo);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.CmbxSucursal);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtTelefonoEmpleado);
            this.Controls.Add(this.TxtDireccionEmpleado);
            this.Controls.Add(this.TxtAMEmpleado);
            this.Controls.Add(this.TxtAPEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.BtnActualizarEmpleado);
            this.Controls.Add(this.BtnAgregarEmpleado);
            this.Controls.Add(this.Label1);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox CmbxCargo;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox CmbxSucursal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TxtContrasenia;
        internal System.Windows.Forms.TextBox TxtUsuario;
        internal System.Windows.Forms.TextBox TxtTelefonoEmpleado;
        internal System.Windows.Forms.TextBox TxtDireccionEmpleado;
        internal System.Windows.Forms.TextBox TxtAMEmpleado;
        internal System.Windows.Forms.TextBox TxtAPEmpleado;
        internal System.Windows.Forms.TextBox TxtNombreEmpleado;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEliminarEmpleado;
        internal System.Windows.Forms.Button BtnActualizarEmpleado;
        internal System.Windows.Forms.Button BtnAgregarEmpleado;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox CmbxHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}