using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_7
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string add { get; set; }
        public string DoB { get; set; }
    }
    public class Car
    {
        public string brand { get; set; }
        public int price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<User> listuser = new List<User>
            {
                new User{ID = 1,name= "John",add = "London",DoB = "2001-04-01" },
                new User{ID = 2,name=  "Lenny",add =  "New York",DoB = "1997 - 12 - 11" },
                new User{ID = 3,name=  "Andrew",add =  "Boston",DoB =  "1987-02-22" },
                new User{ID = 4,name=  "Peter",add =  "Prague",DoB =  "1936-03-24" },
                new User{ID = 5,name=  "Anna",add =  "Bratislava",DoB =  "1973-11-18" },
                new User{ID = 6,name=  "Albert",add =  "Bratislava",DoB =  "1940-12-11" },
                new User{ID = 7,name=  "Adam",add =  "Trnava ",DoB =  "1983-12-01" },
                new User{ID = 8,name=  "Robert",add =  "Bratislava",DoB =  "1935-05-15" },
                new User{ID = 9,name=  "Robert",add =  "Prague",DoB =  "1998-03-14" },
            };

            Console.WriteLine("User who lives in Bratislava:");
            var users = from s in listuser
                        where s.add == "Bratislava"
                        select new
                        {
                            name = s.name,
                            add = s.add,
                            DoB = s.DoB,
                        };
            users.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Add: {1}" + ", DoB: {2} ", s.name, s.add, s.DoB));

            List<Car> cars = new List<Car>
            {
                new Car{brand = "Audi", price = 52642},
                new Car { brand = "Mercedes", price = 57127 },
                new Car { brand = "Skoda", price = 9000 },
                new Car { brand = "Volvo", price = 29000 },
                new Car { brand = "Bentley", price = 350000 },
                new Car { brand = "Citroen", price = 21000 },
                new Car { brand = "Hummer", price = 41400 },
                new Car { brand = "Volkswagen", price = 21600 },
            };

            var car = from s in cars
                      where s.price >= 30000 && s.price <= 100000
                      select new
                      {
                          brand = s.brand,
                          price = s.price
                      };
            Console.WriteLine("list of cars whose price is between 30000 and 100000:");
            car.ToList().ForEach(s => Console.WriteLine("brand: {0}, price: {1}", s.brand, s.price));


        }
    }
}