using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrapezioController : Controller
    {
       [HttpGet]

       public ActionResult<string> GetArea(double baseMaior, double baseMenor, double alturav)
       {
            Trapezio trapezio = new Trapezio();

            string[] valores = {baseMaior.ToString(), baseMenor.ToString(), alturav.ToString()};

            return (trapezio.CalcularArea(valores)).ToString();


       }


    }
}