namespace Constructor010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Date Constructor Demo

            // Constructor: هو إعطاء قيم أولية للمتغيرات وقت إنشاء الـ Object
            Date d1 = new Date(29, 02, 1999); // Invalid (not leap year)
            Date d2 = new Date(29, 02, 2000); // Valid (leap year)

            Console.WriteLine(d1.GetDate()); // 01/01/0001
            Console.WriteLine(d2.GetDate()); // 29/02/2000

            #endregion

            #region Employee Constructor & Object Initializer Demo

            // Default constructor
            Employee e1 = new Employee();
            e1.FName = "Saif";
            e1.LName = "A.";

            // Object Initializer
            Employee e2 = new Employee
            {
                Id = 2,
                FName = "Ahmed",
                LName = "B."
            };

            // Constructor + Object Initializer
            Employee e3 = new Employee(1000)
            {
                FName = "Ahmed",
                LName = "B."
            };

            Console.WriteLine(e3.DisplayFullName());

            #endregion
        }
    }

    #region Date Model

    // Model: Date
    // Format: dd/MM/yyyy
    // dd -> 1–31 , mm -> 1–12 , yyyy -> 0001–9999

    public class Date
    {
        private static readonly int[] DaysToMonth365 =
            { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static readonly int[] DaysToMonth366 =
            { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int day;
        private int month;
        private int year;

        // Main Constructor
        public Date(int day, int month, int year)
        {
            if (IsValidDate(day, month, year))
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                // Safe default date
                this.day = 1;
                this.month = 1;
                this.year = 1;
            }
        }

        // Constructor Overloading
        public Date(int year) : this(1, 1, year) { }

        public Date(int month, int year) : this(1, month, year) { }

        private static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1 || year > 9999) return false;
            if (month < 1 || month > 12) return false;

            bool isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            int[] days = isLeapYear ? DaysToMonth366 : DaysToMonth365;

            return day >= 1 && day <= days[month];
        }

        public string GetDate()
        {
            return $"{day:D2}/{month:D2}/{year:D4}";
        }
    }

    #endregion

    #region Employee Model

    public class Employee
    {
        public int Id;
        public string FName;
        public string LName;

        public Employee() { }

        public Employee(int id)
        {
            Id = id;
        }

        public string DisplayFullName()
        {
            return $"{Id} {FName} {LName}";
        }
    }

    #endregion
}
