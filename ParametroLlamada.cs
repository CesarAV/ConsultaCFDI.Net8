using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCFDI.Utils
{
    public class ParametroLlamada
    {
        public ParametroLlamada(string nombre, string descripcion, string? valor = null)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
        }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string? Valor { get; set; }


        public string QueryParam => $"{Nombre}={Valor}";

        public static string ToQueryString(List<ParametroLlamada> entradas)
        {
            // modified from annaka answer in https://stackoverflow.com/questions/829080/how-to-build-a-query-string-for-a-url-in-c
            var array = entradas.Select(pl => pl.QueryParam).ToArray();
            return "?" + string.Join("&", array);
        }

        public static string GetExpresionImpresa()
        {
            try
            {
                List<ParametroLlamada> entradas = new List<ParametroLlamada>()
            {
                { new ParametroLlamada("re", "RFC de emisor", "") },
                { new ParametroLlamada("rr", "RFC de receptor", "") },
                { new ParametroLlamada("tt", "total de factura", "") }, // ej: 27240.00
                { new ParametroLlamada("id", "UUID", "") }
            };

                // get required values
                foreach (ParametroLlamada pl in entradas)
                {
                    if (string.IsNullOrEmpty(pl.Valor))
                    {
                        Console.Write($"Capture por favor el {pl.Descripcion}: ");
                        pl.Valor = Console.ReadLine();
                    }
                }

                return ToQueryString(entradas);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }

            return string.Empty;
        }
    }
}
