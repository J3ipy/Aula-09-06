using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrianguloController : Controller
    {
       [HttpGet]

       public ActionResult<string> GetArea(double basev, double alturav)
       {
            Triangulo triangulo = new Triangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return (triangulo.CalcularArea(valores)).ToString();


       }


    }
}