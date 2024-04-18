using SAT_Service;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Este proyecto se completó siguiendo los pasos:
//
// 1. Descargar el archivo de definición "consultacfdiservice.wsdl" del sat
//    https://consultaqr.facturaelectronica.sat.gob.mx/consultacfdiservice.svc?wsdl
//
// 2. Agregar un servicio conectado al proyecto, siguiendo las instrucciones de Nedzad G en
//    https://stackoverflow.com/questions/1302525/how-to-use-a-wsdl
//        2.1. Menú Proyecto / Agregar referencia de servicio.
//             Debe estar seleccionado el proyecto en el explorador de soluciones, o dar click derecho en proyecto
//        2.2. Selecciona "WCF web service"
//        2.3. Seleccionar "consultacfdiservice.wsdl" en la captura de URI
//        2.4. Continuar con el wizard y selecciojnar las opciones deseadas,
//             en mi caso seleccioné "Generate operaciones sincrónicas"
//        2.5 Instanciar 'ConsultaCFDIServiceClient'
//        2.6 Formar los parámetros 'expresionImpresa' de consulta
//            (los parámetros rr, re, tt e id no son claros, pero está documentados en https://developers.sw.com.mx/knowledge-base/servicio-publico-de-consulta-estatus-cfdi-sat/#)
//        2.7 Llamar 'ConsultaCFDIServiceClient.Consulta' con los valores adecuados en 'expresionImpresa'
//        

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
