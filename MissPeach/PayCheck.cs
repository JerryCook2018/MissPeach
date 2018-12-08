using System;
using System.Collections.Generic;
using System.Text;
//created to sync 
namespace MissPeach
{
    class PayCheck
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
        private double federalTax;
        private double stateTax;
        private double socialTax;
        private double medicareTax;
        private double directDeposit;
        private const double deskRent = 25.00;


        //from paycheck entry and w4"
        public string getStudentFirstName(string firstName)
        {
            //from student passed into this class
            return firstName;
        }

        public string getStudentLastName(string lastName)
        {
            return lastName;
        }
        
        public void setPayPeriod()
        {
            postingDate = DateTime.Now.ToString("MM/dd/yyyy/");
        }

        public string getPayPeroid()
        {
            return postingDate;
        }

        public void setStudentId(int studentId)
        {
            this.studentId = studentId;
        }

        public int getStudentId()
        {
            return studentId;
        }

        // information from w4
        public void setMaritalStatus(string maritalStatus)
        {
            //should be got from database
            this.maritalStatus = maritalStatus;
        }

        public string getMaritalStatus()
        {
            return maritalStatus;
        }

        //should be got from w4

        public void setFedExemptions(int fedExemptions)
        {
            this.fedExemptions = fedExemptions;
        }

        public int getFedExemptions()
        {
            return fedExemptions;
        }

        //should be got from w4

        public void setStateExemptions(int stateExemptions)
        {
            this.stateExemptions = stateExemptions;
        }

        public int getStateExemptions()
        {
            return stateExemptions;
        }

        public double getFederalTax()
        {
            if (grossPay >= 114.46)
            {
                return (grossPay - 114.46) * 0.10;
            }
            return 0;
        }

        public double getStateTax()
        {
            if (grossPay >= 63.46)
            {
                return (grossPay - 63.46) * 0.39;
            }
            return 0;
        }

        public double getMedicareTax()
        {
            if (grossPay > 0)
            {
                return (grossPay * 0.145);
            }
            return 0;
        }

        public double getSocialTax()
        {
            if (grossPay > 0)
            {
                return (grossPay * 0.62);
            }
            return 0;
        }
        
        public void setGrossPay(double grossPay)
        {
            this.grossPay = grossPay;
        }

        public double getDirectDeposit()
        {
            var fedTax = getFederalTax();
            var stateTax = getStateTax();
            var socialTax = getSocialTax();
            var medicareTax = getMedicareTax();

            var deposit = grossPay - fedTax - stateTax - socialTax - medicareTax;
            deposit -= deskRent;
            return deposit;
        }



        
    }

}
