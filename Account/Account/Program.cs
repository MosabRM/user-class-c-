﻿using System;

namespace Account
{


    class Program
    {

        static void Main(string[] args)
        {
            #region User class
            User Users = new User();
            Console.WriteLine("First Name");
            Users.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            Users.lastName = Console.ReadLine();
            Console.WriteLine("User Name:");
            Users.UserName = Console.ReadLine();
            Console.WriteLine("Email");
            Users.Email = Console.ReadLine();
            Console.WriteLine("mobile");
            Users.mobile = Console.ReadLine();
            Console.WriteLine("nationalid");
            Users.nationalid = Console.ReadLine();
            Console.WriteLine("monthly Salary");
            Users.monthlysalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Users.FullName());
            Console.WriteLine("User's Mobile Number:" + Users.Mobile());
            Console.WriteLine("birthday")
            Users.birthDay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("User's age is: " + Users.CalAge());
            #endregion
            #region Check password
            Console.WriteLine("write your password");
            string userPassword = Console.ReadLine();
            #endregion
            #region Confirm password
            Console.WriteLine("enter you password");
            Console.WriteLine("confirm your password again");
        }
        #endregion
    }


}