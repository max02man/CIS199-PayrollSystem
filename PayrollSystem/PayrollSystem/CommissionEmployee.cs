// Alaa Hawsawi
// save time is 4:47

using System;

// Add Your Code Here
public class CommissionEmployee : Employee
{

    private decimal _grossSales; // posite
    private decimal _commissionRate; //0 or1


    public CommissionEmployee(string first, string last, string ssn,
      decimal grossSales, decimal commissionrate)
        : base(first, last, ssn)
    {
        GrossSales = grossSales;
        CommissionRate = commissionrate;
    }
    public decimal GrossSales
    {
        get { return _grossSales; }
        set
        {
            if (value >= 0)
                _grossSales = value;
            else
                _grossSales = 0;
        }
    }
    public decimal CommissionRate
    {
        get { return _commissionRate; }
        set
        {
            if (value >= 0 && value <= 1) // validation
                _commissionRate = value;
            else
                _commissionRate = 0;
        }
    }
    public override decimal CalcEarnings()
    {
        return CommissionRate * GrossSales;
    }
    public override string ToString()
    {
        return "employee: " + base.ToString() + System.Environment.NewLine + " The Gross Sales is: " + GrossSales.ToString("c2") +
            " Commission Rate is: " + CommissionRate.ToString("p2");

    }
}

