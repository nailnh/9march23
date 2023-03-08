using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        public Book(string name, int pagecount)
        {
            Name = name;
            PageCount = pagecount;
        }
    }
}
