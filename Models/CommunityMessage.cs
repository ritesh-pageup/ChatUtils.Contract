using ChatUtils.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class CommunityMessage
    {
        public long Id { get; set; }
        public string? Message { get; set; }
        public long EmployeeId { get; set; }
        //public string? EmployeeName { get; set; }
        public long? RecieverId { get; set; }
        //public long DepartmentId { get; set; }
        //public string? UserType { get; set; }
        //public bool IsSeen { get; set; } = false;
        public DateTime MessageDate { get; set; }
        //public string? RecieverName { get; set; }
        public bool IsBlocked { get; set; }
        //public bool IsEmployeeDeleted { get; set; }
        //public bool IsReceiverDeleted { get; set; }
        public bool IsGroup { get; set; } = false;
        public MessageStatus Status { get; set; }
        public List<long>? DeletedIds { get; set; }
        public bool IsActive { get; set; } = true;
        public List<long>? SeenIds { get; set; }
    }
}
