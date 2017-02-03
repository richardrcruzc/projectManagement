using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Domain.Shared
{
    public class StateOrProvince: States.StateOrProvinceState
    {
        public static StateOrProvince Create(string description, string code, int order)
        {
            var obj = new StateOrProvince {
                Description = description,
                Code= code,
                Order=order
            };
            return obj;

        }
        public void Update(string description, string code, int order)
        {

            Description = description;
            Code = code;
            Order = order;


        }
        public string Description
        {
            get { return this.Description; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The Description must be provided.");
                AssertionConcern.AssertArgumentLength(value, 10, "The Description must be 200 characters or less.");
                this.Description = value;
            }
        }
        public string Code
        {
            get { return this.Code; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The Code must be provided.");
                AssertionConcern.AssertArgumentLength(value, 10, "The Code must be 10 characters or less.");
                this.Code = value;
            }
        }
        public int Order { get; private set; }
    }
}
