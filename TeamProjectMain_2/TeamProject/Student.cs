using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Student : Person
    {

        public String course;
        public int semester;
        public int deptChoice;

        //Setters and Getters for Student attributes

        public int DeptChoice { get; set; }

        public int Semester { get; set; }

        public String Course { get; set; }



        //Constructors for Student class
        public Student()
        {
        }

        public Student(int id1, String name1, int age1, String gender1, String course1, int semester1, int deptChoice1)
        {

            this.ID = id1;
            this.Name = name1;
            this.Age = age1;
            this.Gender = gender1;
            this.Course = course1;
            this.Semester = semester1;
            this.DeptChoice = deptChoice1;
        }


        public String toString()
        {
            return (this.ID + "," + this.Name + "," + this.Age + "," + this.Gender + "," + this.Course + "," + this.Semester + "," + this.DeptChoice);

        }
    }
}