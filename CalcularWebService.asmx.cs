using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculodeAreas
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod(Description = "Metodo para calcular el area del cuadrado")]
        public int CalcularAreaCuadrado(int lado)
        {
            var area = lado * lado;
            return area;
        }
        [WebMethod(Description = "Metodo para calcular el area del Triangulo")]
        public int CalcularAreaTriangulo(int basetri, int altura)
        {

            return (basetri * altura) / 2;
        }
        [WebMethod(Description = "Metodo para calcular el area del Circulo")]
        public double CalcularAreaCirculo(double radio)
        {

            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
