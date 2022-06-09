namespace   GeometriaAPI.Models{


        public interface IGeometriaFormula
        {
            double [] CalcularArea(string [] m);
            double [] CalcularPerimetro(string []m);
        }

}