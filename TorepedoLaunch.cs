using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    class TorepedoLaunch: ILaunchStrategy
    {
        public int SuccessRate { get; } = 100;
    }
}
