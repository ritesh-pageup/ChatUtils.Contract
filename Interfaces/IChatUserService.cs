using ChatUtils.Contract.Dtos;
using ChatUtils.Contract.Models;
using ChatUtils.Contract.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Interfaces
{
    public interface IChatUserService
    {
        public Task<bool> AddAsync(long UserId);
        public Task<ResponseWithObjectMessage<ChatUserDto>> GetUserAsync(long UserId);
        public Task<ResponseMsg> UpdateSystemToken(int UserId, SetSystemTokenRequest request);
        public Task<ResponseWithDataAndCount<ChatUserDto>> GetUsersAsync(List<long> UserIds);
    }
}
