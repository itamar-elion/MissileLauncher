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
        public void AddMissile() => _stock.Push(new Missile(_launchStrategy));
        public void AddMissiles(int amount) {
            for (int i = 0; i < amount; i++) {
                AddMissile();
            }
        }
        public Missile UseMissile() {
            if (_stock.Count > 0)
            {
                return _stock.Pop();
            }
            throw new InvalidOperationException();
        }
        public List<Missile> UseMissiles(int amount)
        {
            if (_stock.Count < amount) throw new InvalidOperationException();
            List<Missile> missiles = new List<Missile>();
            for (int i = 0; i < amount; i++)
            {
                missiles.Add(_stock.Pop());
            }
            return missiles;
        }
    }
}
