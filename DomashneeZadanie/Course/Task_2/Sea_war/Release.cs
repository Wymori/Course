
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DomashneeZadanie.Course.Task_2.Sea_war
{
    internal class Release
    {
        Field _seaWar = new Field();

        public void Game()
        {
            for (int i = 0; i <= 9; i++)
            {
                _seaWar.Control_Input();
                _seaWar.Update();
                _seaWar.OutPut();
                Console.WriteLine("===================");
            }
        }
    }
}
