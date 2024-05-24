using ChatUtils.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos.PaginationDto
{
    public class PageDto
    {
        public bool  IsPagination { get; set; }
        public long? Index { get; set; }
        public long? Take { get; set; }
        public string? Search {  get; set; }
        public OrdersType? Orders { get; set; }
        public string? OrderBy { get; set; }
        public List<long>? UserIds { get; set; }
    }
}
