namespace PFR2_Floreria
{
    partial class Flor_Arreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flor_Arreglo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtCantidadFlorArreglo = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbxFlor = new System.Windows.Forms.ComboBox();
            this.CmbxArreglo = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminarFlorArreglo = new System.Windows.Forms.Button();
            this.BtnActualizarFlorArreglo = new System.Windows.Forms.Button();
            this.BtnAgregarFlorArreglo = new System.Windows.Forms.Button();
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
            this.Panel1.Location = new System.Drawing.Point(-123, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(945, 49);
            this.Panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(863, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // TxtCantidadFlorArreglo
            // 
            this.TxtCantidadFlorArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadFlorArreglo.Location = new System.Drawing.Point(546, 109);
            this.TxtCantidadFlorArreglo.Name = "TxtCantidadFlorArreglo";
            this.TxtCantidadFlorArreglo.Size = new System.Drawing.Size(225, 31);
            this.TxtCantidadFlorArreglo.TabIndex = 64;
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
            this.DataGridView1.Location = new System.Drawing.Point(19, 109);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(391, 276);
            this.DataGridView1.TabIndex = 63;
            // 
            // CmbxFlor
            // 
            this.CmbxFlor.DisplayMember = "color";
            this.CmbxFlor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxFlor.FormattingEnabled = true;
            this.CmbxFlor.Location = new System.Drawing.Point(546, 202);
            this.CmbxFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxFlor.Name = "CmbxFlor";
            this.CmbxFlor.Size = new System.Drawing.Size(225, 26);
            this.CmbxFlor.TabIndex = 62;
            this.CmbxFlor.ValueMember = "id";
            // 
            // CmbxArreglo
            // 
            this.CmbxArreglo.DisplayMember = "nombre";
            this.CmbxArreglo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxArreglo.FormattingEnabled = true;
            this.CmbxArreglo.Location = new System.Drawing.Point(546, 157);
            this.CmbxArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxArreglo.Name = "CmbxArreglo";
            this.CmbxArreglo.Size = new System.Drawing.Size(225, 26);
            this.CmbxArreglo.TabIndex = 61;
            this.CmbxArreglo.ValueMember = "id";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(452, 210);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 18);
            this.Label4.TabIndex = 60;
            this.Label4.Text = "Flor";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(452, 165);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(63, 18);
            this.Label3.TabIndex = 59;
            this.Label3.Text = "Arreglo";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(452, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 18);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "Cantidad";
            // 
            // BtnEliminarFlorArreglo
            // 
            this.BtnEliminarFlorArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarFlorArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFlorArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarFlorArreglo.Location = new System.Drawing.Point(693, 261);
            this.BtnEliminarFlorArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarFlorArreglo.Name = "BtnEliminarFlorArreglo";
            this.BtnEliminarFlorArreglo.Size = new System.Drawing.Size(93, 41);
            this.BtnEliminarFlorArreglo.TabIndex = 57;
            this.BtnEliminarFlorArreglo.Text = "ELIMINAR";
            this.BtnEliminarFlorArreglo.UseVisualStyleBackColor = false;
            this.BtnEliminarFlorArreglo.Click += new System.EventHandler(this.BtnEliminarFlorArreglo_Click);
            // 
            // BtnActualizarFlorArreglo
            // 
            this.BtnActualizarFlorArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarFlorArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarFlorArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarFlorArreglo.Location = new System.Drawing.Point(563, 261);
            this.BtnActualizarFlorArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarFlorArreglo.Name = "BtnActualizarFlorArreglo";
            this.BtnActualizarFlorArreglo.Size = new System.Drawing.Size(112, 41);
            this.BtnActualizarFlorArreglo.TabIndex = 56;
            this.BtnActualizarFlorArreglo.Text = "ACTUALIZAR";
            this.BtnActualizarFlorArreglo.UseVisualStyleBackColor = false;
            this.BtnActualizarFlorArreglo.Click += new System.EventHandler(this.BtnActualizarFlorArreglo_Click);
            // 
            // BtnAgregarFlorArreglo
            // 
            this.BtnAgregarFlorArreglo.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarFlorArreglo.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarFlorArreglo.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarFlorArreglo.Location = new System.Drawing.Point(451, 261);
            this.BtnAgregarFlorArreglo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarFlorArreglo.Name = "BtnAgregarFlorArreglo";
            this.BtnAgregarFlorArreglo.Size = new System.Drawing.Size(96, 41);
            this.BtnAgregarFlorArreglo.TabIndex = 55;
            this.BtnAgregarFlorArreglo.Text = "AGREGAR";
            this.BtnAgregarFlorArreglo.UseVisualStyleBackColor = false;
            this.BtnAgregarFlorArreglo.Click += new System.EventHandler(this.BtnAgregarFlorArreglo_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(571, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 25);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "FLOR ARREGLO";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(19, 56);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 66;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Flor_Arreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TxtCantidadFlorArreglo);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CmbxFlor);
            this.Controls.Add(this.CmbxArreglo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEliminarFlorArreglo);
            this.Controls.Add(this.BtnActualizarFlorArreglo);
            this.Controls.Add(this.BtnAgregarFlorArreglo);
            this.Controls.Add(this.Label1);
            this.Name = "Flor_Arreglo";
            this.Text = "Flor_Arreglo";
            this.Load += new System.EventHandler(this.Flor_Arreglo_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox TxtCantidadFlorArreglo;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox CmbxFlor;
        internal System.Windows.Forms.ComboBox CmbxArreglo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEliminarFlorArreglo;
        internal System.Windows.Forms.Button BtnActualizarFlorArreglo;
        internal System.Windows.Forms.Button BtnAgregarFlorArreglo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}