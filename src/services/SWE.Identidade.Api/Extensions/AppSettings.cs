using System.Reflection.Metadata.Ecma335;

namespace SWE.Identidade.Api.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpireHour { get; set; }
        public string Emissor { get; set; }
        public string ValidIn { get; set; }
    }
}
