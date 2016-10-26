using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Person
    {
      

        public Person() { }

        public Person(String address,String id,String name,int zipcode) {
            this.Address = address;
            this.Name = name;
            this.Id = id;
            this.ZipCode = zipcode;

        }

    }
}
