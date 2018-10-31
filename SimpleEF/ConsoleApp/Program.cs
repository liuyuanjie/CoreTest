using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model;
using TestCode.Model2;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            //using (var dbContext = new TestCodeContext())
            //{
            //    dbContext.Blogs.Add(new Blog
            //    {
            //        BlogId = 1,
            //        Name="Blog.1"
            //    });
            //    dbContext.SaveChanges();
            //}

            //using (var dbContext2 = new TestCodeContext2())
            //{
            //    dbContext2.Blogs.Add(new Blog2
            //    {
            //        Blog2Id = 1,
            //        Name = "Blog.1"
            //    });
            //    dbContext2.SaveChanges();
            //}
            Console.ReadKey();
            using (var dbContext = new TestCodeContext())
            using (var dbContext2 = new TestCodeContext2())
            {
                dbContext.Blogs.First().Name = dbContext2.Blogs.First().Name;
                dbContext.SaveChanges();
            }
        }
    }
}
