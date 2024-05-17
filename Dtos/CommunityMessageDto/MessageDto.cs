using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.CommunityMessageDto
{
    public class MessageDto
    {
        public string? Message { get; set; }
        public bool IsGroup { get; set; }
    }
}
