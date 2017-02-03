using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Domain.Shared.States
{
    public class PermissionsState :   Identity
    {
        public string PersonId { get; set; }
    }
}
