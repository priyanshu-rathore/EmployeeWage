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

        public int DailyEmpWage()//UC2
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int dailyWage = wagePerHour * fullDayHour;

            int attendance = EmpAttendance();

            if (attendance == 1)
            {
                return dailyWage;
            }
            else
            {
                dailyWage = 0;
                return dailyWage;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Employee wage computation program on master branch");
            EmpWage employee = new EmpWage();

            int wage = employee.DailyEmpWage();

            if (wage > 0)
            {
                System.Console.WriteLine("Employee is present and his daily wage is {0}", wage);

            }
            else
            {
                System.Console.WriteLine("Employee is absent and his daily wage is 0");
            }
        }
    }
}