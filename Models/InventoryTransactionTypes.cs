using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_5.Models
{
    public partial class InventoryTransactionTypes
    {
        public InventoryTransactionTypes()
        {
            InventoryTransactions = new HashSet<InventoryTransactions>();
        }

        public sbyte Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<InventoryTransactions> InventoryTransactions { get; set; }
    }
}
