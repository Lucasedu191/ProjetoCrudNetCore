using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOnept02
{
    public class PersonName
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class PersonDocument
    {
        public string Type { get; set; }
        public string Value { get; set; }

    }

    public class PostalAddress
    {
        public string AddressCountry { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostalCode { get; set; }
    }

}
