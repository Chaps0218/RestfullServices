using Microsoft.AspNetCore.Mvc;
using CONVUNI_RESTFULL_DOTNET.ec.edu.monster.modelo;

namespace CONVUNI_RESTFULL_DOTNET.ec.edu.monster.controlador
{
    [ApiController]
    [Route("[controller]")]
    public class ConvController : Controller
    {
        [HttpPost]
        public ActionResult<ConvModelo> Convertir(double value, string fromUnit, string toUnit) {
            double valueInPascal = 0;
            double convertedValue = 0;
            switch (fromUnit.ToLower())
            {
                case "pa":
                    valueInPascal = value;
                    break;
                case "bar":
                    valueInPascal = value * 100000;
                    break;
                case "atm":
                    valueInPascal = value * 101325;
                    break;
                case "psi":
                    valueInPascal = value * 6894.76;
                    break;
                case "mmhg":
                    valueInPascal = value * 133.322;
                    break;
                default:
                    throw new Exception("Unrecognized unit");
            }
            switch (toUnit.ToLower())
            {
                case "pa":
                    convertedValue = valueInPascal;
                    break;
                case "bar":
                    convertedValue = valueInPascal / 100000;
                    break;
                case "atm":
                    convertedValue = valueInPascal / 101325;
                    break;
                case "psi":
                    convertedValue = valueInPascal / 6894.76;
                    break;
                case "mmhg":
                    convertedValue = valueInPascal / 133.322;
                    break;
                default:
                    throw new Exception("Unrecognized unit");
            }

            ConvModelo convModelo = new ConvModelo();
            convModelo.valor = value;
            convModelo.fromUnit = fromUnit;
            convModelo.toUnit = toUnit;
            convModelo.resultado = convertedValue;
            return convModelo;
        }
    }
}
