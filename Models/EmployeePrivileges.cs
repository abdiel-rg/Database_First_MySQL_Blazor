using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_5.Models
{
    public partial class EmployeePrivileges
    {
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Privileges Privilege { get; set; }
    }
}
