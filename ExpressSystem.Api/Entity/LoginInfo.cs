﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniformMSAPI.Entity
{
    public class LoginInfo
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string SiteId { get; set; }

    }
}
