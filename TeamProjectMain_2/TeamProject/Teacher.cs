using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    internal class Teacher : Person
    {
        public decimal salary;
        public String degree;
        public String specialty;
        public int deptID;

        //Setters and Getters for Teacher attributes
        public String Degree { get; set; }

        public String Specialty { get; set; }

        public int DeptID { get; set; }

        public Decimal Salary { get; set; }

        public String Dean { get; set; }

        public Decimal getSalary() { return this.computePayRoll(); }



        //Constructors for Teacher class
        public Teacher()
        {
        }

        public string isDean()
        {

            for (int i =0; Department.DepartmentList.Count > i;i++)
            {

                //Checks if the teacher's department ID matches a department ID in the arrayList.
                if (Department.DepartmentList[i].ID == this.DeptID)
                {

                    //Checks if that department has a dean yet.
                    if (Department.DepartmentList[i].getDean() != null)
                    {

                        //Checks if the ID of the dean matches the teacher's ID.
                        if (Department.DepartmentList[i].getDean().ID == this.ID)
                        {

                            //Setting the isDean variable to "Yes".
                            return this.Dean = "Yes";

                        }

                    }
                    else
                    {
                        //Setting the isDean variable to "No".
                        return this.Dean = "";
                    }
                }
            }

      return this.Dean;
        }

        public Decimal computePayRoll()
        {

            //Checks if the degree of the teacher is "phd" and sets it to 112, then calculates the payRoll.
            if ("phd".Equals(Degree))
            {
                this.Salary = 112;

                return this.Salary * 2 * (76 + 100);
            }

            //Checks if the degree of the teacher is "master" and sets it to 112, then calculates the payRoll.
            if ("master".Equals(Degree))
            {
                this.Salary = 82;
                return this.Salary * 2 * (76+100);
            }

            //Checks if the degree of the teacher is "bachelor" and sets it to 112, then calculates the payRoll.
            if ("bachelor".Equals(Degree))
            {
                this.Salary = 42;
                return this.Salary * 2 *(76+100);
            }

            return this.Salary;

        }

        public Teacher(string degree2)
        {
            this.Degree = degree2;

        }

        public Teacher(int id1, String name1, int age1, String gender1, String degree1, String specialty1, Decimal salary1 ,int deptID1)
        {

            this.ID = id1;
            this.Name = name1;
            this.Age = age1;
            this.Gender = gender1;
            this.Degree = degree1;
            this.Specialty = specialty1;
            this.Salary = salary1;
            this.DeptID = deptID1;
        }
        public String toString()
        {
            return (this.ID + "," + this.Name + "," + this.Age + "," + this.Gender + "," + this.Degree + "," + this.Specialty + "," + this.DeptID);

        }
    }
}
