using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    class MissileStock
    {
        private Stack<Missile> _stock;
        private readonly ILaunchStrategy _launchStrategy;
        public MissileStock(ILaunchStrategy Tlaunch)
        {
            _launchStrategy = Tlaunch;
            _stock = new Stack<Missile>();
        }
        public void AddMissiles(int amount) {
            for (int i = 0; i < amount; i++) {
                _stock.Push(new Missile(_launchStrategy));
            }
        }
        public List<Missile> UseMissiles(int amount)
        {
            List<Missile> missiles = new List<Missile>();
            for (int i = 0; i < amount; i++)
            {
                missiles.Add(_stock.Pop());
            }
            return missiles;
        }
        public int Count() => _stock.Count;
    }
}
