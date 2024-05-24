using ChatUtils.Contract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class GetChatBoxDto
    {
        public long EmployeeId { get; set; }
        public long Count { get; set; }
        public CommunityMessage? CommunityMessagge { get; set; }
    }
}
