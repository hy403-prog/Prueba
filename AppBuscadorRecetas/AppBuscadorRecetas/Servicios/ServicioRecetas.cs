using AppBuscadorRecetas.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppBuscadorRecetas.Servicios
{
    public class ServicioRecetas
    {
        private const string URL_BASE = "https://www.themealdb.com/api/json/v1/1/";

        public static async Task<List<Receta>> BuscarPorIngredienteAsync(string ingrediente)
        {
            try
            {
                // Traducir de español a inglés
                string ingredienteIngles = Traductor.EspanolAIngles(ingrediente);
                
                string url = URL_BASE + "filter.php?i=" + ingredienteIngles;
                
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.Timeout = TimeSpan.FromSeconds(10);
                    HttpResponseMessage respuesta = await cliente.GetAsync(url);
                    string json = await respuesta.Content.ReadAsStringAsync();

                    if (respuesta.IsSuccessStatusCode)
                    {
                        Ingrediente resultado = JsonConvert.DeserializeObject<Ingrediente>(json);
                        
                        if (resultado != null && resultado.meals != null && resultado.meals.Count > 0)
                        {
                            return resultado.meals;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar recetas: " + ex.Message);
            }

            return new List<Receta>();
        }

        public static async Task<RecetaCompleta> ObtenerDetalleRecetaAsync(string idMeal)
        {
            try
            {
                string url = URL_BASE + "lookup.php?i=" + idMeal;
                
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.Timeout = TimeSpan.FromSeconds(10);
                    HttpResponseMessage respuesta = await cliente.GetAsync(url);
                    string json = await respuesta.Content.ReadAsStringAsync();

                    if (respuesta.IsSuccessStatusCode)
                    {
                        DetalleReceta resultado = JsonConvert.DeserializeObject<DetalleReceta>(json);
                        
                        if (resultado != null && resultado.meals != null && resultado.meals.Count > 0)
                        {
                            return resultado.meals[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle: " + ex.Message);
            }

            return null;
        }
    }
}
