﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.ResponseMessage
{
    public class ResponseWithObjectMessage<T> : ResponseMsg
    {
        public T Data { get; set; }
    }
}
