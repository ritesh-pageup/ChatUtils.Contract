using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class GroupChat
    {
        public long Id { get; set; }
        public List<long>? EmployeeIds { get; set; }
        public string GroupName { get; set; }
        public List<long>? Admins { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set;}
    }
}
