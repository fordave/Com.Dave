using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNHibernateDemo.Models
{
    public class Emp
    {
        public virtual int EmpId { get; set; }
        public virtual string EmpName { get; set; }
        public virtual DateTime EmpDate { get; set; }
    }
}
