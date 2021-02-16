﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_5.Models
{
    public partial class PurchaseOrderDetails
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool PostedToInventory { get; set; }
        public int? InventoryId { get; set; }

        public virtual InventoryTransactions Inventory { get; set; }
        public virtual Products Product { get; set; }
        public virtual PurchaseOrders PurchaseOrder { get; set; }
    }
}
