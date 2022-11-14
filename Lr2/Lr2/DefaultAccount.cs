using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class DefaultAccount : GameAccount
    {
        public DefaultAccount(string UserName) : base(UserName: UserName)
        {
            this.UserName = UserName;
        }

    }
}
