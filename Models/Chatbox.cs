using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class Chatbox
    {
        public long Id { get; set; }
        public long? MessageId { get; set; }
        public long EmployeeId { get; set; }
        public long RecieverId { get; set; }
        public string? EmployeeName { get; set; }   
        public string? RecieverName { get; set; }
        public long RecieverCount { get; set; } = 0;
        public long? ReceiverMessageId { get; set; } 
        [ForeignKey(nameof(MessageId))]
        public CommunityMessage? CommunityMessage { get; set; }
        [ForeignKey(nameof(ReceiverMessageId))]
        public CommunityMessage? ReceiverMessage { get; set; }
        public bool IsGroup { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime? LastDeleteDateTime { get; set; }
    }
}
