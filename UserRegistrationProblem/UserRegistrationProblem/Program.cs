﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Shreya");
            // validateUser.validateFirstName("shreya");
            validateUser.validateLastName("Malviya");
            validateUser.validateEmailId("malviyashreya26@gmail.com");
            validateUser.validateMobileNumber("8798761833");
            validateUser.validatePassword("Shreya345");
            validateUser.validateUperCasePassword("Shreya345");
            validateUser.validateNumericPassword("shreya3345");
            validateUser.validateSpecialcarPassword("shreya@3345");
            validateUser.validateAllTypeEmail("malviyashreya26@gmail.com");
            validateUser.validateAllTypeEmail("malviyashreya5526@gmail.com");
            validateUser.validateAllTypeEmail("malviyashre+26@gmail.com");
            validateUser.validateAllTypeEmail("sabc_2002@gmail.com");

            Console.ReadKey();
        }
    }
}
