﻿using System;
using System.Collections.Generic;

namespace Actividad2_OGS_MODULO2.Models
{
    public partial class OrderDetailsExtended
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
    }
}