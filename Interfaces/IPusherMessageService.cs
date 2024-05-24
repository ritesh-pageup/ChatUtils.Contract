using ChatUtils.Contract.Dtos.ChatGroupDto;
using ChatUtils.Contract.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Interfaces
{
    public interface IPusherMessageService
    {
        public Task<ResponseMsg> TriggeredBySeen(long ReceiverId, bool status, long SenderId);
        public Task<ResponseMsg> TriggeredByTyping(long ReceiverId, bool status, long SenderId);
        public Task<ResponseMsg> TriggeredByOnline(long RecieverId, bool status, long SenderId);
        public Task<ResponseMsg> TriggeredByRecentActive(RecentActiveDto activeDto, long SenderId);
        public Task<ResponseWIthEterableMessage<RecentActiveResponse>> GetRecentActive(List<long> SenderIds, long UserId);
    }
}
