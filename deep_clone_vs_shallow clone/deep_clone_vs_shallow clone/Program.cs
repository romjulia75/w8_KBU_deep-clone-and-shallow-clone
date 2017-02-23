using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deep_clone_vs_shallow_clone
{
    public class Address
    {
        public string _strret;
        public int _zip;
        public string _city;

        public Address(string street, int zip, string city)
        {
            this._strret = street;
            this._zip = zip;
            this._city = city;
        }
    }
        class Person
    {
        public Address _address;
        public DateTime _dob;
        public double _weight;
        
        public Person DClone()
        {
            Person person = (Person) this.MemberwiseClone();
            //person._address = new Address(_address._strret, _address._zip, _address._city);
            //person._dob = _dob;
            //person._weight = _weight;
            return person;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1._dob = DateTime.Now;
            p1._weight = 40;
            p1._address = new Address("Hyldevang 62", 7323, "Give");
            Person p2 = p1.DClone();
            Console.WriteLine(p1._address._strret);
            Console.WriteLine(p2._address._strret);
            Console.ReadLine();
        }
    }
}
