using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProgram
{
    internal class Mobile
    {
        //Instance variables//

        private String accType, device, number;
        private double balance;

        //VARIABLES//
        private const double CALL_COST = 0.245;
        private const double TEXT_COST = 0.078;
        public Mobile(String accType, string device, String number) 
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }
        public String getAccType() 
        {
            return accType; 
        }
        public String getDevice()
        {
            return this.device;
        }
        public String getNumber()
        {
            return this.number;
        }
        public String getBalance()
        {
            return this.balance.ToString("C");
        }
        public void setAccType(String accType)
        {
            this.accType=accType;
        }
        public void setDevice(String device)
        {
            this.device=device;
        }
        public void setNumber(String number) 
        {
            this.number=number;
        }
        public void setBalance(double balance)
        { 
            this.balance = balance;
        }
        public void AddCredit(double Amount)
        {
            this.balance += Amount;

            Console.WriteLine("Credit added successfully. new balance " + getBalance());
        }
        public void MakeCall(int minutes)
        {
            double cost;
            cost = minutes * CALL_COST;
            this.balance -= cost;

            Console.WriteLine("Call made. New balance " + getBalance());
        }
        public void SendText(int numTexts)
        {
            double cost;
            cost = numTexts * TEXT_COST;
            this.balance -= cost;

            Console.WriteLine("Text Sent. New balance " +  getBalance());
        }
    }
}
