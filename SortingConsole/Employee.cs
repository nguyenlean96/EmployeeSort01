using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingConsole
{
    internal class Employee
    {
        public string name
        {
            get; set;
        }
        public int number
        {
            get; set;
        }
        public decimal rate
        {
            get; set;
        }
        public double hours
        {
            get; set;
        }
        public decimal gross
        {
            get; set;
        }

        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }
        
        public override string ToString() 
        {
            return name + ' ' + number + ' ' + rate + ' ' + hours;
        }

    }

    class EmployeeNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (x == null)
                return -1;
            else if (y == null)
                return 1;

            return (new CaseInsensitiveComparer()).Compare(((Employee)x).name,
                           ((Employee)y).name);
        }
    }

    class EmployeeNumberComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (x == null)
                return -1;
            else if (y == null)
                return 1;

            return (new CaseInsensitiveComparer()).Compare(((Employee)x).number,
                           ((Employee)y).number);
        }
    }

    class EmployeeRateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (x == null)
                return -1;
            else if (y == null)
                return 1;

            return (new CaseInsensitiveComparer()).Compare(((Employee)x).rate,
                           ((Employee)y).rate);
        }
    }

    class EmployeeHoursComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (x == null)
                return -1;
            else if (y == null)
                return 1;

            return (new CaseInsensitiveComparer()).Compare(((Employee)x).hours,
                           ((Employee)y).hours);
        }
    }

    class EmployeeGrossComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (x == null)
                return -1;
            else if (y == null)
                return 1;

            return (new CaseInsensitiveComparer()).Compare(((Employee)x).gross,
                           ((Employee)y).gross);
        }
    }
}
