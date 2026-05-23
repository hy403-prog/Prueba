using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await ConsultarDatosPais();
        }
        private async Task ConsultarDatosPais()
        {
            string paisBuscado=txtNombre.Text.Trim();
            if(string.IsNullOrEmpty(paisBuscado))
            {
                MessageBox.Show("Ingrese el nombre de un pais");
                return;
            }
            string url = "https://restcountries.com/v3.1/name/" + paisBuscado;
            using (HttpClient cliente = new HttpClient())
            {
                HttpResponseMessage respuesta = await cliente.GetAsync(url);
                string json = await respuesta.Content.ReadAsStringAsync();
                if (respuesta.IsSuccessStatusCode) 
                {
                    List<Pais> listaPaises = JsonConvert.DeserializeObject<List<Pais>>(json);
                    Pais datosPais = listaPaises[0];
                    lblNombre.Text = datosPais.name.common;
                    lblNombreOficial.Text = datosPais.name.official;
                    lblRegion.Text = datosPais.region;
                    lblPoblacion.Text = datosPais.population.ToString();

                }
                
            }
        }
    }
}
