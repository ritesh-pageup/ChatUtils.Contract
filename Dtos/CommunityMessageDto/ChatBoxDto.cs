using ChatUtils.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class ChatBoxDto
    {
        //public long EmployeeId { get; set; }
        //public string? EmployeeName { get; set; }
        public string? LastMessage { get; set; }
        //public bool IsSeen { get; set; }
        public MessageStatus Status { get; set; }
        public long NewMessages { get; set; }
        public DateTime? LastMessageDate { get; set; }

        public long RecieverId { get; set; }
        public string? RecieverName { get; set; }
        public DateTime? LastActive { get; set; }
        public bool IsGroup { get; set; }
    }
}
