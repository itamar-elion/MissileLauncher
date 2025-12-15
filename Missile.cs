using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    class Missile
    {
        public ILaunchStrategy LaunchStrategy { get; set; }
        public Missile(ILaunchStrategy launchStrategy) 
        {
            LaunchStrategy = launchStrategy;
        }
        public bool Launch() => LaunchStrategy.Launch();
    }
}
