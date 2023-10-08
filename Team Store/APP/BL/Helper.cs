using APP.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.BL
{
    static class Helper
    {
        public static TeamStoreContext Context { get; set; } = new TeamStoreContext();
    }
}
