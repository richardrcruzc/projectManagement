using ProjectManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Shared
{
    public class Person : States.PersonState
    {
        public static Person CreateNew(Gender gender, string firstName, string lastName)
        {

            AssertionConcern.AssertArgumentNotNull(gender, "The gender must be provided.");

            var person = new Person
            {

                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                PersonStatus = PersonStatus.Active,

            };

            return person;
        }
        public void Update(Gender gender, string firstname, string lastname )
        {

            AssertionConcern.AssertArgumentNotNull(gender, "The gender must be provided.");

            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            PersonStatus = PersonStatus.Active;
        }

        public Person AddAddresses (ICollection<Address> items )
        {
            foreach (var item in items)
            {
                Address address = item;
                if (item.Id != null)
                {
                    var existing = (from a in Addresses where a.Id == item.Id select a).SingleOrDefault();
                    if (existing != null)
                        existing = item;
                    else
                        Addresses.Add(item);
                }


            }
            return this;


        }
        public Person AddImages(ICollection<Image> items)
        {
            foreach (var item in items)
            {
                Image image = item;
                if (item.Id != null)
                {
                    var existing = (from a in Images where a.Id == item.Id select a).SingleOrDefault();
                    if (existing != null)
                        existing = item;
                    else
                        Images.Add(item);
                }


            }
            return this;


        }
        public Person AddCommunication(ICollection<Communication> items)
        {
            foreach (var item in items)
            {
                Communication communication = item;
                if (item.Id != null)
                {
                    var existing = (from a in Communications where a.Id == item.Id select a).SingleOrDefault();
                    if (existing != null)
                        existing = item;
                    else
                        Communications.Add(item);
                }


            }
            return this;


        }

        #region Added to please the O/RM

        /// <summary>
        /// Used by the O/RM to materialize objects
        /// </summary>
        protected Person()
        {

        }

        #endregion

        /// <summary>
        /// Password hash
        /// </summary>
        public string PasswordHash { get; private set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName {
            get { return this.FirstName; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The First Name must be provided.");
                AssertionConcern.AssertArgumentLength(value, 100, "The First Name must be 100 characters or less.");
                this.FirstName = value;
            }
        }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName
        {
            get { return this.LastName; }
            private set
            {
                AssertionConcern.AssertArgumentNotEmpty(value, "The LastName must be provided.");
                AssertionConcern.AssertArgumentLength(value, 100, "The LastName must be 100 characters or less.");
                this.LastName = value;
            }
        }
        /// <summary>
        /// Email address
        /// </summary>
        public ICollection<Communication> Communications { get; private set; }

        /// <summary>
        /// Gender: either Male or Female
        /// </summary>
        public Gender Gender { get; private set; }

        public PersonStatus PersonStatus { get; private set; }
        public PersonType PersonType { get; private set; }

        /// <summary>
        /// URL of the avatar
        /// </summary>
        public ICollection<Image> Images { get; private set; }

        /// <summary>
        /// Postal address of the person
        /// At the very minimum, you might want to use an Address object.
        /// </summary>
        public ICollection<Address> Addresses { get; private set; }


        /// <summary>
        /// Set the password hash for the person
        /// </summary>
        /// <param name="hash">Hash of a password to save</param>
        /// <returns>this object</returns>
        public Person SetPasswordHash(string hash)
        {
            PasswordHash = hash;
            return this;
        }


        /// <summary>
        /// Title for the person (Mr, Mrs, etc)
        /// </summary>
        /// <returns>string</returns>
        public String GetTitle()
        {
            switch (Gender)
            {
                case Gender.Girl:
                    return "Mrs";
                case Gender.Boy:
                    return "Mr.";
                default:
                    return "";
            }
        }



        public override string ToString()
        {
            var title = GetTitle();
            return String.Format("{0} {1} {2}", title, FirstName, LastName);
        }


    }

}
