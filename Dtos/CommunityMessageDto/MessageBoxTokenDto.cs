using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class MessageBoxTokenDto
    {
        public List<MessageBoxDto>? Data { get; set; }
        public string? SystemToken { get; set; }
        public bool IsBlockedUser { get; set; }
    }
}
