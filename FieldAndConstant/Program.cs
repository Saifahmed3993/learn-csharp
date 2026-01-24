namespace Field_Constant008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem
            //Company is lookng for app to do salary slip calculations for its employees based on daily basis following the 
            //rule total earning is equal to hour logged * his wage . fixed tax is applied 3% on all user need to enter input
            //& salary will be showen accordingly


            //const double TaxRate = 0.03; // Fixed tax rate of 3%

            //Console.Write("First Name: ");
            //var fName = Console.ReadLine();

            //Console.Write("Last Name: ");
            //var lName = Console.ReadLine();

            //Console.Write("Wage: ");
            //var wage = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Logged Hour: ");
            //var loggedHour = Convert.ToDouble(Console.ReadLine());


            //var totalEarning = wage * loggedHour;
            //Console.WriteLine($"Tatal Earning Without TAX = {totalEarning}");

            //var netsalary = wage * loggedHour - (wage * loggedHour * TaxRate);


            //Console.WriteLine($"First Name: {fName} Last Name: {lName} \nWage: {wage} \nLogged Hours: {loggedHour} \ntotal Earning = {totalEarning} \nNet Salary:{netsalary}");
            #endregion

            //Obj :
            //decleration : <type> <obj name> = new <type>();
            //Accessing field using obj : <obj name>.<field name>

            Employee e1 = new Employee();
            Console.WriteLine("Enter Ur F Name : ");
            e1.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Ur L Name : ");
            e1.LastName = Console.ReadLine();

            Console.WriteLine("Enter Ur Wage : ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Ur Logged Hour : ");
            e1.LoggedHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("========================");
            Console.WriteLine($"First Name : {e1.FirstName} \nLast Name : {e1.LastName} \nWage : {e1.Wage} \nLogged Hour : {e1.LoggedHour}");
        }
    }
}
