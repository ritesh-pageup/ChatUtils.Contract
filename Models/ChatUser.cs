using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Models
{
    public class ChatUser
    {
        public long Id { get; set; }   
        public long UserId { get; set; }
        public List<long>? GroupIds { get; set; }
        public string? RecentChat { get; set; }
        public bool? IsGroup { get; set; }
        public string? FirebaseToken { get; set; }
    }
}
