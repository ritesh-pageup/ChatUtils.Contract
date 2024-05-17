using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class ChatGroupDto
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<int>? EmployeeIds { get; set; }
        public List<int>? Admins { get; set; }
    }
}
