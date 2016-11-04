// Employee hierarchy test application.
using System;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create derived class objects
        SalariedEmployee salariedEmployee1 =
           new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        HourlyEmployee hourlyEmployee1 =
           new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40);
        SalariedEmployee salariedEmployee2 =
           new SalariedEmployee("Sue", "Jones", "333-33-3333", 1000.00M);
        HourlyEmployee hourlyEmployee2 =
           new HourlyEmployee("Bob", "Lewis", "444-44-4444", 50.00M, 45);

        // Create 2 CommissionEmployee objects here
        CommissionEmployee commissionEmployee1 =
         new CommissionEmployee("Max", "Rain", "555-55-5555", 400m, 0.8m);
        CommissionEmployee commissionEmployee2 =
         new CommissionEmployee("Alaa", "Bob", "666-66-6666", 6600m,0.6m);

        // Change to 6 to hold 2 new CommissionEmployee objects
        Employee[] employees = new Employee[6];

        // initialize array with Employees of derived types
        employees[0] = salariedEmployee1;
        employees[1] = hourlyEmployee1;
        employees[2] = salariedEmployee2;
        employees[3] = hourlyEmployee2;
        employees[4] = commissionEmployee1;
        employees[5] = commissionEmployee2;
        // Add 2 CommissionEmployee objects to array here

        Console.WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        foreach (Employee currentEmployee in employees)
        {
            Console.WriteLine(currentEmployee); // invokes ToString implicitly
            Console.WriteLine("earned " + currentEmployee.CalcEarnings().ToString("C"));
            Console.WriteLine();
        } // end foreach
    } // end Main
} // end class PayrollSystemTest
