﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.ResponseMessage
{
    public class ResponseWIthEterableMessage<T>:ResponseMsg
    {
        public List<T>? IterableData { get; set; }
    }
}
