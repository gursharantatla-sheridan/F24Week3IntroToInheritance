namespace F24Week3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass("hello");
            //DerivedClass objDerived = new DerivedClass();


            CommissionEmployee commEmp = new CommissionEmployee(101, "John", 10000, 0.20);
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings = {commEmp.Earnings():C}\n\n");

            SalaryPlusCommissionEmployee salCommEmp = new SalaryPlusCommissionEmployee(102, "Anne", 10000, 0.12, 500);
            Console.WriteLine(salCommEmp);
            Console.WriteLine($"\nEarnings = {salCommEmp.Earnings():C}");
        }
    }
}
