using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVUNI_RESTULL_DOTNET_CLIESC.Model
{
    public class ConversionModel
    {
        public double valor { get; set; }
        public string fromUnit { get; set; }
        public string toUnit { get; set; }
        public double resultado { get; set; }
    }

    public class ConversionRequest
    {
        public double Value { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
    }
}
