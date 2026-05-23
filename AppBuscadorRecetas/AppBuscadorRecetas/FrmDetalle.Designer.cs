namespace AppBuscadorRecetas
{
    partial class FrmDetalle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.lblCategoriaArea = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIngredientes = new System.Windows.Forms.TabPage();
            this.lvIngredientes = new System.Windows.Forms.ListView();
            this.colIngrediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabInstrucciones = new System.Windows.Forms.TabPage();
            this.rtxtInstrucciones = new System.Windows.Forms.RichTextBox();
            this.panelEncabezado.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabIngredientes.SuspendLayout();
            this.tabInstrucciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelEncabezado.Controls.Add(this.lblCategoriaArea);
            this.panelEncabezado.Controls.Add(this.lblNombreReceta);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(800, 100);
            this.panelEncabezado.TabIndex = 0;
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreReceta.ForeColor = System.Drawing.Color.White;
            this.lblNombreReceta.Location = new System.Drawing.Point(20, 15);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(150, 30);
            this.lblNombreReceta.TabIndex = 0;
            this.lblNombreReceta.Text = "Nombre Receta";
            // 
            // lblCategoriaArea
            // 
            this.lblCategoriaArea.AutoSize = true;
            this.lblCategoriaArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoriaArea.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaArea.Location = new System.Drawing.Point(20, 55);
            this.lblCategoriaArea.Name = "lblCategoriaArea";
            this.lblCategoriaArea.Size = new System.Drawing.Size(120, 19);
            this.lblCategoriaArea.TabIndex = 1;
            this.lblCategoriaArea.Text = "Categoría | Región";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIngredientes);
            this.tabControl1.Controls.Add(this.tabInstrucciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabIngredientes
            // 
            this.tabIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabIngredientes.Controls.Add(this.lvIngredientes);
            this.tabIngredientes.Location = new System.Drawing.Point(4, 29);
            this.tabIngredientes.Name = "tabIngredientes";
            this.tabIngredientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngredientes.Size = new System.Drawing.Size(792, 417);
            this.tabIngredientes.TabIndex = 0;
            this.tabIngredientes.Text = "📋 Ingredientes";
            // 
            // lvIngredientes
            // 
            this.lvIngredientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIngrediente,
            this.colMedida});
            this.lvIngredientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIngredientes.FullRowSelect = true;
            this.lvIngredientes.GridLines = true;
            this.lvIngredientes.Location = new System.Drawing.Point(3, 3);
            this.lvIngredientes.Name = "lvIngredientes";
            this.lvIngredientes.Size = new System.Drawing.Size(786, 411);
            this.lvIngredientes.TabIndex = 0;
            this.lvIngredientes.UseCompatibleStateImageBehavior = false;
            this.lvIngredientes.View = System.Windows.Forms.View.Details;
            // 
            // colIngrediente
            // 
            this.colIngrediente.Text = "Ingrediente";
            this.colIngrediente.Width = 450;
            // 
            // colMedida
            // 
            this.colMedida.Text = "Cantidad";
            this.colMedida.Width = 280;
            // 
            // tabInstrucciones
            // 
            this.tabInstrucciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabInstrucciones.Controls.Add(this.rtxtInstrucciones);
            this.tabInstrucciones.Location = new System.Drawing.Point(4, 29);
            this.tabInstrucciones.Name = "tabInstrucciones";
            this.tabInstrucciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstrucciones.Size = new System.Drawing.Size(792, 417);
            this.tabInstrucciones.TabIndex = 1;
            this.tabInstrucciones.Text = "👨‍🍳 Modo de Preparación";
            // 
            // rtxtInstrucciones
            // 
            this.rtxtInstrucciones.BackColor = System.Drawing.Color.White;
            this.rtxtInstrucciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInstrucciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtxtInstrucciones.Location = new System.Drawing.Point(3, 3);
            this.rtxtInstrucciones.Name = "rtxtInstrucciones";
            this.rtxtInstrucciones.ReadOnly = true;
            this.rtxtInstrucciones.Size = new System.Drawing.Size(786, 411);
            this.rtxtInstrucciones.TabIndex = 0;
            this.rtxtInstrucciones.Text = "";
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles de la Receta";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabIngredientes.ResumeLayout(false);
            this.tabInstrucciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblCategoriaArea;
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIngredientes;
        private System.Windows.Forms.ListView lvIngredientes;
        private System.Windows.Forms.ColumnHeader colIngrediente;
        private System.Windows.Forms.ColumnHeader colMedida;
        private System.Windows.Forms.TabPage tabInstrucciones;
        private System.Windows.Forms.RichTextBox rtxtInstrucciones;
    }
}
