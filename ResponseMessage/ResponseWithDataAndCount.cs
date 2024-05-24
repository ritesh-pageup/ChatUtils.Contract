using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.ResponseMessage
{
    public class ResponseWithDataAndCount<T> : ResponseMsg
    {
        public List<T> IterableData { get; set; }
        public long Count { get; set; }
    }
}
