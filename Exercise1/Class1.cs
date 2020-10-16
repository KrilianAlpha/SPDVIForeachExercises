using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class PersonModel
    {
        public String firstname { get; set; }
        public String lastname { get; set; }
        public PersonModel(String firstname, String lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", firstname, lastname);
        }
    }
}
