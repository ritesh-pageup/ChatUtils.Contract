using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class UserGroup
    {
        public long Id { get; set; }   
        public int UserId { get; set; }
        public List<int>? GroupIds { get; set; }
    }
}
