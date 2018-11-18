using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEclub.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public int CategoryID { get; set; }
        public int ContentID { get; set; }
        public int MemberMin { get; set; }
        public int MemberLimit { get; set; }
    }
}
