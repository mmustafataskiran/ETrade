﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class Cities : BaseDescreption
    {
        public List<Counties> Counties { get; set; }
    }
}
