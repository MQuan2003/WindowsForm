using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7c
{
    public class User
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> lstUser = new List<User>
            {
                new User {Fname="John", Lname="Doe", Salary=1230},
                new User {Fname="Lucy", Lname="Novak", Salary=670},
                new User {Fname="Ben", Lname="Walter", Salary=2050},
                new User {Fname="Robin", Lname="Brown", Salary=2300},
                new User {Fname="Amy", Lname="Doe", Salary=1250},
                new User {Fname="Joe", Lname="Draker", Salary=1190},
                new User {Fname="Janet", Lname="Doe", Salary=980},
                new User {Fname="Albert", Lname="Novak", Salary=1930},
            };
            var sortac = from u in lstUser
                         orderby u.Lname, u.Salary
                         select new
                         {
                             Fname = u.Fname,
                             Lname = u.Lname,
                             Salary = u.Salary
                         };
            Console.WriteLine("Sort ascending by last name and salary");
            sortac.ToList().ForEach(u => Console.WriteLine($"{u.Fname} {u.Lname} {u.Salary}"));
            var over = from u in sortac
                       where u.Salary > 1500
                       select u;
            Console.WriteLine("Select users who have salary higher than 1500");
            over.ToList().ForEach(u => Console.WriteLine($"{u.Fname} {u.Lname} {u.Salary}"));
            Console.ReadKey();
        }
    }
}