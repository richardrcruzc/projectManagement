using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Domain
{
    public class Enums
    {

        public enum Projecttatus
        {

            Active = 1,
            Inactive = 2,
            Closed = 3,
            PostMorten=4

        }
        public enum TeamRole
        {

            Billing = 1,
            Manager = 2,
            Technichian = 3,
            CustomerCare = 4

        }
        public enum TeamStatus
        {

            Active = 1,
            Inactive = 2,
            Banned = 2

        }
        public enum PermissionAction
        {

            Add=1,
            Update=2,
            Delete=3

        }
        public enum PermissionType
        {

            Project = 1,
            Billing = 2,
            Budget = 3,
            Chat=4,
            Ticket=5,
            Task=6,
            Client=7,
            User=8,
            Invoice=9,
            TimeTracking=10,
            MessageCenter=11,
            Calender=12,



        }

        public enum CommunicationType
        {

            PersonalEmail = 1,
            WorkEmail = 2,
            PersonalPhone = 3,
            CellPhone = 4,
            WorkPhone = 5,
            Twitter = 6,
            FaceBook = 7,
            LinkedIn = 7,
            Instagram=8,
            Skype=9


        }

        public enum Gender
        {
            Boy = 1,
            Girl = 2
        }

        public enum PersonStatus
        {
            Active = 1,
            Inactive = 2,
            Banned = 2
        }
        public enum PersonType
        {
            Customer = 1,
            Contact = 2,
            Prospect = 3,
            ContactBilling = 4,
            ContactAccountPayable = 5,
            Manager = 6,
            Cleark = 7,
            User =8,
            Team =9,
        }

        public enum AddressType
        {
            Billing=1,
            Contact=2,
            Delivery=3,
            Personal=4

        }

        public enum CustomerType
        {
            Individual = 1,
            Company = 2,

        }
        public enum CustomerStatus
        {
            Active = 1,
            Inactive = 2,
            Canceled = 2

        }
    }
}
