﻿using ETrade.DTO;
using ETrade.Entity.Concretes;

namespace ETrade.UI.Models
{
    public class BasketDetailModel
    {
        public List<ProductDTO> ProductsDTO { get; set; }
        public List<BasketDetailDTO> BasketDetailDTO { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public decimal Ratio { get; set; }
        public int UnitId { get; set; }
        //public List<BasketDetail>   { get; set; }
    }
  
}
