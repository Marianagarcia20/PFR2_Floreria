namespace PFR2_Floreria
{
    partial class Sucursal_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursal_Cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CmbxSucursal = new System.Windows.Forms.ComboBox();
            this.CmbxCliente = new System.Windows.Forms.ComboBox();
            this.BtnEliminarSucCliente = new System.Windows.Forms.Button();
            this.BtnActualizarSucCliente = new System.Windows.Forms.Button();
            this.BtnAgregarSucCliente = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
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
            this.Panel1.Location = new System.Drawing.Point(-11, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(813, 49);
            this.Panel1.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(744, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(28, 105);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(397, 265);
            this.DataGridView1.TabIndex = 65;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(441, 114);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 18);
            this.Label3.TabIndex = 64;
            this.Label3.Text = "Sucursal";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(441, 162);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 18);
            this.Label2.TabIndex = 63;
            this.Label2.Text = "Cliente";
            // 
            // CmbxSucursal
            // 
            this.CmbxSucursal.DisplayMember = "direccion";
            this.CmbxSucursal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxSucursal.FormattingEnabled = true;
            this.CmbxSucursal.Location = new System.Drawing.Point(517, 107);
            this.CmbxSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxSucursal.Name = "CmbxSucursal";
            this.CmbxSucursal.Size = new System.Drawing.Size(255, 26);
            this.CmbxSucursal.TabIndex = 62;
            this.CmbxSucursal.ValueMember = "id";
            // 
            // CmbxCliente
            // 
            this.CmbxCliente.DisplayMember = "nombre";
            this.CmbxCliente.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxCliente.FormattingEnabled = true;
            this.CmbxCliente.Location = new System.Drawing.Point(517, 154);
            this.CmbxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxCliente.Name = "CmbxCliente";
            this.CmbxCliente.Size = new System.Drawing.Size(255, 26);
            this.CmbxCliente.TabIndex = 61;
            this.CmbxCliente.ValueMember = "id";
            // 
            // BtnEliminarSucCliente
            // 
            this.BtnEliminarSucCliente.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarSucCliente.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSucCliente.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarSucCliente.Location = new System.Drawing.Point(676, 216);
            this.BtnEliminarSucCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarSucCliente.Name = "BtnEliminarSucCliente";
            this.BtnEliminarSucCliente.Size = new System.Drawing.Size(113, 42);
            this.BtnEliminarSucCliente.TabIndex = 60;
            this.BtnEliminarSucCliente.Text = "ELIMINAR";
            this.BtnEliminarSucCliente.UseVisualStyleBackColor = false;
            this.BtnEliminarSucCliente.Click += new System.EventHandler(this.BtnEliminarSucCliente_Click);
            // 
            // BtnActualizarSucCliente
            // 
            this.BtnActualizarSucCliente.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarSucCliente.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarSucCliente.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarSucCliente.Location = new System.Drawing.Point(552, 216);
            this.BtnActualizarSucCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarSucCliente.Name = "BtnActualizarSucCliente";
            this.BtnActualizarSucCliente.Size = new System.Drawing.Size(118, 42);
            this.BtnActualizarSucCliente.TabIndex = 59;
            this.BtnActualizarSucCliente.Text = "ACTUALIZAR";
            this.BtnActualizarSucCliente.UseVisualStyleBackColor = false;
            this.BtnActualizarSucCliente.Click += new System.EventHandler(this.BtnActualizarSucCliente_Click);
            // 
            // BtnAgregarSucCliente
            // 
            this.BtnAgregarSucCliente.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarSucCliente.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSucCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarSucCliente.Location = new System.Drawing.Point(444, 216);
            this.BtnAgregarSucCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarSucCliente.Name = "BtnAgregarSucCliente";
            this.BtnAgregarSucCliente.Size = new System.Drawing.Size(102, 42);
            this.BtnAgregarSucCliente.TabIndex = 58;
            this.BtnAgregarSucCliente.Text = "AGREGAR";
            this.BtnAgregarSucCliente.UseVisualStyleBackColor = false;
            this.BtnAgregarSucCliente.Click += new System.EventHandler(this.BtnAgregarSucCliente_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(488, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(182, 25);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "SUCURSAL CLIENTES";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(28, 55);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 67;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Sucursal_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.CmbxSucursal);
            this.Controls.Add(this.CmbxCliente);
            this.Controls.Add(this.BtnEliminarSucCliente);
            this.Controls.Add(this.BtnActualizarSucCliente);
            this.Controls.Add(this.BtnAgregarSucCliente);
            this.Controls.Add(this.Label1);
            this.Name = "Sucursal_Cliente";
            this.Text = "Sucursal_Cliente";
            this.Load += new System.EventHandler(this.Sucursal_Cliente_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox CmbxSucursal;
        internal System.Windows.Forms.ComboBox CmbxCliente;
        internal System.Windows.Forms.Button BtnEliminarSucCliente;
        internal System.Windows.Forms.Button BtnActualizarSucCliente;
        internal System.Windows.Forms.Button BtnAgregarSucCliente;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}