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
        public int Id { get; set; }
        public int? MessageId { get; set; }
        public int EmployeeId { get; set; }
        public int RecieverId { get; set; }
        public string? EmployeeName { get; set; }   
        public string? RecieverName { get; set; }
        public int RecieverCount { get; set; } = 0;
        public int? ReceiverMessageId { get; set; } 
        [ForeignKey(nameof(MessageId))]
        public CommunityMessage? CommunityMessage { get; set; }
        [ForeignKey(nameof(ReceiverMessageId))]
        public CommunityMessage? ReceiverMessage { get; set; }
        public bool IsGroup { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime? LastDeleteDateTime { get; set; }
    }
}
