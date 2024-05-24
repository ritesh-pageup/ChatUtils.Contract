using ChatUtils.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class MessageBoxDto
    {
        public long Id { get; set; }
        public string? Message { get; set; }
        public string? Name { get; set; }
        public string? UserType { get; set; }
        public long? SenderId { get; set; }
        //public bool IsSeen { get; set; }
        public MessageStatus Status { get; set; }
        public long? ReceiverId { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsGroup { get; set; }
        public List<long>? SeenIds {  get; set; }
    }
}
