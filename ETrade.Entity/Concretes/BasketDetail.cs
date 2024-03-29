﻿using ETrade.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class BasketDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public decimal Ratio { get; set; } 
        
        [ForeignKey("OrderId")]
        public BasketMaster BasketMaster { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

    }
}
