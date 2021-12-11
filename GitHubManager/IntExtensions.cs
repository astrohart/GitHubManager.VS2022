using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubManager
{
    public static class IntExtensions
    {
        public static bool IsBitmaskOn(this int num, int bitmask) {
            return (num & bitmask) != 0;
        }
    }
}
