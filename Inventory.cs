using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    class Inventory
    {
        private Dictionary<string, MissileStock> _items;
        private Dictionary<string, ILaunchStrategy> _launchStrategies = new();
        public Inventory()
        {
            _items = new Dictionary<string, MissileStock>();
            _launchStrategies.Add("Balistic", new BalisticLaunch());
            _launchStrategies.Add("Torpedo", new TorepedoLaunch());
            _launchStrategies.Add("Cruise", new CruiseLaunch());
        }
        public void AddMissiles(string launchStrategy, int amount = 1)
        {
            if (!_launchStrategies.ContainsKey(launchStrategy))
            {
                throw new InvalidOperationException($"No Such Strategy {launchStrategy}.");
            }
            if (!_items.ContainsKey(launchStrategy))
            {
                _items.Add(launchStrategy, new MissileStock(_launchStrategies[launchStrategy]));
            }
                _items[launchStrategy].AddMissiles(amount);
        }
        public List<Missile> LaunchMissiles(string launchStrategy, int amount = 1)
        {
            if (!_launchStrategies.ContainsKey(launchStrategy))
            {
                throw new InvalidOperationException($"No Such Strategy: {launchStrategy}.");
            }
            if (!_items.ContainsKey(launchStrategy) || _items[launchStrategy].Count() < amount)
            {
                throw new InvalidOperationException($"Not Enough {launchStrategy} Missiles, requested: {amount}" +
                    $" but there are only {_items[launchStrategy].Count()}.");
            }
            return _items[launchStrategy].UseMissiles(amount);
        }
        public void CleanUp()
        {
            _items.Clear();
        }
        public string Report()
        {
            string result = string.Empty;
            foreach ((string missileType, MissileStock missileStock) in _items)
            {
                result += $"{missileStock.Count()} {missileType} Missiles";
            }
        }
    }
}
