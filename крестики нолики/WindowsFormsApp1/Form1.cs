using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmTicTacToe : Form
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer = 'X';
        private int moveCount = 0;
        private int xWins = 0;
        private int oWins = 0;
        private int draws = 0;
        private Panel victoryPanel;
        private Label victoryLabel;
        private Button restartButton;


        public FrmTicTacToe()
        {
            InitializeComponent();
            InitializeGame();
            UpdateScoreLabels(); // Инициализируем отображение счетчиков
            InitializeVictoryPanel(); // Инициализируем панель победы

        }



        private void InitializeGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            moveCount = 0;
            currentPlayer = 'X';
        }

        // Метод для обновления лейблов со счетом
        private void UpdateScoreLabels()
        {
            labelPlayerXScore.Text = $"X: {xWins}";
            labelPlayerOScore.Text = $"O: {oWins}";
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            string[] coordinates = panel.Name.Replace("panelCell", "").Split('_');
            int row = int.Parse(coordinates[0]);
            int col = int.Parse(coordinates[1]);

            if (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                moveCount++;
                panel.Invalidate();

                if (CheckWin(currentPlayer))
                {
                    if (currentPlayer == 'X') xWins++;
                    else oWins++;

                    UpdateScoreLabels(); // Обновляем счетчики
                    ShowWinMessage(currentPlayer);
                    DisableAllPanels();
                    return;
                }

                if (moveCount == 9)
                {
                    draws++;
                    ShowDrawMessage();
                    return;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }

        private void ShowWinMessage(char winner)
        {
            victoryLabel.Text = $"Игрок {winner} победил!";
            victoryPanel.BackColor = winner == 'X'
                ? Color.FromArgb(180, 0, 0, 150) // Синий для X
                : Color.FromArgb(180, 150, 0, 0); // Красный для O

            victoryPanel.Visible = true;
            victoryPanel.BringToFront();
        }

        private void ShowDrawMessage()
        {
            victoryLabel.Text = "Ничья!";
            victoryPanel.BackColor = Color.FromArgb(180, 100, 100, 100); // Серый для ничьи
            victoryPanel.Visible = true;
            victoryPanel.BringToFront();
        }

        // Остальные методы остаются без изменений
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            string[] coordinates = panel.Name.Replace("panelCell", "").Split('_');
            int row = int.Parse(coordinates[0]);
            int col = int.Parse(coordinates[1]);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (board[row, col] == 'X')
            {
                DrawX(g, panel);
            }
            else if (board[row, col] == 'O')
            {
                DrawO(g, panel);
            }
        }

        private void DrawX(Graphics g, Panel panel)
        {
            Pen pen = new Pen(Color.Blue, 5);
            int padding = 15;
            g.DrawLine(pen, padding, padding, panel.Width - padding, panel.Height - padding);
            g.DrawLine(pen, panel.Width - padding, padding, padding, panel.Height - padding);
        }

        private void DrawO(Graphics g, Panel panel)
        {
            Pen pen = new Pen(Color.Red, 5);
            int padding = 15;
            g.DrawEllipse(pen, padding, padding, panel.Width - 2 * padding, panel.Height - 2 * padding);
        }

        private bool CheckWin(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    return true;
            }

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
                    return true;
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true;

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                return true;

            return false;
        }

        private void DisableAllPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control.Name.StartsWith("panelCell"))
                {
                    control.Enabled = false;
                }
            }
        }

        private void panelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelReset_Click(object sender, EventArgs e)
        {
            InitializeGame();
            EnableAllPanels();
            RefreshAllPanels();
        }

        private void EnableAllPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control.Name.StartsWith("panelCell"))
                {
                    control.Enabled = true;
                }
            }
        }

        private void RefreshAllPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control.Name.StartsWith("panelCell"))
                {
                    control.Invalidate();
                }
            }
        }

        private void FrmTicTacToe_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel && panel.Name.StartsWith("panelCell"))
                {
                    panel.Click += Panel_Click;
                    panel.Paint += Panel_Paint;
                }
            }
        }

        // для панелим выйграша

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (victoryPanel != null)
            {
                victoryPanel.Size = this.ClientSize;
            }
        }

        private void InitializeVictoryPanel()
        {
            // Создаем панель победы (изначально невидимую)
            victoryPanel = new Panel();
            victoryPanel.Size = this.ClientSize;
            victoryPanel.BackColor = Color.FromArgb(150, 0, 0, 0); // Полупрозрачный черный
            victoryPanel.Visible = false;
            victoryPanel.BringToFront();

            // Создаем label для сообщения
            victoryLabel = new Label();
            victoryLabel.Font = new Font("Arial", 36, FontStyle.Bold);
            victoryLabel.ForeColor = Color.White;
            victoryLabel.AutoSize = false;
            victoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            victoryLabel.Dock = DockStyle.Fill;

            // Создаем кнопку рестарта
            restartButton = new Button();
            restartButton.Text = "Новая игра";
            restartButton.Font = new Font("Arial", 16, FontStyle.Bold);
            restartButton.Size = new Size(200, 60);
            restartButton.Click += (s, e) =>
            {
                victoryPanel.Visible = false;
                InitializeGame();
                EnableAllPanels();
                RefreshAllPanels();
            };

            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.RowCount = 2;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));

            layout.Controls.Add(victoryLabel, 0, 0);
            layout.Controls.Add(restartButton, 0, 1);
            layout.SetColumnSpan(victoryLabel, 1);

            // Центрируем кнопку
            restartButton.Anchor = AnchorStyles.None;

            victoryPanel.Controls.Add(layout);
            this.Controls.Add(victoryPanel);
        }

        
    }


}