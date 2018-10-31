using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model2
{
    public class Blog2
    {
        public int Blog2Id { get; set; }
        public string Name { get; set; }

        public virtual List<Post2> Posts { get; set; }
    }
}
