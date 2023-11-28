namespace PFR2_Floreria
{
    partial class Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.CmbxTipo = new System.Windows.Forms.ComboBox();
            this.CmbxSucursal = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TxtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminarProveedor = new System.Windows.Forms.Button();
            this.BtnActualizarProveedor = new System.Windows.Forms.Button();
            this.BtnAgregarProveedor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Location = new System.Drawing.Point(-1, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(765, 49);
            this.Panel1.TabIndex = 70;
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
            this.DataGridView1.Location = new System.Drawing.Point(11, 104);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(357, 271);
            this.DataGridView1.TabIndex = 69;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(510, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(126, 25);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "PROVEEDORES";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(397, 285);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 18);
            this.lbl.TabIndex = 67;
            this.lbl.Text = "Tipo";
            // 
            // CmbxTipo
            // 
            this.CmbxTipo.DisplayMember = "descripcion";
            this.CmbxTipo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxTipo.FormattingEnabled = true;
            this.CmbxTipo.Location = new System.Drawing.Point(499, 277);
            this.CmbxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxTipo.Name = "CmbxTipo";
            this.CmbxTipo.Size = new System.Drawing.Size(239, 26);
            this.CmbxTipo.TabIndex = 66;
            this.CmbxTipo.ValueMember = "id";
            // 
            // CmbxSucursal
            // 
            this.CmbxSucursal.DisplayMember = "direccion";
            this.CmbxSucursal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxSucursal.FormattingEnabled = true;
            this.CmbxSucursal.Location = new System.Drawing.Point(499, 236);
            this.CmbxSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxSucursal.Name = "CmbxSucursal";
            this.CmbxSucursal.Size = new System.Drawing.Size(239, 26);
            this.CmbxSucursal.TabIndex = 65;
            this.CmbxSucursal.ValueMember = "id";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(397, 244);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(67, 18);
            this.Label10.TabIndex = 64;
            this.Label10.Text = "Sucursal";
            // 
            // TxtCorreoProveedor
            // 
            this.TxtCorreoProveedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoProveedor.Location = new System.Drawing.Point(499, 147);
            this.TxtCorreoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCorreoProveedor.Name = "TxtCorreoProveedor";
            this.TxtCorreoProveedor.Size = new System.Drawing.Size(239, 31);
            this.TxtCorreoProveedor.TabIndex = 63;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(397, 160);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 18);
            this.Label1.TabIndex = 62;
            this.Label1.Text = "Correo";
            // 
            // TxtTelefonoProveedor
            // 
            this.TxtTelefonoProveedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoProveedor.Location = new System.Drawing.Point(499, 188);
            this.TxtTelefonoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefonoProveedor.Name = "TxtTelefonoProveedor";
            this.TxtTelefonoProveedor.Size = new System.Drawing.Size(239, 31);
            this.TxtTelefonoProveedor.TabIndex = 61;
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(499, 104);
            this.TxtNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(239, 31);
            this.TxtNombreProveedor.TabIndex = 60;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(397, 201);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 18);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "Telefono";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(397, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 18);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "Empresa";
            // 
            // BtnEliminarProveedor
            // 
            this.BtnEliminarProveedor.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarProveedor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProveedor.Location = new System.Drawing.Point(654, 335);
            this.BtnEliminarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarProveedor.Name = "BtnEliminarProveedor";
            this.BtnEliminarProveedor.Size = new System.Drawing.Size(102, 40);
            this.BtnEliminarProveedor.TabIndex = 57;
            this.BtnEliminarProveedor.Text = "ELIMINAR";
            this.BtnEliminarProveedor.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedor.Click += new System.EventHandler(this.BtnEliminarProveedor_Click);
            // 
            // BtnActualizarProveedor
            // 
            this.BtnActualizarProveedor.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarProveedor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarProveedor.Location = new System.Drawing.Point(516, 335);
            this.BtnActualizarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarProveedor.Name = "BtnActualizarProveedor";
            this.BtnActualizarProveedor.Size = new System.Drawing.Size(120, 40);
            this.BtnActualizarProveedor.TabIndex = 56;
            this.BtnActualizarProveedor.Text = "ACTUALIZAR";
            this.BtnActualizarProveedor.UseVisualStyleBackColor = false;
            this.BtnActualizarProveedor.Click += new System.EventHandler(this.BtnActualizarProveedor_Click);
            // 
            // BtnAgregarProveedor
            // 
            this.BtnAgregarProveedor.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarProveedor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProveedor.Location = new System.Drawing.Point(400, 335);
            this.BtnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarProveedor.Name = "BtnAgregarProveedor";
            this.BtnAgregarProveedor.Size = new System.Drawing.Size(98, 40);
            this.BtnAgregarProveedor.TabIndex = 55;
            this.BtnAgregarProveedor.Text = "AGREGAR";
            this.BtnAgregarProveedor.UseVisualStyleBackColor = false;
            this.BtnAgregarProveedor.Click += new System.EventHandler(this.BtnAgregarProveedor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 54);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 71;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 421);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.CmbxTipo);
            this.Controls.Add(this.CmbxSucursal);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TxtCorreoProveedor);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtTelefonoProveedor);
            this.Controls.Add(this.TxtNombreProveedor);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEliminarProveedor);
            this.Controls.Add(this.BtnActualizarProveedor);
            this.Controls.Add(this.BtnAgregarProveedor);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.ComboBox CmbxTipo;
        internal System.Windows.Forms.ComboBox CmbxSucursal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TxtCorreoProveedor;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTelefonoProveedor;
        internal System.Windows.Forms.TextBox TxtNombreProveedor;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEliminarProveedor;
        internal System.Windows.Forms.Button BtnActualizarProveedor;
        internal System.Windows.Forms.Button BtnAgregarProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}