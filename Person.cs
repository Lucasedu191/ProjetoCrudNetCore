using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOnept02
{
    public class Person
    {
        public int Id { get; set; }

        public PersonName Name { get; set; } = new PersonName();

        public DateTime Birth { get; set; }

        public List<PersonDocument> Document { get; set; } = new List<PersonDocument>();

        public string Gender { get; set; }

        public PostalAddress PostalAddress { get; set; } = new PostalAddress();
    }
}
