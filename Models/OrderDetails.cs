﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_5.Models
{
    public partial class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public double Discount { get; set; }
        public int? StatusId { get; set; }
        public DateTime? DateAllocated { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? InventoryId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        public virtual OrderDetailsStatus Status { get; set; }
    }
}
