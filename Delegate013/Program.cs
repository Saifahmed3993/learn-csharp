namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Elmpolyee[] {
            new Elmpolyee{ Id=1, Name="Mark", TotalSales=100000m, Gander="M"},
            new Elmpolyee{ Id=2, Name="John", TotalSales=1500m, Gander="M"},
            new Elmpolyee{ Id=3, Name="Mary", TotalSales=2082300m, Gander="F"},
            new Elmpolyee{ Id=4, Name="Pam", TotalSales=35000m, Gander="F"},
            new Elmpolyee{ Id=5, Name="Todd", TotalSales=3000m, Gander="M"},
            new Elmpolyee{ Id=6, Name="Sara", TotalSales=3500m, Gander="F"},
            new Elmpolyee{ Id=7, Name="David", TotalSales=4000m, Gander="M"},
            new Elmpolyee{ Id=8, Name="Susan", TotalSales=4500m, Gander="F"},
            };

            var report = new Report();
            //report.ProcessEmpolyeeWith60000PlusSales(emps);
            //report.ProcessEmpolyeeWith30000PlusSales(emps);
            //report.ProcessEmpolyeeWithsaleslesstan30000and59999Sales(emps);

            // Using delegate
            report.ProcessEmpolyee(emps, "Employees with sales more than 60000", emp => emp.TotalSales > 60000m);
            report.ProcessEmpolyee(emps, "Employees with sales more than 30000", emp => emp.TotalSales > 30000m && emp.TotalSales <= 60000m);
            report.ProcessEmpolyee(emps, "Employees with sales less than 30000", emp => emp.TotalSales < 30000m);

        }
    }
}
