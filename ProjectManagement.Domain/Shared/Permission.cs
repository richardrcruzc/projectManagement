using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Shared
{
    public class Permission: States.PermissionsState
    {
        public static Permission Create(Person person, PermissionAction action, PermissionType pType, int order)
        {
            var obj = new Permission
            {
                PersonId = person.Id,
                PermissionAction =action,
                PermissionType =pType,
                Order = order
            };
            return obj;
        }
        public void Update(string id, Person person, PermissionAction action, PermissionType pType, int order)
        {
            Id = id;
            PersonId = person.Id;
            PermissionAction = action;
            PermissionType = pType;
            Order = order;
        }
        public PermissionAction PermissionAction { get; private set; }
        public PermissionType PermissionType { get; private set; }
        public int Order { get; private set; }
    }
}