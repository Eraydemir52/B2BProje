using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Core.JwtService
{
    public interface IJwtSettingsService
    {
        JwtSettings GetJwtSettings();
    }
}
