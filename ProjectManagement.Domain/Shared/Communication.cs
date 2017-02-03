

using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Shared
{
    public class Communication : States.CommunicationState
    {
        public static Communication Create(Person person, string description, CommunicationType cType, int order)
        {
            var obj = new Communication
            {
                PersonId = person.Id,
                Description = description,
                CommunicationType = cType,
                Order = order
            };
            return obj;

        }
        public void Update(string id, Person person, string description, CommunicationType cType, int order)
        {
            PersonId = id;
            Description = description;
            CommunicationType = cType;
            Order = order;
        }

        public Person Person { get; private set; }
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
        public CommunicationType CommunicationType
        { get; private set; }
        public int Order { get; private set; }
    }
}
