﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Api.Entity
{
    public class MsgException : Exception
    {
        public MsgException(string msg) : base(msg)
        {
        }
    }
}
