using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.ChatGroupDto
{
    public class RecentActiveDto
    {
        public int RecieverId { get; set; }
        public bool IsGroup { get; set; }
        public bool IsNull {  get; set; } 
    }
}
