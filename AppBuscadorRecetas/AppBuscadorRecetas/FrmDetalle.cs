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
    public partial class FrmDetalle : Form
    {
        private RecetaCompleta receta;

        public FrmDetalle(RecetaCompleta receta)
        {
            InitializeComponent();
            this.receta = receta;
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                // Traducir nombre de la receta
                string nombreTraducido = await Traductor.InglesAEspanolAsync(receta.strMeal);
                this.Text = nombreTraducido;
                lblNombreReceta.Text = nombreTraducido;

                // Mostrar categoría y área (si existen)
                lblCategoriaArea.Text = $"Categoría: {receta.strCategory} | Región: {receta.strArea}";

                // Cargar instrucciones
                await CargarInstrucciones();

                // Cargar ingredientes
                await CargarIngredientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task CargarInstrucciones()
        {
            string instrucciones = receta.strInstructions;
            if (!string.IsNullOrEmpty(instrucciones))
            {
                // Traducir instrucciones
                string instruccionesTraducidas = await Traductor.InglesAEspanolAsync(instrucciones);
                rtxtInstrucciones.Text = instruccionesTraducidas;
            }
        }
        
        private async Task CargarIngredientes()
        {
            lvIngredientes.Items.Clear();
            
            // Obtener todos los ingredientes y medidas
            List<string> ingredientes = new List<string>()
            {
                receta.strIngredient1, receta.strIngredient2, receta.strIngredient3,
                receta.strIngredient4, receta.strIngredient5, receta.strIngredient6,
                receta.strIngredient7, receta.strIngredient8, receta.strIngredient9,
                receta.strIngredient10, receta.strIngredient11, receta.strIngredient12,
                receta.strIngredient13, receta.strIngredient14, receta.strIngredient15,
                receta.strIngredient16, receta.strIngredient17, receta.strIngredient18,
                receta.strIngredient19, receta.strIngredient20
            };

            List<string> medidas = new List<string>()
            {
                receta.strMeasure1, receta.strMeasure2, receta.strMeasure3,
                receta.strMeasure4, receta.strMeasure5, receta.strMeasure6,
                receta.strMeasure7, receta.strMeasure8, receta.strMeasure9,
                receta.strMeasure10, receta.strMeasure11, receta.strMeasure12,
                receta.strMeasure13, receta.strMeasure14, receta.strMeasure15,
                receta.strMeasure16, receta.strMeasure17, receta.strMeasure18,
                receta.strMeasure19, receta.strMeasure20
            };

            for (int i = 0; i < ingredientes.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(ingredientes[i]))
                {
                    string ingredienteTraducido = await Traductor.InglesAEspanolAsync(ingredientes[i]);
                    string medidaTraducida = !string.IsNullOrWhiteSpace(medidas[i]) 
                        ? await Traductor.InglesAEspanolAsync(medidas[i]) 
                        : "";

                    ListViewItem item = new ListViewItem(new[] 
                    { 
                        ingredienteTraducido, 
                        medidaTraducida 
                    });
                    lvIngredientes.Items.Add(item);
                }
            }
        }
    }
}
