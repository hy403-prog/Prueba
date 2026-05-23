namespace AppBuscadorRecetas
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelRecetas = new System.Windows.Forms.Panel();
            this.panelReceta3 = new System.Windows.Forms.Panel();
            this.lblReceta3 = new System.Windows.Forms.Label();
            this.btnVer3 = new System.Windows.Forms.Button();
            this.panelReceta2 = new System.Windows.Forms.Panel();
            this.lblReceta2 = new System.Windows.Forms.Label();
            this.btnVer2 = new System.Windows.Forms.Button();
            this.panelReceta1 = new System.Windows.Forms.Panel();
            this.lblReceta1 = new System.Windows.Forms.Label();
            this.btnVer1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelRecetas.SuspendLayout();
            this.panelReceta3.SuspendLayout();
            this.panelReceta2.SuspendLayout();
            this.panelReceta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIngrediente);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 120);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un ingrediente:";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIngrediente.Location = new System.Drawing.Point(30, 50);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(500, 28);
            this.txtIngrediente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(550, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblMensaje.Location = new System.Drawing.Point(30, 130);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(248, 19);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Busca un ingrediente para comenzar";
            // 
            // panelRecetas
            // 
            this.panelRecetas.AutoScroll = true;
            this.panelRecetas.Controls.Add(this.panelReceta3);
            this.panelRecetas.Controls.Add(this.panelReceta2);
            this.panelRecetas.Controls.Add(this.panelReceta1);
            this.panelRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecetas.Location = new System.Drawing.Point(0, 120);
            this.panelRecetas.Name = "panelRecetas";
            this.panelRecetas.Size = new System.Drawing.Size(900, 550);
            this.panelRecetas.TabIndex = 2;
            // 
            // panelReceta3
            // 
            this.panelReceta3.BackColor = System.Drawing.Color.White;
            this.panelReceta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceta3.Controls.Add(this.lblReceta3);
            this.panelReceta3.Controls.Add(this.btnVer3);
            this.panelReceta3.Location = new System.Drawing.Point(30, 340);
            this.panelReceta3.Name = "panelReceta3";
            this.panelReceta3.Size = new System.Drawing.Size(840, 80);
            this.panelReceta3.TabIndex = 5;
            // 
            // lblReceta3
            // 
            this.lblReceta3.AutoSize = true;
            this.lblReceta3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReceta3.Location = new System.Drawing.Point(15, 15);
            this.lblReceta3.Name = "lblReceta3";
            this.lblReceta3.Size = new System.Drawing.Size(95, 20);
            this.lblReceta3.TabIndex = 0;
            this.lblReceta3.Text = "Opción 3: ...";
            // 
            // btnVer3
            // 
            this.btnVer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnVer3.Enabled = false;
            this.btnVer3.FlatAppearance.BorderSize = 0;
            this.btnVer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVer3.ForeColor = System.Drawing.Color.White;
            this.btnVer3.Location = new System.Drawing.Point(720, 22);
            this.btnVer3.Name = "btnVer3";
            this.btnVer3.Size = new System.Drawing.Size(100, 35);
            this.btnVer3.TabIndex = 1;
            this.btnVer3.Text = "Ver Detalles";
            this.btnVer3.UseVisualStyleBackColor = false;
            this.btnVer3.Click += new System.EventHandler(this.btnVer3_Click);
            // 
            // panelReceta2
            // 
            this.panelReceta2.BackColor = System.Drawing.Color.White;
            this.panelReceta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceta2.Controls.Add(this.lblReceta2);
            this.panelReceta2.Controls.Add(this.btnVer2);
            this.panelReceta2.Location = new System.Drawing.Point(30, 240);
            this.panelReceta2.Name = "panelReceta2";
            this.panelReceta2.Size = new System.Drawing.Size(840, 80);
            this.panelReceta2.TabIndex = 4;
            // 
            // lblReceta2
            // 
            this.lblReceta2.AutoSize = true;
            this.lblReceta2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReceta2.Location = new System.Drawing.Point(15, 15);
            this.lblReceta2.Name = "lblReceta2";
            this.lblReceta2.Size = new System.Drawing.Size(95, 20);
            this.lblReceta2.TabIndex = 0;
            this.lblReceta2.Text = "Opción 2: ...";
            // 
            // btnVer2
            // 
            this.btnVer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnVer2.Enabled = false;
            this.btnVer2.FlatAppearance.BorderSize = 0;
            this.btnVer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVer2.ForeColor = System.Drawing.Color.White;
            this.btnVer2.Location = new System.Drawing.Point(720, 22);
            this.btnVer2.Name = "btnVer2";
            this.btnVer2.Size = new System.Drawing.Size(100, 35);
            this.btnVer2.TabIndex = 1;
            this.btnVer2.Text = "Ver Detalles";
            this.btnVer2.UseVisualStyleBackColor = false;
            this.btnVer2.Click += new System.EventHandler(this.btnVer2_Click);
            // 
            // panelReceta1
            // 
            this.panelReceta1.BackColor = System.Drawing.Color.White;
            this.panelReceta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceta1.Controls.Add(this.lblReceta1);
            this.panelReceta1.Controls.Add(this.btnVer1);
            this.panelReceta1.Location = new System.Drawing.Point(30, 140);
            this.panelReceta1.Name = "panelReceta1";
            this.panelReceta1.Size = new System.Drawing.Size(840, 80);
            this.panelReceta1.TabIndex = 3;
            // 
            // lblReceta1
            // 
            this.lblReceta1.AutoSize = true;
            this.lblReceta1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReceta1.Location = new System.Drawing.Point(15, 15);
            this.lblReceta1.Name = "lblReceta1";
            this.lblReceta1.Size = new System.Drawing.Size(95, 20);
            this.lblReceta1.TabIndex = 0;
            this.lblReceta1.Text = "Opción 1: ...";
            // 
            // btnVer1
            // 
            this.btnVer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnVer1.Enabled = false;
            this.btnVer1.FlatAppearance.BorderSize = 0;
            this.btnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVer1.ForeColor = System.Drawing.Color.White;
            this.btnVer1.Location = new System.Drawing.Point(720, 22);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(100, 35);
            this.btnVer1.TabIndex = 1;
            this.btnVer1.Text = "Ver Detalles";
            this.btnVer1.UseVisualStyleBackColor = false;
            this.btnVer1.Click += new System.EventHandler(this.btnVer1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelRecetas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Buscador de Recetas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRecetas.ResumeLayout(false);
            this.panelReceta3.ResumeLayout(false);
            this.panelReceta3.PerformLayout();
            this.panelReceta2.ResumeLayout(false);
            this.panelReceta2.PerformLayout();
            this.panelReceta1.ResumeLayout(false);
            this.panelReceta1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panelRecetas;
        private System.Windows.Forms.Panel panelReceta3;
        private System.Windows.Forms.Label lblReceta3;
        private System.Windows.Forms.Button btnVer3;
        private System.Windows.Forms.Panel panelReceta2;
        private System.Windows.Forms.Label lblReceta2;
        private System.Windows.Forms.Button btnVer2;
        private System.Windows.Forms.Panel panelReceta1;
        private System.Windows.Forms.Label lblReceta1;
        private System.Windows.Forms.Button btnVer1;
    }
}
