using System;

namespace RegexforEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserRegistrastion userRegistrastion = new UserRegistrastion();
            Console.WriteLine("Email" +userRegistrastion.ValidateEmail("abc@yahoo.com"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abcyahoo.com"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc-100@yahoo.com"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc-100yahoo.com"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc.100@yahoo.com"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc100yahoo.com"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc111@abc.com"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc111@abccom"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc.100@abc.com.au"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc100@abc.com.au"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc@1.com"));
            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc.100@abc.com.au"));

            Console.WriteLine("Email" + userRegistrastion.ValidateEmail("abc+100@gmail.com"));







        }
    }
}
