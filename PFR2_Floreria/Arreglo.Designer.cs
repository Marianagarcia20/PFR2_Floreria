namespace PFR2_Floreria
{
    partial class Arreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arreglo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtNombreArreglo = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbxTamanio = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.CmbxTipoArreglo = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtPrecioArreglo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtColorArreglo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BtnEliminarArreglo = new System.Windows.Forms.Button();
            this.BtnActualizarArreglo = new System.Windows.Forms.Button();
            this.BtnAgregarArreglo = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
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
            this.Panel1.Location = new System.Drawing.Point(0, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(780, 49);
            this.Panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // TxtNombreArreglo
            // 
            this.TxtNombreArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreArreglo.Location = new System.Drawing.Point(501, 105);
            this.TxtNombreArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreArreglo.Name = "TxtNombreArreglo";
            this.TxtNombreArreglo.Size = new System.Drawing.Size(250, 31);
            this.TxtNombreArreglo.TabIndex = 59;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(417, 118);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(68, 18);
            this.Label7.TabIndex = 58;
            this.Label7.Text = "Nombre";
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
            this.DataGridView1.Location = new System.Drawing.Point(16, 108);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(371, 257);
            this.DataGridView1.TabIndex = 57;
            // 
            // CmbxTamanio
            // 
            this.CmbxTamanio.DisplayMember = "descripcion";
            this.CmbxTamanio.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxTamanio.FormattingEnabled = true;
            this.CmbxTamanio.Location = new System.Drawing.Point(501, 290);
            this.CmbxTamanio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxTamanio.Name = "CmbxTamanio";
            this.CmbxTamanio.Size = new System.Drawing.Size(250, 26);
            this.CmbxTamanio.TabIndex = 56;
            this.CmbxTamanio.ValueMember = "id";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(417, 295);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(67, 18);
            this.Label6.TabIndex = 55;
            this.Label6.Text = "Tamaño";
            // 
            // CmbxTipoArreglo
            // 
            this.CmbxTipoArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxTipoArreglo.FormattingEnabled = true;
            this.CmbxTipoArreglo.Location = new System.Drawing.Point(501, 249);
            this.CmbxTipoArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxTipoArreglo.Name = "CmbxTipoArreglo";
            this.CmbxTipoArreglo.Size = new System.Drawing.Size(250, 26);
            this.CmbxTipoArreglo.TabIndex = 54;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(417, 257);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 18);
            this.Label5.TabIndex = 53;
            this.Label5.Text = "Tipo ";
            // 
            // TxtPrecioArreglo
            // 
            this.TxtPrecioArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioArreglo.Location = new System.Drawing.Point(501, 201);
            this.TxtPrecioArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioArreglo.Name = "TxtPrecioArreglo";
            this.TxtPrecioArreglo.Size = new System.Drawing.Size(250, 31);
            this.TxtPrecioArreglo.TabIndex = 52;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(417, 214);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 18);
            this.Label4.TabIndex = 51;
            this.Label4.Text = "Precio";
            // 
            // TxtColorArreglo
            // 
            this.TxtColorArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColorArreglo.Location = new System.Drawing.Point(501, 153);
            this.TxtColorArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtColorArreglo.Name = "TxtColorArreglo";
            this.TxtColorArreglo.Size = new System.Drawing.Size(250, 31);
            this.TxtColorArreglo.TabIndex = 50;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(417, 166);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 18);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "Color";
            // 
            // BtnEliminarArreglo
            // 
            this.BtnEliminarArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarArreglo.Location = new System.Drawing.Point(665, 341);
            this.BtnEliminarArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarArreglo.Name = "BtnEliminarArreglo";
            this.BtnEliminarArreglo.Size = new System.Drawing.Size(104, 39);
            this.BtnEliminarArreglo.TabIndex = 48;
            this.BtnEliminarArreglo.Text = "ELIMINAR";
            this.BtnEliminarArreglo.UseVisualStyleBackColor = false;
            this.BtnEliminarArreglo.Click += new System.EventHandler(this.BtnEliminarArreglo_Click);
            // 
            // BtnActualizarArreglo
            // 
            this.BtnActualizarArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarArreglo.Location = new System.Drawing.Point(527, 340);
            this.BtnActualizarArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarArreglo.Name = "BtnActualizarArreglo";
            this.BtnActualizarArreglo.Size = new System.Drawing.Size(127, 41);
            this.BtnActualizarArreglo.TabIndex = 47;
            this.BtnActualizarArreglo.Text = "ACTUALIZAR";
            this.BtnActualizarArreglo.UseVisualStyleBackColor = false;
            this.BtnActualizarArreglo.Click += new System.EventHandler(this.BtnActualizarArreglo_Click);
            // 
            // BtnAgregarArreglo
            // 
            this.BtnAgregarArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarArreglo.Location = new System.Drawing.Point(412, 340);
            this.BtnAgregarArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarArreglo.Name = "BtnAgregarArreglo";
            this.BtnAgregarArreglo.Size = new System.Drawing.Size(102, 41);
            this.BtnAgregarArreglo.TabIndex = 46;
            this.BtnAgregarArreglo.Text = "AGREGAR";
            this.BtnAgregarArreglo.UseVisualStyleBackColor = false;
            this.BtnAgregarArreglo.Click += new System.EventHandler(this.BtnAgregarArreglo_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(522, 170);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 18);
            this.Label2.TabIndex = 45;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(556, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 25);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "ARREGLO";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(16, 57);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 61;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Arreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TxtNombreArreglo);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CmbxTamanio);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.CmbxTipoArreglo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxtPrecioArreglo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtColorArreglo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnEliminarArreglo);
            this.Controls.Add(this.BtnActualizarArreglo);
            this.Controls.Add(this.BtnAgregarArreglo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Arreglo";
            this.Text = "Arreglo";
            this.Load += new System.EventHandler(this.Arreglo_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox TxtNombreArreglo;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox CmbxTamanio;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox CmbxTipoArreglo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtPrecioArreglo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtColorArreglo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button BtnEliminarArreglo;
        internal System.Windows.Forms.Button BtnActualizarArreglo;
        internal System.Windows.Forms.Button BtnAgregarArreglo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}