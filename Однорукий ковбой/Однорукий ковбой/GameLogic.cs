using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Однорукий_ковбой
{
    public class GameLogic
    {
        private Random random = new Random();
        private int[] currentSlots = new int[3]; // 0 - вишня, 1 - лимон, 2 - семёрка

        public void Spin()
        {
            for (int i = 0; i < 3; i++)
            {
                currentSlots[i] = random.Next(0, 3); //  (0, 1, 2)
            }
        }

        public bool CheckWin()
        {
            // Проверяем, все ли три числа одинаковые
            return currentSlots[0] == currentSlots[1] && currentSlots[1] == currentSlots[2];
        }

        public int[] GetCurrentSlots()
        {
            return currentSlots;
        }
    }
}
