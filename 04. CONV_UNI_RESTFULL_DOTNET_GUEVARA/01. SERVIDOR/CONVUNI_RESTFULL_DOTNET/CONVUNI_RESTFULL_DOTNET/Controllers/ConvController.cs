using CONVUNI_RESTFULL_DOTNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CONVUNI_RESTFULL_DOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConvController : ControllerBase
    {
        [HttpPost]
        public ActionResult<ConvModelo> Convertir([FromBody] ConversionRequest request)
        {
            double valueInPascal = 0;
            double convertedValue = 0;

            switch (request.FromUnit.ToLower())
            {
                case "pa":
                    valueInPascal = request.Value;
                    break;
                case "bar":
                    valueInPascal = request.Value * 100000;
                    break;
                case "atm":
                    valueInPascal = request.Value * 101325;
                    break;
                case "psi":
                    valueInPascal = request.Value * 6894.76;
                    break;
                case "mmhg":
                    valueInPascal = request.Value * 133.322;
                    break;
                default:
                    return BadRequest("Unrecognized unit");
            }

            switch (request.ToUnit.ToLower())
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
                    return BadRequest("Unrecognized unit");
            }

            ConvModelo convModelo = new ConvModelo
            {
                valor = request.Value,
                fromUnit = request.FromUnit,
                toUnit = request.ToUnit,
                resultado = convertedValue
            };

            return Ok(convModelo);
        }
    }
}
