using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachineMVC.Views
{
    public class SlotMachineView : Form
    {
        private Label[,] slots = new Label[3, 3];
        public Label lblResult { get; private set; }
        public Button btnSpin { get; private set; }

        public event Action SpinRequested;

        public SlotMachineView()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Слот-машина MVC";
            this.ClientSize = new Size(300, 400);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    slots[i, j] = new Label
                    {
                        Font = new Font("Segoe UI Emoji", 30),
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Size = new Size(80, 80),
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(20 + j * 90, 20 + i * 90)
                    };
                    this.Controls.Add(slots[i, j]);
                }
            }

            btnSpin = new Button
            {
                Text = "Крутить",
                Location = new Point(100, 300),
                Size = new Size(100, 40)
            };
            btnSpin.Click += (s, e) => SpinRequested?.Invoke();
            this.Controls.Add(btnSpin);

            lblResult = new Label
            {
                Location = new Point(50, 350),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblResult);
        }

        public void UpdateSlot(int row, int col, string symbol)
        {
            slots[row, col].Text = symbol;
        }

        public void ShowResult(bool isWin)
        {
            lblResult.Text = isWin ? "Победа!" : "Попробуйте снова!";
            lblResult.ForeColor = isWin ? Color.Green : Color.Red;
        }
    }
}