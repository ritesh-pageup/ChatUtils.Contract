using ChatUtils.Contract.Dtos.CommunityMessageDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.ResponseMessage
{
    public class ChatGroupResponse: ResponseMsg
    {
        public ChatGroupDto? ChatGroup { get; set; }
        public int Count { get; set; }
    }
}
