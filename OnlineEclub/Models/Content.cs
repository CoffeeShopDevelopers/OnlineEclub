using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineEclub.Models;

namespace OnlineEclub.Models
{
    public class Content
    {
        public int ContentID { get; set; }
        public string ContentTitle { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
