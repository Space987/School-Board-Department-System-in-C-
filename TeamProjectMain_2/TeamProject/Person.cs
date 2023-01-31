using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public abstract class Person
    {
        public int id;
        public String name;
        public int age;
        public String gender;


        //Setters and Getters for Person attributes.

        public int ID { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }

        public String Gender { get; set; }



        //Constructor for Person class.
        public Person()
        {
            this.name = null;
            this.id = 0;
            this.gender = null;
            this.age = 0;
        }

    }
}