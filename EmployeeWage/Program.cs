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

        public void switchCase()//UC4
        {
            System.Console.WriteLine("1). Check Employee is Present or Absent");
            System.Console.WriteLine("2). Calculate Daily Employee Wage");
            System.Console.WriteLine("3). Add Part Time Employee & Wage");
            System.Console.WriteLine("4). Monthly Wages");
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
                case 4:
                    MonthlyWages();
                    break;
            }
        }

        public void MonthlyWages()//UC5
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1;

            Random random = new Random();

            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int employeeInput = random.Next(0, 3);
                switch (employeeInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage;
            }
            Console.WriteLine("Total wage for {0} days:{1}", (day - 1), totalWage);
        }

        public void CalculateWagestillMonth(){//UC6
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 80;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;

            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int employeeInput = random.Next(0, 3);
                switch (employeeInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage; 
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for {0} days:{1} and Hrs:{2}", (day - 1), totalWage, (totalHrs - empHrs));
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