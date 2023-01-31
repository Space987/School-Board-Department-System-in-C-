using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    internal class Staff : Person
    {

        //Setters and Getters for Staff attributes

        public int DeptChoice { get; set; }

        public bool Bonus { get; set; }

        public int WorkLoad { get; set; }
        public string Duty { get; set; }

        public Decimal Salary { get; set; }

        public Decimal getSalary() { return computePayRoll(); }


        //Constructors for Staff class
        public Staff()
        {
        }

        public Staff(int workload1)
        {
            this.WorkLoad = workload1;

        }

        public Staff(int id1, String name1, int age1, String gender1, String duty1, int workload1, Decimal salary1, int deptChoice1)
        {

            this.ID = id1;
            this.Name = name1;
            this.Age = age1;
            this.Gender = gender1;
            this.Duty = duty1;
            this.WorkLoad = workload1;
            this.Salary = salary1;
            this.DeptChoice = deptChoice1;
        }



        public Decimal computePayRoll()
        {

            //checks if the workload is under or equal to 36 and calculates salary
            if (this.WorkLoad <= 36)
            {
                this.Salary = (this.WorkLoad + 2) * 32 * 6;
            }
            else {

                this.Bonus = true;
                this.Salary = (this.WorkLoad + 2) * (32 * 6) + 1000;
                

            }

            return this.Salary;

        }

        public String toString()
        {
            return (this.ID + "," + this.Name + "," + this.Age + "," + this.Gender + "," + this.Duty + "," + this.WorkLoad + "," + this.DeptChoice);

        }
    }
}


