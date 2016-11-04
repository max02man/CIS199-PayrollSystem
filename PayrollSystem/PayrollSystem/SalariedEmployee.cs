// SalariedEmployee class that extends Employee.
using System;

public class SalariedEmployee : Employee
{
   private decimal _weeklySalary; // Weekly salary

   // four-parameter constructor
   public SalariedEmployee( string first, string last, string ssn,
      decimal salary ) : base( first, last, ssn )
   {
      WeeklySalary = salary; // validate salary via property
   } // end four-parameter SalariedEmployee constructor

   // property that gets and sets salaried employee's salary
   public decimal WeeklySalary
   {
      get
      {
         return _weeklySalary;
      } // end get
      set
      {
          if (value >= 0) // validation
              _weeklySalary = value;
          else
              throw new ArgumentOutOfRangeException();
      } // end set
   } // end property WeeklySalary

   // calculate earnings; override abstract method Earnings in Employee
   public override decimal CalcEarnings()
   {
       return WeeklySalary;
   } // end method Earnings          

   // return string representation of SalariedEmployee object
   public override string ToString()
   {
      return "salaried employee: " + base.ToString() + System.Environment.NewLine +
       "weekly salary: " + WeeklySalary.ToString("C");
   } // end method ToString                                      
} // end class SalariedEmployee
