using System;

namespace SlotMachineMVC.Models
{
    public class SlotMachineModel
    {
        public string[,] Slots { get; private set; } = new string[3, 3];
        public string[] Symbols { get; } = { "🍒", "🍋", "🍊", "7", "💰" };

        public event Action OnSpinComplete;
        public event Action OnWin;
        public event Action OnLose;

        public void Spin(Random random)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Slots[i, j] = Symbols[random.Next(Symbols.Length)];
                }
            }

            OnSpinComplete?.Invoke();

            if (Slots[1, 0] == Slots[1, 1] && Slots[1, 1] == Slots[1, 2])
                OnWin?.Invoke();
            else
                OnLose?.Invoke();
        }
    }
}