using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Однорукий_ковбой
{
    public class GameController
    {
        private GameLogic model;
        private Form1 view;

        public GameController(Form1 form)
        {
            model = new GameLogic();
            view = form;
            view.SetController(this);
        }

        public void Spin()
        {
            model.Spin();
            int[] slots = model.GetCurrentSlots();
            view.UpdateSlots(slots);

            if (model.CheckWin())
            {
                view.ShowResult("Вы выиграли!");
            }
            else
            {
                view.ShowResult("Повезёт в следующий раз!");
            }
        }
    }
}
