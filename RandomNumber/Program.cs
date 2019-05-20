using System;
using System.Collections.Generic;

namespace RandomNumber
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            List<UserModel> people = new List<UserModel> {
                new UserModel{ FirstName = "John"},
                new UserModel{ FirstName = "Peter"},
                new UserModel{ FirstName = "Sarah"},
                new UserModel{ FirstName = "Jessica"},
                new UserModel{ FirstName = "Joan"},
                new UserModel{ FirstName = "Sammie"},
                new UserModel{ FirstName = "George"},
                new UserModel{ FirstName = "Harry"},
            };

            people.Shuffle();

            foreach (var p in people)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        public class UserModel
        {
            public string FirstName { get; set; }
        }
    }

}
