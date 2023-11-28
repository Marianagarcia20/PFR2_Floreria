namespace PFR2_Floreria
{
    partial class Temporada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temporada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtDescripcionT = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminarTemporada = new System.Windows.Forms.Button();
            this.BtnActualizarTemporada = new System.Windows.Forms.Button();
            this.BtnAgregarTemporada = new System.Windows.Forms.Button();
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
            this.Panel1.Location = new System.Drawing.Point(-10, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(860, 49);
            this.Panel1.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(792, 0);
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
            this.DataGridView1.Location = new System.Drawing.Point(19, 105);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(427, 214);
            this.DataGridView1.TabIndex = 62;
            // 
            // TxtDescripcionT
            // 
            this.TxtDescripcionT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionT.Location = new System.Drawing.Point(585, 105);
            this.TxtDescripcionT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescripcionT.Name = "TxtDescripcionT";
            this.TxtDescripcionT.Size = new System.Drawing.Size(236, 31);
            this.TxtDescripcionT.TabIndex = 61;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(472, 116);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 18);
            this.Label2.TabIndex = 60;
            this.Label2.Text = "Descripcion";
            // 
            // BtnEliminarTemporada
            // 
            this.BtnEliminarTemporada.BackColor = System.Drawing.Color.Black;
            this.BtnEliminarTemporada.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarTemporada.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarTemporada.Location = new System.Drawing.Point(718, 168);
            this.BtnEliminarTemporada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarTemporada.Name = "BtnEliminarTemporada";
            this.BtnEliminarTemporada.Size = new System.Drawing.Size(103, 39);
            this.BtnEliminarTemporada.TabIndex = 59;
            this.BtnEliminarTemporada.Text = "ELIMINAR";
            this.BtnEliminarTemporada.UseVisualStyleBackColor = false;
            this.BtnEliminarTemporada.Click += new System.EventHandler(this.BtnEliminarTemporada_Click);
            // 
            // BtnActualizarTemporada
            // 
            this.BtnActualizarTemporada.BackColor = System.Drawing.Color.Black;
            this.BtnActualizarTemporada.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarTemporada.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarTemporada.Location = new System.Drawing.Point(589, 168);
            this.BtnActualizarTemporada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizarTemporada.Name = "BtnActualizarTemporada";
            this.BtnActualizarTemporada.Size = new System.Drawing.Size(122, 39);
            this.BtnActualizarTemporada.TabIndex = 58;
            this.BtnActualizarTemporada.Text = "ACTUALIZAR";
            this.BtnActualizarTemporada.UseVisualStyleBackColor = false;
            this.BtnActualizarTemporada.Click += new System.EventHandler(this.BtnActualizarTemporada_Click);
            // 
            // BtnAgregarTemporada
            // 
            this.BtnAgregarTemporada.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarTemporada.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarTemporada.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarTemporada.Location = new System.Drawing.Point(475, 168);
            this.BtnAgregarTemporada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarTemporada.Name = "BtnAgregarTemporada";
            this.BtnAgregarTemporada.Size = new System.Drawing.Size(105, 39);
            this.BtnAgregarTemporada.TabIndex = 57;
            this.BtnAgregarTemporada.Text = "AGREGAR";
            this.BtnAgregarTemporada.UseVisualStyleBackColor = false;
            this.BtnAgregarTemporada.Click += new System.EventHandler(this.BtnAgregarTemporada_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("212 Orion Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(552, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(210, 25);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "TEMPORADAS DE FLORES";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Black;
            this.BtnRegresar.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(19, 54);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(102, 41);
            this.BtnRegresar.TabIndex = 64;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 346);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TxtDescripcionT);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEliminarTemporada);
            this.Controls.Add(this.BtnActualizarTemporada);
            this.Controls.Add(this.BtnAgregarTemporada);
            this.Controls.Add(this.Label1);
            this.Name = "Temporada";
            this.Text = "Temporada";
            this.Load += new System.EventHandler(this.Temporada_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox TxtDescripcionT;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEliminarTemporada;
        internal System.Windows.Forms.Button BtnActualizarTemporada;
        internal System.Windows.Forms.Button BtnAgregarTemporada;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnRegresar;
    }
}