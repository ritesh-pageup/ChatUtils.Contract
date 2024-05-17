using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class GroupChat
    {
        public int Id { get; set; }
        public List<int>? EmployeeIds { get; set; }
        public string GroupName { get; set; }
        public List<int>? Admins { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set;}
    }
}
