﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestASPNETUdemy.Model
{
    public class User
      
    {
        public long? Id { get; set; }
        public string Login { get; set; }
        public string AccessKey { get; set; }
    }
}