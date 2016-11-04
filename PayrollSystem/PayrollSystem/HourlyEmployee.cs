// HourlyEmployee class that extends Employee.
using System;

public class HourlyEmployee : Employee
{
   private decimal _wage;  // wage per hour
   private int _hours; // hours worked for the week

   public const int MAX_STANDARD_HOURS = 40;  // Normal hours in week
   public const decimal OVERTIME_RATE = 1.5M; // Overtime rate

   // five-parameter constructor
   public HourlyEmployee( string first, string last, string ssn,
      decimal hourlyWage, int hoursWorked )
      : base( first, last, ssn )
   {
      Wage = hourlyWage; // validate hourly wage via property
      Hours = hoursWorked; // validate hours worked via property
   } // end five-parameter HourlyEmployee constructor

   // property that gets and sets hourly employee's wage
   public decimal Wage
   {
      get
      {
         return _wage;
      } // end get
      set
      {
          if (value >= 0) // validation
              _wage = value;
          else
              throw new ArgumentOutOfRangeException();
      } // end set
   } // end property Wage

   // property that gets and sets hourly employee's hours
   public int Hours
   {
      get
      {
         return _hours;
      } // end get
      set
      {
          if (value >= 0 && value <= 168) // validation
              _hours = value;
          else
              _hours = 0;
      } // end set
   } // end property Hours

   // calculate earnings; override Employee’s abstract method Earnings
   public override decimal CalcEarnings()
   {
      if ( Hours <= MAX_STANDARD_HOURS ) // no overtime                          
         return Wage * Hours;
      else
         return ( MAX_STANDARD_HOURS * Wage ) + ( ( Hours - MAX_STANDARD_HOURS ) * Wage * OVERTIME_RATE );
   } // end method Earnings                                      

   // return string representation of HourlyEmployee object
   public override string ToString()
   {
       return "hourly employee: " + base.ToString() + System.Environment.NewLine +
        "hourly wage: " + Wage.ToString("C") + " ; hours worked: " +
        Hours.ToString();
   } // end method ToString                                            
} // end class HourlyEmployee