using ProjectManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Domain.Projects.States
{
    public class TeamMemberState : Identity
    {
        public string PersonId { get; set; }
        public string ProjectId { get; set; }
    }
}
