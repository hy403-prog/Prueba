using AppBuscadorRecetas.Modelos;
using AppBuscadorRecetas.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuscadorRecetas
{
    public partial class FrmPrincipal : Form
    {
        private List<Receta> recetasEncontradas = new List<Receta>();

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = "Buscador de Recetas";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 245, 245);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarRecetas();
        }

        private async Task BuscarRecetas()
        {
            string ingrediente = txtIngrediente.Text.Trim();
            
            if (string.IsNullOrEmpty(ingrediente))
            {
                MessageBox.Show("Por favor ingrese un ingrediente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnBuscar.Enabled = false;
                btnBuscar.Text = "Buscando...";
                lblMensaje.Text = "Buscando recetas...";
                LimpiarRecetas();

                recetasEncontradas = await ServicioRecetas.BuscarPorIngredienteAsync(ingrediente);

                if (recetasEncontradas.Count > 0)
                {
                    await MostrarRecetas();
                    lblMensaje.Text = $"Se encontraron {recetasEncontradas.Count} recetas";
                }
                else
                {
                    lblMensaje.Text = "No se encontraron recetas con ese ingrediente";
                    MessageBox.Show("No se encontraron recetas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMensaje.Text = "Error en la búsqueda";
            }
            finally
            {
                btnBuscar.Enabled = true;
                btnBuscar.Text = "Buscar";
            }
        }

        private async Task MostrarRecetas()
        {
            if (recetasEncontradas.Count > 0)
            {
                string nombreTraducido1 = await Traductor.InglesAEspanolAsync(recetasEncontradas[0].strMeal);
                lblReceta1.Text = "🍽️ " + nombreTraducido1;
                btnVer1.Enabled = true;
            }
            else
            {
                lblReceta1.Text = "Opción 1: No disponible";
                btnVer1.Enabled = false;
            }

            if (recetasEncontradas.Count > 1)
            {
                string nombreTraducido2 = await Traductor.InglesAEspanolAsync(recetasEncontradas[1].strMeal);
                lblReceta2.Text = "🍽️ " + nombreTraducido2;
                btnVer2.Enabled = true;
            }
            else
            {
                lblReceta2.Text = "Opción 2: No disponible";
                btnVer2.Enabled = false;
            }

            if (recetasEncontradas.Count > 2)
            {
                string nombreTraducido3 = await Traductor.InglesAEspanolAsync(recetasEncontradas[2].strMeal);
                lblReceta3.Text = "🍽️ " + nombreTraducido3;
                btnVer3.Enabled = true;
            }
            else
            {
                lblReceta3.Text = "Opción 3: No disponible";
                btnVer3.Enabled = false;
            }
        }

        private void LimpiarRecetas()
        {
            lblReceta1.Text = "Opción 1: ...";
            lblReceta2.Text = "Opción 2: ...";
            lblReceta3.Text = "Opción 3: ...";
            btnVer1.Enabled = false;
            btnVer2.Enabled = false;
            btnVer3.Enabled = false;
            recetasEncontradas.Clear();
        }

        private async void btnVer1_Click(object sender, EventArgs e)
        {
            await VerDetalleReceta(0);
        }

        private async void btnVer2_Click(object sender, EventArgs e)
        {
            await VerDetalleReceta(1);
        }

        private async void btnVer3_Click(object sender, EventArgs e)
        {
            await VerDetalleReceta(2);
        }

        private async Task VerDetalleReceta(int indice)
        {
            if (indice < recetasEncontradas.Count)
            {
                try
                {
                    string idReceta = recetasEncontradas[indice].idMeal;
                    RecetaCompleta detalle = await ServicioRecetas.ObtenerDetalleRecetaAsync(idReceta);

                    if (detalle != null)
                    {
                        FrmDetalle frmDetalle = new FrmDetalle(detalle);
                        frmDetalle.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
