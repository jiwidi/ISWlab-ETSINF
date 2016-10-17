using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Person
    {
        String address;
        String id;
        String name;
        int zipcode;

        public Person() { }

        public Person(String address,String id,String name,int zipcode) {
            this.address = address;
            this.name = name;
            this.id = id;
            this.zipcode = zipcode;

        }

    }
}
