using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class BlockUser
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long BlockedUserId { get; set; }
    }
}
