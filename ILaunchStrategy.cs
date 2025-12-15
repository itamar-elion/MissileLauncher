using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    public interface ILaunchStrategy
    {
        public int SuccessRate { get; }
        public bool Launch()
        {
            return (new Random().Next() % 100 > SuccessRate);
        }
    }
}
