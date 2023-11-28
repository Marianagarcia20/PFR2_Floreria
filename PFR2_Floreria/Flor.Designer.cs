namespace PFR2_Floreria
{
    partial class Flor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbxTipo = new System.Windows.Forms.ComboBox();
            this.CmbxTemporada = new System.Windows.Forms.ComboBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.BtnEliminarFlor = new System.Windows.Forms.Button();
            this.BtnActualizarFlor = new System.Windows.Forms.Button();
            this.BtnAgregarFlor = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
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
            this.Panel1.Location = new System.Drawing.Point(-177, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(976, 49);
            this.Panel1.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(915, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
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
            this.DataGridView1.Location = new System.Drawing.Point(32, 100);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(367, 243);
            this.DataGridView1.TabIndex = 65;
            // 
            // CmbxTipo
            // 
            this.CmbxTipo.DisplayMember = "descripcion";
            this.CmbxTipo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxTipo.FormattingEnabled = true;
            this.CmbxTipo.Location = new System.Drawing.Point(538, 225);
            this.CmbxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxTipo.Name = "CmbxTipo";
            this.CmbxTipo.Size = new System.Drawing.Size(246, 26);
            this.CmbxTipo.TabIndex = 64;
            this.CmbxTipo.ValueMember = "id";
            // 
            // CmbxTemporada
            // 
            this.CmbxTemporada.DisplayMember = "descripcion";
            this.CmbxTemporada.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxTemporada.FormattingEnabled = true;
            this.CmbxTemporada.Location = new System.Drawing.Point(538, 183);
            this.CmbxTemporada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxTemporada.Name = "CmbxTemporada";
            this.CmbxTemporada.Size = new System.Drawing.Size(246, 26);
            this.CmbxTemporada.TabIndex = 63;
            this.CmbxTemporada.ValueMember = "id";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCosto.Location = new System.Drawing.Point(538, 137);
            this.TxtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(246, 31);
            this.TxtCosto.TabIndex = 62;
            // 
            // TxtColor
            // 
            this.TxtColor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor.Location = new System.Drawing.Point(538, 97);
            this.TxtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(246, 31);
            this.TxtColor.TabIndex = 61;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(431, 233);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(42, 18);
            this.Label6.TabIndex = 60;
            this.Label6.Text = "Tipo";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(431, 191);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 18);
            this.Label5.TabIndex = 59;
            this.Label5.Text = "Temporada";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(431, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 18);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "Costo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(431, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 18);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Color";
            // 
            // BtnEliminarFlor
            // 
            this.BtnEliminarFlor.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarFlor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFlor.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarFlor.Location = new System.Drawing.Point(685, 270);
            this.BtnEliminarFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarFlor.Name = "BtnEliminarFlor";
            this.BtnEliminarFlor.Size = new System.Drawing.Size(99, 43);
            this.BtnEliminarFlor.TabIndex = 56;
            this.BtnEliminarFlor.Text = "ELIMINAR";
            this.BtnEliminarFlor.UseVisualStyleBackColor = false;
            this.BtnEliminarFlor.Click += new System.EventHandler(this.BtnEliminarFlor_Click);
            // 
            // BtnActualizarFlor
            // 
            this.BtnActualizarFlor.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarFlor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarFlor.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarFlor.Location = new System.Drawing.Point(553, 270);
            this.BtnActualizarFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarFlor.Name = "BtnActualizarFlor";
            this.BtnActualizarFlor.Size = new System.Drawing.Size(110, 43);
            this.BtnActualizarFlor.TabIndex = 55;
            this.BtnActualizarFlor.Text = "ACTUALIZAR";
            this.BtnActualizarFlor.UseVisualStyleBackColor = false;
            this.BtnActualizarFlor.Click += new System.EventHandler(this.BtnActualizarFlor_Click);
            // 
            // BtnAgregarFlor
            // 
            this.BtnAgregarFlor.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarFlor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarFlor.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarFlor.Location = new System.Drawing.Point(434, 270);
            this.BtnAgregarFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarFlor.Name = "BtnAgregarFlor";
            this.BtnAgregarFlor.Size = new System.Drawing.Size(101, 43);
            this.BtnAgregarFlor.TabIndex = 54;
            this.BtnAgregarFlor.Text = "AGREGAR";
            this.BtnAgregarFlor.UseVisualStyleBackColor = false;
            this.BtnAgregarFlor.Click += new System.EventHandler(this.BtnAgregarFlor_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(600, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 25);
            this.Label2.TabIndex = 53;
            this.Label2.Text = "FLOR";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(32, 52);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 67;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Flor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CmbxTipo);
            this.Controls.Add(this.CmbxTemporada);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnEliminarFlor);
            this.Controls.Add(this.BtnActualizarFlor);
            this.Controls.Add(this.BtnAgregarFlor);
            this.Controls.Add(this.Label2);
            this.Name = "Flor";
            this.Text = "Flor";
            this.Load += new System.EventHandler(this.Flor_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox CmbxTipo;
        internal System.Windows.Forms.ComboBox CmbxTemporada;
        internal System.Windows.Forms.TextBox TxtCosto;
        internal System.Windows.Forms.TextBox TxtColor;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button BtnEliminarFlor;
        internal System.Windows.Forms.Button BtnActualizarFlor;
        internal System.Windows.Forms.Button BtnAgregarFlor;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}