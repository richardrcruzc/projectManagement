using ProjectManagement.Domain.Customers;
using ProjectManagement.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Projects
{
    public class Project : States.ProjectState
    {
        public Projecttatus ProjectStatus { get; private set; }
        public Customer Customer { get; private set; }

        public string Code { get; private set; }
        public string Description { get; private set; }
        public string ShortName { get; private set; }

        public ICollection<Address> Addresses { get; private set; }
        public ICollection<TeamMember> TeamMembers { get; private set; }


        public decimal PlannedBudget { get; private set; }
        public DateTime PlannedStartDate { get; private set; }
        public DateTime PlannedClosingDate { get; private set; }
        public decimal CurrentBudget { get; private set; }
        public DateTime CurrentStartDate { get; private set; }
        public DateTime CurrentClosingDate { get; private set; }

        public string Zip
        {
            get { return this.Zip; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The Zip must be provided.");
                AssertionConcern.AssertArgumentLength(value, 10, "The Zip must be 200 characters or less.");
                this.Zip = value;
            }
        }
    }
}
