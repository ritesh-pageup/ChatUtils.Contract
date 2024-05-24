using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.PaginationDto
{
    public class MessagePageDto
    {
        public bool IsPagination { get; set; }
        public long? Index { get; set; }
        public long? Take { get; set; }
        public string? Search { get; set; }
    }
}
