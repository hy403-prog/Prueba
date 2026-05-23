using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppBuscadorRecetas.Servicios
{
    public class Traductor
    {
        private static Dictionary<string, string> diccionarioEsIngles = new Dictionary<string, string>
        {
            // Carnes
            { "pollo", "chicken" },
            { "carne de res", "beef" },
            { "carne", "beef" },
            { "cerdo", "pork" },
            { "pescado", "fish" },
            { "pavo", "turkey" },
            { "jamón", "ham" },
            { "cordero", "lamb" },
            { "camarones", "shrimp" },
            { "salmón", "salmon" },
            { "atún", "tuna" },
            
            // Verduras
            { "papa", "potato" },
            { "papas", "potatoes" },
            { "ajo", "garlic" },
            { "cebolla", "onion" },
            { "cebollas", "onions" },
            { "tomate", "tomato" },
            { "tomates", "tomatoes" },
            { "lechuga", "lettuce" },
            { "brócoli", "broccoli" },
            { "zanahoria", "carrot" },
            { "zanahorias", "carrots" },
            { "pimiento", "bell pepper" },
            { "pimientos", "bell peppers" },
            { "champiñón", "mushroom" },
            { "champiñones", "mushrooms" },
            { "pepino", "cucumber" },
            { "espinaca", "spinach" },
            { "repollo", "cabbage" },
            
            // Ingredientes básicos
            { "arroz", "rice" },
            { "pan", "bread" },
            { "queso", "cheese" },
            { "huevo", "egg" },
            { "huevos", "eggs" },
            { "leche", "milk" },
            { "chocolate", "chocolate" },
            { "mantequilla", "butter" },
            { "aceite", "oil" },
            { "sal", "salt" },
            { "azúcar", "sugar" },
            { "harina", "flour" },
            
            // Frutas
            { "manzana", "apple" },
            { "manzanas", "apples" },
            { "plátano", "banana" },
            { "naranja", "orange" },
            { "limón", "lemon" },
            { "lima", "lime" },
            { "fresa", "strawberry" },
            
            // Platos
            { "sopa", "soup" },
            { "ensalada", "salad" },
            { "pizza", "pizza" },
            { "pasta", "pasta" },
            { "fideos", "noodles" },
            { "salsa", "sauce" },
            { "curry", "curry" }
        };

        private static Dictionary<string, string> diccionarioInglesEspanol = new Dictionary<string, string>
        {
            // Carnes
            { "chicken", "pollo" },
            { "beef", "carne de res" },
            { "pork", "cerdo" },
            { "fish", "pescado" },
            { "turkey", "pavo" },
            { "ham", "jamón" },
            { "lamb", "cordero" },
            { "shrimp", "camarones" },
            { "salmon", "salmón" },
            { "tuna", "atún" },
            
            // Métodos de cocina
            { "stew", "estofado" },
            { "baked", "horneado" },
            { "fried", "frito" },
            { "grilled", "a la parrilla" },
            { "roasted", "asado" },
            { "boiled", "hervido" },
            { "steamed", "al vapor" },
            { "bake", "hornear" },
            { "fry", "freír" },
            { "grill", "asar" },
            { "roast", "asar al horno" },
            { "boil", "hervir" },
            { "steam", "cocinar al vapor" },
            
            // Verduras
            { "potato", "papa" },
            { "potatoes", "papas" },
            { "garlic", "ajo" },
            { "onion", "cebolla" },
            { "onions", "cebollas" },
            { "tomato", "tomate" },
            { "tomatoes", "tomates" },
            { "lettuce", "lechuga" },
            { "broccoli", "brócoli" },
            { "carrot", "zanahoria" },
            { "carrots", "zanahorias" },
            { "pepper", "pimiento" },
            { "peppers", "pimientos" },
            { "mushroom", "champiñón" },
            { "mushrooms", "champiñones" },
            { "cucumber", "pepino" },
            { "spinach", "espinaca" },
            { "cabbage", "repollo" },
            
            // Ingredientes
            { "rice", "arroz" },
            { "bread", "pan" },
            { "cheese", "queso" },
            { "egg", "huevo" },
            { "eggs", "huevos" },
            { "milk", "leche" },
            { "chocolate", "chocolate" },
            { "butter", "mantequilla" },
            { "oil", "aceite" },
            { "salt", "sal" },
            { "sugar", "azúcar" },
            { "flour", "harina" },
            { "sauce", "salsa" },
            { "curry", "curry" },
            { "chorizo", "chorizo" },
            { "hot", "caliente" },
            { "brown", "marrón" },
            { "pot", "olla" },
            { "spicy", "picante" },
            
            // Frutas
            { "apple", "manzana" },
            { "apples", "manzanas" },
            { "banana", "plátano" },
            { "orange", "naranja" },
            { "lemon", "limón" },
            { "lime", "lima" },
            { "strawberry", "fresa" },
            
            // Platos
            { "soup", "sopa" },
            { "salad", "ensalada" },
            { "pizza", "pizza" },
            { "pasta", "pasta" },
            { "noodles", "fideos" },
            { "and", "y" },
            { "with", "con" },
            { "in", "en" },
            { "to", "para" }
        };

        public static string EspanolAIngles(string texto)
        {
            string textoLower = texto.ToLower().Trim();
            
            if (diccionarioEsIngles.ContainsKey(textoLower))
            {
                return diccionarioEsIngles[textoLower];
            }
            
            return textoLower;
        }

        public static async Task<string> InglesAEspanolAsync(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            try
            {
                string textoLower = texto.ToLower();
                string resultado = TraducirPorPalabras(textoLower);
                return resultado;
            }
            catch
            {
                return texto;
            }
        }

        private static string TraducirPorPalabras(string texto)
        {
            string[] palabras = texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palabrasTraducidas = new List<string>();

            foreach (string palabra in palabras)
            {
                string palabraLower = palabra.ToLower();
                string palabraSinPuntuacion = System.Text.RegularExpressions.Regex.Replace(palabraLower, @"[^a-z0-9\s]", "");
                
                if (diccionarioInglesEspanol.ContainsKey(palabraSinPuntuacion))
                {
                    palabrasTraducidas.Add(diccionarioInglesEspanol[palabraSinPuntuacion]);
                }
                else
                {
                    palabrasTraducidas.Add(palabra);
                }
            }

            return string.Join(" ", palabrasTraducidas);
        }
    }
}
