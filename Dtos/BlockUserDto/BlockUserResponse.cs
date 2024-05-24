using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.BlockUserDto
{
    public class BlockUserResponse
    {
        public long Id { get; set; }
        public long BlockedUserId { get; set; }
        public string? BlockedUserName { get; set; }
    }
}
