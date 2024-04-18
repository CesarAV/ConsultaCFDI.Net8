using SAT_Service;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Este proyecto se creó con los iguientes pasos:
//
// 1. Descargar el archivo de definición "" del sat

ConsultaCFDIServiceClient client = new ConsultaCFDIServiceClient();

string expresionImpresa = ConsultaCFDI.Utils.ParametroLlamada.GetExpresionImpresa();

// esta función la genera VS al importar la referencia a partir del archivo consultacfdiservice.wsdl
Acuse res = client.Consulta(expresionImpresa);

Console.WriteLine($"Estado: {res.Estado}");
Console.WriteLine($"Cancelable: {res.EsCancelable}");
if (!string.IsNullOrEmpty(res.EstatusCancelacion))
{
    Console.WriteLine($"Estado de cancelación: {res.EstatusCancelacion}");
}
Console.WriteLine($"Validación: {res.ValidacionEFOS}");
