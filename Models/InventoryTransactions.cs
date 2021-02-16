using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_5.Models
{
    public partial class InventoryTransactions
    {
        public InventoryTransactions()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetails>();
        }

        public int Id { get; set; }
        public sbyte TransactionType { get; set; }
        public DateTime? TransactionCreatedDate { get; set; }
        public DateTime? TransactionModifiedDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? CustomerOrderId { get; set; }
        public string Comments { get; set; }

        public virtual Orders CustomerOrder { get; set; }
        public virtual Products Product { get; set; }
        public virtual PurchaseOrders PurchaseOrder { get; set; }
        public virtual InventoryTransactionTypes TransactionTypeNavigation { get; set; }
        public virtual ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
    }
}
