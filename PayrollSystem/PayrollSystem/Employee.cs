// Employee abstract base class.
public abstract class Employee
{
    private string _firstName; // Employee's first name
    private string _lastName;  // Employee's last name
    private string _ssn;       // Employee's SSN

   // read-only property that gets employee's first name
   public string FirstName {
       get { return _firstName; }
       private set { _firstName = value; }
   }

   // read-only property that gets employee's last name
   public string LastName {
       get { return _lastName; }
       private set { _lastName = value; }
   }

   // read-only property that gets employee's social security number
   public string SocialSecurityNumber {
       get { return _ssn; }
       private set { _ssn = value; }
   }

   // three-parameter constructor
   public Employee( string first, string last, string ssn )
   {
      FirstName = first;
      LastName = last;
      SocialSecurityNumber = ssn;
   } // end three-parameter Employee constructor

   // return string representation of Employee object, using properties
   public override string ToString()
   {
      return FirstName + " " + LastName + System.Environment.NewLine +
       "social security number: " + SocialSecurityNumber;
   } // end method ToString

   // abstract method overridden by derived classes
   public abstract decimal CalcEarnings(); // no implementation here
} // end abstract class Employee
