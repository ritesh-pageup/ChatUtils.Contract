﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Dtos
{
    public class ChatUserDto
    {
        public long UserId { get; set; }
        public string? Name { get; set; }
    }
}