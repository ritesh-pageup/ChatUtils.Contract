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
        public Task<ResponseMsg> TriggeredBySeen(int ReceiverId, bool status, int SenderId);
        public Task<ResponseMsg> TriggeredByTyping(int ReceiverId, bool status, int SenderId);
        public Task<ResponseMsg> TriggeredByOnline(int RecieverId, bool status, int SenderId);
        //public Task<ResponseMsg> TriggeredByRecentActive(RecentActiveDto activeDto, IEnumerable<Claim> claim);
        //public Task<ResponseWIthEterableMessage<RecentActiveResponse>> GetRecentActive(List<int> SenderIds, IEnumerable<Claim> claim);
    }
}
