using System;



namespace ConsoleApp1
{
    class Program
    {
        public int YearsToDays(int birthYear, int currentYear)
        {
            const int daysInYear = 365;
            int totalDaysSinceBirth;
            int totalYearsSinceBirth;

            totalYearsSinceBirth = currentYear - birthYear;

            totalDaysSinceBirth = totalYearsSinceBirth * daysInYear;
           
            return totalDaysSinceBirth;
        }

        public int Age(int birthYear, int currentYear)
        {
            int userAge;

            userAge = currentYear - birthYear;

            return userAge;
        }

        public int DaysToHours(int totalDays, int daysSinceBirth)
        {
            const int hoursInDay = 24;
            int totalHours;

            totalHours = hoursInDay * daysSinceBirth;

            return totalHours;
      
        }

      
        static void Main(string[] args)
        {
            int userInputBirthYear;
            int userInputCurrentYear;
           

            Program ob = new Program();

            
            Console.WriteLine("Enter your birthyear:");
            userInputBirthYear = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter current year:");
            userInputCurrentYear = Convert.ToInt32(Console.ReadLine());
            int daysSinceBirth = ob.YearsToDays(userInputBirthYear, userInputCurrentYear);
            int userAge = ob.Age(userInputBirthYear, userInputCurrentYear);
            int hoursSinceBirth = ob.DaysToHours(daysSinceBirth, daysSinceBirth);

            Console.WriteLine("The total days since birth is " + daysSinceBirth);

            Console.WriteLine("The total hours since birth is " + hoursSinceBirth);
         
            Console.WriteLine("Your age is " + userAge);


         

           
        }

       

    }
}
