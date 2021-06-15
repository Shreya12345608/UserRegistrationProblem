using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class UserRegistration
    {
        //For First NAme
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(firstName, stringForFirstName))
                Console.WriteLine(firstName + " is Valid");
            else
                Console.WriteLine(firstName + " is Invalid");
        }
        //For last NAme
        public void validateLastName(string lastName)
        {
            string stringForLastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(lastName, stringForLastName))
                Console.WriteLine(lastName + " is Valid");
            else
                Console.WriteLine(lastName + " is Invalid");
        }
        //For email
        public void validateEmailId(string emailID)
        {
            string stringForEmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
            if (Regex.IsMatch(emailID, stringForEmailId))
                Console.WriteLine(emailID + " is Valid");
            else
                Console.WriteLine(emailID + " is Invalid");
        }
        //For Mobile Number
        public void validateMobileNumber(string mobileNumber)
        {
            string stringForMobileNumber = "^[0-9]{10}";
            if (Regex.IsMatch(mobileNumber, stringForMobileNumber))
                Console.WriteLine(mobileNumber + " is Valid");
            else
                Console.WriteLine(mobileNumber + " is Invalid");
        }
        //For Password
        public void validatePassword(string password)
        {
            string stringForPassword = "^.{8,}?";
            if (Regex.IsMatch(password, stringForPassword))
                Console.WriteLine(password + " is Valid");
            else
                Console.WriteLine(password + " is Invalid");
        }
    }

}