using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class ChatGroupDto
    {
        public long Id { get; set; }
        public string GroupName { get; set; }
        public List<long>? EmployeeIds { get; set; }
        public List<long>? Admins { get; set; }
    }
}
