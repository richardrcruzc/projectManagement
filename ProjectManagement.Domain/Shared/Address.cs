
using System;
using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Shared
{
    public sealed class Address : States.AddressState, IEquatable<Address>
    {
        public static Address Create(AddressType at , string street1, string street2, string city, string zip,StateOrProvince stateOrProvince, Country country)
        {

            var address = new Address {
                AddressType = at,
                Street1 = street1,
                Street2 = street2,
                City = city,
                Zip = zip,
                CountryCode = country.Code,
                StateOrProvinceCode = stateOrProvince.Code
            };
            return address;
        }
        public void Update(AddressType at, string street1, string street2, string number, string city, string zip, StateOrProvince stateOrProvince, Country country)
        {
            AddressType = at;
            Street1 = street1;
            Street2 = street2;
            City = city;
            Zip = zip;
            CountryCode = country.Code;
            StateOrProvinceCode = stateOrProvince.Code;

        }

        //public bool Equals(Address other)
        //{
        //    throw new NotImplementedException();
        //}
        public bool Equals(Address other) => other != null
            && Street1 == other.Street1
            && Street2 == other.Street2
            && City == other.City
            && Zip == other.Zip
            && CountryCode == other.CountryCode
            && StateOrProvinceCode == other.StateOrProvinceCode;

        #region Added to please the O/RM

        /// <summary>
        /// Used by the O/RM to materialize objects
        /// </summary>
        private Address()
        {
        }

        #endregion
        public string Street1
        {
            get { return this.Street1; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The Street1 must be provided.");
                AssertionConcern.AssertArgumentLength(value, 200, "The Street1 must be 200 characters or less.");
                this.Street1 = value;
            }
        }

        public string Street2 { get; private set; }
        public string City
        {
            get { return this.City; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The City must be provided.");
                AssertionConcern.AssertArgumentLength(value, 100, "The City must be 200 characters or less.");
                this.City = value;
            }
        }
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
        public StateOrProvince StateOrProvince { get; private set; }
        public Country Country { get; private set; }
        public AddressType AddressType { get; private set; }


    }
}
