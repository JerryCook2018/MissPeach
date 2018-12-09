//Payroll group Jerry, Nathan, Karen

using System;
using System.Collections.Generic;
using System.Text;
//created to sync 
namespace MissPeach
{
    public class PayCheck
    {
        public PayCheck()
        {

        }
        //data gathered from this paycheck entry to system by teacher

        private string postingDate;
        private int studentId;
        private string firstName;
        private string lastName;
        private string maritalStatus;
        private int fedExemptions;
        private int stateExemptions;
        private double grossPay;
        private const double deskRent = 25.00;
        //later use
        private double hourlyPay { get; set; }


        
        //from paycheck entry and w4"
        public void SetStudentFirstName(string name)
        {
            firstName = name;
        }

        public void SetStudentLastName(string name)
        {
            lastName = name;
        }
        public string GetStudentFirstName()
        {
            //from student passed into this class
            return firstName;
        }

        public string GetStudentLastName()
        {
            return lastName;
        }
        public double GetGrossPay()
        {
            return grossPay;
        }
        public void SetPayPeriod()
        {
            postingDate = DateTime.Now.ToString("MM/dd/yyyy/");
        }

        public string GetPayPeroid()
        {
            return postingDate;
        }

        public void SetStudentId(int studentId)
        {
            this.studentId = studentId;
        }

        public int GetStudentId()
        {
            return studentId;
        }

        // information from w4
        public void SetMaritalStatus(string maritalStatus)
        {
            //should be got from database
            this.maritalStatus = maritalStatus;
        }

        public string GetMaritalStatus()
        {
            return maritalStatus;
        }

        //should be got from w4

        public void SetFedExemptions(int fedExemptions)
        {
            this.fedExemptions = fedExemptions;
        }

        public int GetFedExemptions()
        {
            return fedExemptions;
        }

        //should be got from w4

        public void SetStateExemptions(int stateExemptions)
        {
            this.stateExemptions = stateExemptions;
        }

        public int GetStateExemptions()
        {
            return stateExemptions;
        }

        public double GetFederalTax()
        {
            if (grossPay >= 114.46)
            {
                return (grossPay - 114.46) * 0.10;
            }
            return 0;
        }

        public double GetStateTax()
        {
            if (grossPay >= 63.46)
            {
                return (grossPay - 63.46) * 0.39;
            }
            return 0;
        }

        public double GetMedicareTax()
        {
            if (grossPay > 0)
            {
                return (grossPay * 0.145);
            }
            return 0;
        }

        public double GetSocialTax()
        {
            if (grossPay > 0)
            {
                return (grossPay * 0.62);
            }
            return 0;
        }
        
        public void SetGrossPay(double grossPay)
        {
            this.grossPay = grossPay;
        }

        public double GetDirectDeposit()
        {
            var fedTax = GetFederalTax();
            var stateTax = GetStateTax();
            var socialTax = GetSocialTax();
            var medicareTax = GetMedicareTax();

            var deposit = grossPay - fedTax - stateTax - socialTax - medicareTax;
            deposit -= deskRent;
            return deposit;
        }
       
       
        
        
    }

}
