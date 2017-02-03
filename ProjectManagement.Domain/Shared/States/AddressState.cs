

namespace ProjectManagement.Domain.Shared.States
{
    public class AddressState : Identity
    {
        public string CountryCode { get; set; }
        public string StateOrProvinceCode { get; set; }
    }
}
