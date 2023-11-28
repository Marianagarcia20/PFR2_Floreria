namespace PFR2_Floreria
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.CmbxFlor = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbxProveedor = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminarCompra = new System.Windows.Forms.Button();
            this.BtnActualizarCompra = new System.Windows.Forms.Button();
            this.BtnAgregarCompra = new System.Windows.Forms.Button();
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
            this.Panel1.Location = new System.Drawing.Point(-9, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(830, 49);
            this.Panel1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(424, 166);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 18);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(574, 159);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(206, 31);
            this.TxtPrecio.TabIndex = 65;
            // 
            // CmbxFlor
            // 
            this.CmbxFlor.DisplayMember = "color";
            this.CmbxFlor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxFlor.FormattingEnabled = true;
            this.CmbxFlor.Location = new System.Drawing.Point(574, 286);
            this.CmbxFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxFlor.Name = "CmbxFlor";
            this.CmbxFlor.Size = new System.Drawing.Size(206, 26);
            this.CmbxFlor.TabIndex = 64;
            this.CmbxFlor.ValueMember = "id";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(424, 294);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(36, 18);
            this.Label5.TabIndex = 63;
            this.Label5.Text = "Flor";
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
            this.DataGridView1.Location = new System.Drawing.Point(30, 105);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(387, 270);
            this.DataGridView1.TabIndex = 62;
            // 
            // CmbxProveedor
            // 
            this.CmbxProveedor.DisplayMember = "nombre_empresa";
            this.CmbxProveedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxProveedor.FormattingEnabled = true;
            this.CmbxProveedor.Location = new System.Drawing.Point(574, 248);
            this.CmbxProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxProveedor.Name = "CmbxProveedor";
            this.CmbxProveedor.Size = new System.Drawing.Size(206, 26);
            this.CmbxProveedor.TabIndex = 61;
            this.CmbxProveedor.ValueMember = "id";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(425, 256);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 18);
            this.Label4.TabIndex = 60;
            this.Label4.Text = "Proveedor";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(574, 115);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(206, 31);
            this.DateTimePicker1.TabIndex = 59;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(574, 203);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(206, 31);
            this.TxtCantidad.TabIndex = 58;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(424, 213);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 18);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Cantidad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(424, 128);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(132, 18);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Fecha de Surtido";
            // 
            // BtnEliminarCompra
            // 
            this.BtnEliminarCompra.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarCompra.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarCompra.Location = new System.Drawing.Point(683, 334);
            this.BtnEliminarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarCompra.Name = "BtnEliminarCompra";
            this.BtnEliminarCompra.Size = new System.Drawing.Size(98, 38);
            this.BtnEliminarCompra.TabIndex = 55;
            this.BtnEliminarCompra.Text = "ELIMINAR";
            this.BtnEliminarCompra.UseVisualStyleBackColor = false;
            this.BtnEliminarCompra.Click += new System.EventHandler(this.BtnEliminarCompra_Click);
            // 
            // BtnActualizarCompra
            // 
            this.BtnActualizarCompra.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarCompra.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarCompra.Location = new System.Drawing.Point(558, 334);
            this.BtnActualizarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarCompra.Name = "BtnActualizarCompra";
            this.BtnActualizarCompra.Size = new System.Drawing.Size(115, 38);
            this.BtnActualizarCompra.TabIndex = 54;
            this.BtnActualizarCompra.Text = "ACTUALIZAR";
            this.BtnActualizarCompra.UseVisualStyleBackColor = false;
            this.BtnActualizarCompra.Click += new System.EventHandler(this.BtnActualizarCompra_Click);
            // 
            // BtnAgregarCompra
            // 
            this.BtnAgregarCompra.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarCompra.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCompra.Location = new System.Drawing.Point(431, 336);
            this.BtnAgregarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarCompra.Name = "BtnAgregarCompra";
            this.BtnAgregarCompra.Size = new System.Drawing.Size(115, 35);
            this.BtnAgregarCompra.TabIndex = 53;
            this.BtnAgregarCompra.Text = "AGREGAR";
            this.BtnAgregarCompra.UseVisualStyleBackColor = false;
            this.BtnAgregarCompra.Click += new System.EventHandler(this.BtnAgregarCompra_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(553, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 25);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "SURTIDO";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(30, 53);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 68;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.CmbxFlor);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CmbxProveedor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEliminarCompra);
            this.Controls.Add(this.BtnActualizarCompra);
            this.Controls.Add(this.BtnAgregarCompra);
            this.Controls.Add(this.Label1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtPrecio;
        internal System.Windows.Forms.ComboBox CmbxFlor;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox CmbxProveedor;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox TxtCantidad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEliminarCompra;
        internal System.Windows.Forms.Button BtnActualizarCompra;
        internal System.Windows.Forms.Button BtnAgregarCompra;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}