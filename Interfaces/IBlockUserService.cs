using ChatUtils.Contract.Dtos.BlockUserDto;
using ChatUtils.Contract.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Interfaces
{
    public interface IBlockUserService
    {
        public Task<ResponseMsg> AddAsync(long blockUserId, long currentUserId);
        public Task<ResponseWithDataAndCount<BlockUserResponse>> GetBlockedUsers(long CurrentUserId);
        public Task<ResponseMsg> RemoveAsync(long blockedUserId, long currentUserId);
        public Task<ResponseMsg> Update(long blockedUserId, long currentUserId);
        public Task<List<long>> CheckBlocked(long CurrentUserId);
        public Task<bool> CheckWhoBlockMe(long UserId, long RecieverId);
    }
}
