
namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.LblAgregar = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.Lbleliminar = new System.Windows.Forms.Label();
            this.Lbldetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(24, 95);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.Size = new System.Drawing.Size(496, 245);
            this.dgw.TabIndex = 0;
            this.dgw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseClick);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(27, 54);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(65, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 20);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Image = global::TP_WinForm.Properties.Resources.registro_lupa;
            this.btnBuscar.Location = new System.Drawing.Point(462, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 55);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Image = global::TP_WinForm.Properties.Resources.registro_detalle;
            this.btnDetalle.Location = new System.Drawing.Point(443, 365);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 64);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TP_WinForm.Properties.Resources.registro__eliminado;
            this.btnEliminar.Location = new System.Drawing.Point(304, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 64);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TP_WinForm.Properties.Resources.registro_modificado;
            this.btnModificar.Location = new System.Drawing.Point(168, 365);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 64);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::TP_WinForm.Properties.Resources.registro_agregado1;
            this.btnAgregar.Location = new System.Drawing.Point(38, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 64);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pBox
            // 
            this.pBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox.Location = new System.Drawing.Point(526, 116);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(265, 224);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // LblAgregar
            // 
            this.LblAgregar.AutoSize = true;
            this.LblAgregar.Location = new System.Drawing.Point(49, 444);
            this.LblAgregar.Name = "LblAgregar";
            this.LblAgregar.Size = new System.Drawing.Size(44, 13);
            this.LblAgregar.TabIndex = 13;
            this.LblAgregar.Text = "Agregar";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(180, 444);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(50, 13);
            this.LblModificar.TabIndex = 14;
            this.LblModificar.Text = "Modificar";
            // 
            // Lbleliminar
            // 
            this.Lbleliminar.AutoSize = true;
            this.Lbleliminar.Location = new System.Drawing.Point(319, 444);
            this.Lbleliminar.Name = "Lbleliminar";
            this.Lbleliminar.Size = new System.Drawing.Size(43, 13);
            this.Lbleliminar.TabIndex = 15;
            this.Lbleliminar.Text = "Eliminar";
            // 
            // Lbldetalle
            // 
            this.Lbldetalle.AutoSize = true;
            this.Lbldetalle.Location = new System.Drawing.Point(457, 444);
            this.Lbldetalle.Name = "Lbldetalle";
            this.Lbldetalle.Size = new System.Drawing.Size(40, 13);
            this.Lbldetalle.TabIndex = 16;
            this.Lbldetalle.Text = "Detalle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 466);
            this.Controls.Add(this.Lbldetalle);
            this.Controls.Add(this.Lbleliminar);
            this.Controls.Add(this.LblModificar);
            this.Controls.Add(this.LblAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.dgw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lista de Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblAgregar;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label Lbleliminar;
        private System.Windows.Forms.Label Lbldetalle;
    }
}

