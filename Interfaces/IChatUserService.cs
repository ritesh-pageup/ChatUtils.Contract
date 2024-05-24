using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Interfaces
{
    public interface IChatUserService
    {
        public Task<bool> AddAsync(long UserId);
    }
}
