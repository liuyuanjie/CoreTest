using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model2
{
    public class Post2
    {
        public int Post2Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int Blog2Id { get; set; }
        public virtual Blog2 Blog { get; set; }
    }
}
