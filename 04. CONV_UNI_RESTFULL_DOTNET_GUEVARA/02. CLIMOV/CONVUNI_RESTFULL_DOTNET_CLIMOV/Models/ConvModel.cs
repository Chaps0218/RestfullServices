using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVUNI_RESTFULL_DOTNET_CLIMOV.Models
{
    public class ConvModel
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
