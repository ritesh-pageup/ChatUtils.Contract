using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.PaginationDto
{
    public class MultipleOperationDto
    {
        public List<int> Ids { get; set; }
        public int RecieverId { get; set; }
        public bool IsGroup { get; set; }
        public bool DeleteForEveryone { get; set; }
    }
}
