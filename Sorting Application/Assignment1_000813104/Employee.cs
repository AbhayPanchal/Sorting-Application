using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///  I, Abhay Panchal, 000813104 certify that this material is my original work.  
///  No other person's work has been used without due acknowledgement.(SEP : 2020)
/// </summary>

namespace Assignment1_000813104
{   
    /// <summary>
    /// Employee class here has many get and set methods which help the application to process the output for user.
    /// Tostring method use to output the data perfectly on the console.
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Declaring the variables called name, number, rate, hours and gross
        /// </summary>
        
        private string name;
        private int number;
        private decimal rate;
        private double hours;

        private decimal gross;

        /// <summary>
        /// Constructoe Employee for Class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="rate"></param>
        /// <param name="hours"></param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }

        /// <summary>
        /// GetGross method which used in this class to calculate the total pay of the employee.
        /// it just multiply the payrate with hours work and if the hours are more than 40 than it multiply the rate by 1.5
        /// 
        /// </summary>
        /// <returns>gross</returns>
        
        public decimal GetGross()
        {
            if (hours <= 40)
            {
                gross = (decimal)hours * rate;
            }
            else
            {
                double overtimeHours = hours - 40; // it will give over time hours so it will count 1.5
                decimal overtimeRate = (decimal)1.5 * rate;
                decimal overtimePay = (decimal)overtimeHours * overtimeRate;

                decimal normalPay = (decimal)40 * rate;

                gross = overtimePay + normalPay;
            }
            return gross;
        }      

        /// <summary>
        /// GetHours method which return the hours worked by employee.
        /// </summary>
        /// <returns>hours</returns>
        public double GetHours()
        {
            return hours;
        }

        /// <summary>
        /// GetName method which return the name of the employee.
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// GetNumber method which return the number of the employee.
        /// </summary>
        /// <returns>number</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// GetRate method which return the pay rate of the employee.
        /// </summary>
        /// <returns>rate</returns>
        public decimal GetRate()
        {
            return rate;
        }

        /// <summary>
        /// SetHours method which set the hours of th eemployee.
        /// </summary>
        /// <param name="hours">Employees's worked hours</param>
        public void SetHours(double hours)
        {
            this.hours = hours;

        }

        /// <summary>
        /// SetName method which set the name of th eemployee.
        /// </summary>
        /// <param name="hours">Employees's name</param>
        public void SetName(string name)
        {
            this.name = name;

        }

        /// <summary>
        /// SetNumber method which set the number of th eemployee.
        /// </summary>
        /// <param name="hours">Employees's number</param>
        public void SetNumber(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Setrate method which set the pay rate of th eemployee.
        /// </summary>
        /// <param name="hours">Employees's pay rate</param>
        public void setRate(decimal rate)
        {
            this.rate = rate;
        }

        /// <summary>
        /// ToString method which return all variables name, number , rate, hours and method GetGross.
        /// </summary>
        /// <returns>name</returns>
        /// <returns>number</returns>
        /// <returns>rate</returns>
        /// <returns>hours</returns>
        /// <returns>GetGross</returns>
        public override string ToString()
        {
            return $"{name,-15}{number,10}{"   "}{rate,0:c}{"   "}{hours,-6:n}{"   "}{GetGross(),-5:c}";

        }


    }
}
