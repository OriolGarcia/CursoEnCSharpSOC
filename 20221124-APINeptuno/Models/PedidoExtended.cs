﻿using System;

namespace APINeptuno.Models
{
    public class PedidoExtended
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string ShipperName { get; set; }

        public decimal? Amount { get; set; }
        public decimal? Freight { get; set; }
    }
}
