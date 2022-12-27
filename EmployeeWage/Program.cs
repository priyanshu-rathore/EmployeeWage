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

        public void PartTime()//UC3
        {
            int partTimeWage = 0;
            int dailyWage = DailyEmpWage();

            if (dailyWage > 0)
            {
                partTimeWage = dailyWage / 2;
                System.Console.WriteLine($"Part time Employee is present and his wage is {partTimeWage}");
            }
            else
            {
                System.Console.WriteLine(
                    "Part time Employee is absent and his wage is 0"
                );
            }


        }

        public void switchCase()
        {
            System.Console.WriteLine("1). Check Employee is Present or Absent");
            System.Console.WriteLine("2). Calculate Daily Employee Wage");
            System.Console.WriteLine("3). Add Part Time Employee & Wage");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int attendance = EmpAttendance();
                    if (attendance == 1)
                    {
                        System.Console.WriteLine("Employee is Present");
                    }
                    else
                    {
                        System.Console.WriteLine("Employee is Absent");
                    }
                    break;
                case 2:
                    int wage = DailyEmpWage();

                    if (wage > 0)
                    {
                        System.Console.WriteLine("Employee is present and his daily wage is {0}", wage);

                    }
                    else
                    {
                        System.Console.WriteLine("Employee is absent and his daily wage is 0");
                    }


                    break;
                case 3:
                    PartTime();
                    break;
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Employee wage computation program on master branch");
            EmpWage employee = new EmpWage();

            System.Console.WriteLine("");

            employee.switchCase();


        }
    }
}