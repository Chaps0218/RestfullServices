namespace CONVUNI_RESTFULL_DOTNET.Models
{
    public class ConvModelo
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
