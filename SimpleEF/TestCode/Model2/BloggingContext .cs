using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model2
{
    public class TestCodeContext2 : DbContext
    {
        public TestCodeContext2():
            base("TestCodeConnectionString2")
        {

        }
        public DbSet<Blog2> Blogs { get; set; }
        public DbSet<Post2> Posts { get; set; }
    }
}
