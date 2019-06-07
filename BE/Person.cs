using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Person
    {
        // Holds the actual Mispar Zehut
        private String myID;

        public String ID
        {
            get { return myID;  }   // Just return the MZ
            set
            {
                // Make sure the passed number is a valid MZ
                if (IDCheckSum(value))
                {
                    myID = value;
                }
                else
                {
                    throw new Exception(String.Format("ID {0} not valid", value));
                }
            }
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }
        public int PhoneNumber { get; set; }
        public MailAddress Email { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            String result = "";
            result += String.Format("ID: {0}\n", ID);
            result += String.Format("First Name: {0}\n", FirstName);
            result += String.Format("Last Name: {0}\n", LastName);
            result += String.Format("Gender: {0}\n", Gender);
            result += String.Format("DOB: {0}\n", BirthDay);
            result += String.Format("Address: {0}\n", Address);
            result += String.Format("Phone Number: {0}\n", PhoneNumber);
            result += String.Format("Email: {0}\n", Email);
            return result;
        }

        private bool IDCheckSum(String ID)
        {
            char[] digits = ID.PadLeft(9, '0').ToCharArray();

            int[] oneTwo = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int[] multiply = new int[9];
            int[] oneDigit = new int[9];
            for (int i = 0; i < 9; i++)
                multiply[i] = Convert.ToInt32(digits[i].ToString()) * oneTwo[i];
            for (int i = 0; i < 9; i++)
                oneDigit[i] = (int)(multiply[i] / 10) + multiply[i] % 10;
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += oneDigit[i];
            if (sum % 10 == 0)
                return true;
            return false;
        }
    } 
}
