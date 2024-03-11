using System;
using System.Security.Cryptography;
using System.Text;

namespace B2BProje.Core.Entities
{
    public class JwtSettings
    {
        public string Key { get; set; } = "your_256_bit_key_here";
        public string Issuer { get; set; } = "your_issuer_here";
        public string Audience { get; set; } = "your_audience_here";
        // Diğer JWT ile ilgili yapılandırma bilgileri...
    }

}
