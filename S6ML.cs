using MenuBuilder.BLL.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMissile
{
    class S6ML
    {
        private static Menu _mainMenu = Menu.MainMenu("Shayetet 6 Missile Launcher");
        public S6ML()
        {
            _mainMenu.SubMenu("Add Missiles");
            _mainMenu.SubMenu("Launch Missiles");
            _mainMenu.SubMenu("Add Missiles");
        }
    }
}
