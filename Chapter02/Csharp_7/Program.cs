using System;

namespace Csharp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncomment the next two lines and comment out other lines in the Main method to run the code
            // string firstName, lastName;
            // GetNames(out firstName, out lastName);


            //uncomment the next line and comment out other lines in the Main method to run the code
            //GetNames(out string firstName, out string lastName);


            //uncomment the next line and comment out other lines in the Main method to run the code
            // GetNames(out var firstName, out var lastName);


            void GetNames(out string firstName, out string lastName)
            {
                firstName = "John";
                lastName = "Doe";
            }

            string dayOfWeek = "Sunday";
            ref string day = ref dayOfWeek;
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}");
            day = "Monday";
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}");
            dayOfWeek = "Tuesday";
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}");

            var longDigit = 2_300_400_500_78;
            Console.WriteLine(longDigit);

            var binaryValue = 0b11101011;
            Console.WriteLine(binaryValue);

            Console.ReadLine();

        }

        public ref string GetFifthDayOfWeek()
        {
            string[] daysOfWeek = new string[7] {"Monday", "Tuesday", "Wednesday",
"Thursday", "Friday", "Saturday", "Sunday"};
            return ref daysOfWeek[4];
        }

        private static void GetNames(out string firstName, out string lastName)
        {
            firstName = "John";
            lastName = "Doe";
        }

        private (string, string) GetNames()
        {
            (string firstName, string lastName) names = ("John", "Doe");
            return names;
        }

        //uncomment the lines 67 to 73 and comment out lines 76 to 100 to run the code
        //public void ProcessLoan(Loan loan)
        //{
        //    if (loan is var carLoan)
        //    {
        //        // do something
        //    }
        //}


        //uncomment the lines 76 to 83 and comment out lines  67 to 73 and 87 to 100 to run the code
        //public void ProcessLoan(Loan loan)
        //{
        //    if (loan is null)
        //    {
        //        // do something
        //    }
        //}


        //uncomment the lines 67 to 83 and comment out lines 76 to 100 to run the code
        //public void ProcessLoan(Loan loan)
        //{
        //    switch (loan)
        //    {
        //        case CarLoan carLoan:
        //            // do something
        //            break;
        //        case HouseLoan houseLoan when (houseLoan.IsElligible == true):
        //            //do something
        //            break;
        //        case null:
        //            //throw some custom exception
        //            break;
        //        default:
        //            // do something
        //    }
        //}
    }
}
