using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.BLL;
using MenuBuilder;

namespace LaunchMissile
{
    class MissileManager
    {
        private MenuBuilder.Common.Dialog
        private readonly Inventory _inventory = new();
        private void StoreMissiles(string);
        {
            
            _inventory.AddMissiles();
        }
//store(string, int) void
        private static List<bool> LaunchMissiles(List<Missile> missiles)
        {
            List<bool> result = new();
            foreach (Missile missile in missiles)
            {
                result.Add(missile.Launch());
            }
            return result;
        }
//LaunchMissiles(string, int): List<bool>
        public string reportInventory()
        {
            Inventory.Report();
        }
        public void CleanUp()
        {
            _inventory.CleanUp();
        }
    }
}
