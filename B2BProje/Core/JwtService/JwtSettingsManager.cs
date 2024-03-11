using B2BProje.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Core.JwtService
{
    public class JwtSettingsManager : IJwtSettingsService
    {
        IConfiguration _configuration;
        public JwtSettingsManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public JwtSettings GetJwtSettings()
        {
            var jwtSettings = new JwtSettings();
            _configuration.GetSection("Jwt").Bind(jwtSettings);
            return jwtSettings;
        }
    }
}
