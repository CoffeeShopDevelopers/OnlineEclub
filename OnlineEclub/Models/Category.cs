using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineEclub.Models;

namespace OnlineEclub.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryTitle { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
