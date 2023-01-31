using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    internal class Department
    {
        public static List<Student> StudentList = new List<Student>();
        public int id;
        public String description;
        public Teacher dean;

        //Creating ObservableArrayLists
        public static List<Teacher> TeacherList = new List<Teacher>();
        public static List<Staff> StaffList = new List<Staff>();
        public static List<Department> DepartmentList = new List<Department>();

        //Setters and Getters for Department attributes
        public int ID
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }

        public Teacher getDean()
        {

            return this.dean;
        }

        public void setDean(Teacher teach)
        {
            this.dean = teach;
        }

        //Constructors for Department class
        public Department()
        {
        }

        public Department(int i, String d)
        {
            this.ID = i;
            this.Description = d;

        }
        public String toString()
        {
            return (this.ID + "," + this.Description);

        }

    }
}
