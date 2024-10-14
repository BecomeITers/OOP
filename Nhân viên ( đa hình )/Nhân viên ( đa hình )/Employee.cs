using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên___đa_hình__
{
    public abstract class Employee
    {
        public string empCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Employee()
        {
            empCode = string.Empty;
            firstName = string.Empty;
            lastName = string.Empty;
        }

        public Employee(string empCode, string firstName, string lastName)
        {
            this.empCode = empCode;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual string toString()
        {
            return $"EmpCode: {empCode}, FirstName: {firstName}, LastName: {lastName}";
        }

        public abstract double Pay();
    }

    public class HourlyEmployee : Employee
    {
        public double rate { get; set; }
        public double workingHours { get; set; }

        public HourlyEmployee() : base()
        {
            rate = 0;
            workingHours = 0;
        }

        public HourlyEmployee(string empCode, string firstName, string lastName, double rate, double workingHours) : base(empCode, firstName, lastName)
        {
            this.rate = rate;
            this.workingHours = workingHours;
        }

        public override double Pay()
        {
            return rate * workingHours;
        }

        public override string toString()
        {
            return $"EmpCode: {empCode}, FirstName: {firstName}, LastName: {lastName}, Rate: {rate}, WorkingHours: {workingHours}, Pay: {Pay()}";
        }
    }

    public class SalariedEmployee : Employee
    {
        public double commisionRate { get; set; }
        public double grossSales { get; set; }
        public double basic { get; set; }

        public SalariedEmployee() : base()
        {
            commisionRate = 0;
            grossSales = 0;
            basic = 0;
        }

        public SalariedEmployee(string empCode, string firstName, string lastName, double commisionRate, double grossSales, double basic) : base(empCode, firstName, lastName) 
        {
            this.commisionRate = commisionRate;
            this.grossSales = grossSales;
            this.basic = basic;
        }

        public override double Pay()
        {
            return basic + commisionRate * grossSales;
        }

        public override string toString()
        {
            return $"EmpCode: {empCode}, FirstName: {firstName}, LastName: {lastName}, CommisionRate: {commisionRate}, GrossSales: {grossSales}, Basic: {basic}, Pay: {Pay()}";
        }
    }
}
