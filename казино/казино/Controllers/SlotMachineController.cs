using SlotMachineMVC.Models;
using SlotMachineMVC.Views;
using System;

namespace SlotMachineMVC.Controllers
{
    public class SlotMachineController
    {
        private readonly SlotMachineModel model;
        private readonly SlotMachineView view;
        private readonly Random random = new Random();

        public SlotMachineController()
        {
            model = new SlotMachineModel();
            view = new SlotMachineView();

            model.OnSpinComplete += UpdateView;
            model.OnWin += () => view.ShowResult(true);
            model.OnLose += () => view.ShowResult(false);
            view.SpinRequested += Spin;

            view.ShowDialog();
        }

        private void Spin()
        {
            model.Spin(random);
        }

        private void UpdateView()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    view.UpdateSlot(i, j, model.Slots[i, j]);
                }
            }
        }
    }
}