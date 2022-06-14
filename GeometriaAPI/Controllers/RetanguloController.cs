using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetanguloController : Controller
    {
       [HttpGet]

       public ActionResult<string> GetArea(double basev, double alturav)
       {
            Retangulo retangulo = new Retangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return (retangulo.CalcularArea(valores)).ToString();


       }


    }
}