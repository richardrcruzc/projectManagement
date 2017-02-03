using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Domain.Shared
{
    public class Image : States.ImageState
    {
        public static Image CreateNew(string id, Person person, string url, bool byDefault)
        {

            AssertionConcern.AssertArgumentNotNull(person, "The Person must be provided.");
            AssertionConcern.AssertArgumentNotNull(url, "The Url like must be provided.");

            var obj = new Image { Id = id, PersonId = person.Id, Url = url, Default = byDefault };
            return obj;
        }

        protected Image()
        {
            Url = String.Empty;
        }


        public Person Person { get; private set; }
        public string Url { get; private set; }
        public int Order { get; private set; }
        public bool Default { get; private set; }
    }
}
