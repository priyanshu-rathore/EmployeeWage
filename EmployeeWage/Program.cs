using System;

namespace EmployeeWage
{

    class EmpWage
    {

        public int EmpAttendance()//UC1
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);
            int PRESENT = 1;

            if (attendance == PRESENT)
            {
                return 1;
            }
            else

            {
                return 0;
            }


        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Employee wage computation program on master branch");
            EmpWage employee = new EmpWage();

            int Employee = employee.EmpAttendance();

            if(Employee == 1){
                System.Console.WriteLine("Employee is Present");
            }else{
                System.Console.WriteLine("Employee is Absent");
            }
        }
    }
}