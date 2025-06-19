namespace WindowsFormsApp1
{
    partial class FrmTicTacToe
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCell0_0 = new System.Windows.Forms.Panel();
            this.panelCell0_1 = new System.Windows.Forms.Panel();
            this.panelCell0_2 = new System.Windows.Forms.Panel();
            this.panelCell1_0 = new System.Windows.Forms.Panel();
            this.panelCell1_1 = new System.Windows.Forms.Panel();
            this.panelCell1_2 = new System.Windows.Forms.Panel();
            this.panelCell2_0 = new System.Windows.Forms.Panel();
            this.panelCell2_1 = new System.Windows.Forms.Panel();
            this.panelCell2_2 = new System.Windows.Forms.Panel();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayerOScore = new System.Windows.Forms.Label();
            this.panelCloseButton = new System.Windows.Forms.Button();
            this.panelReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayerXScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelCell0_0
            // 
            this.panelCell0_0.BackColor = System.Drawing.Color.Silver;
            this.panelCell0_0.Location = new System.Drawing.Point(12, 12);
            this.panelCell0_0.Name = "panelCell0_0";
            this.panelCell0_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_0.TabIndex = 0;
            // 
            // panelCell0_1
            // 
            this.panelCell0_1.BackColor = System.Drawing.Color.Silver;
            this.panelCell0_1.Location = new System.Drawing.Point(117, 12);
            this.panelCell0_1.Name = "panelCell0_1";
            this.panelCell0_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_1.TabIndex = 1;
            // 
            // panelCell0_2
            // 
            this.panelCell0_2.BackColor = System.Drawing.Color.Silver;
            this.panelCell0_2.Location = new System.Drawing.Point(222, 12);
            this.panelCell0_2.Name = "panelCell0_2";
            this.panelCell0_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_2.TabIndex = 1;
            // 
            // panelCell1_0
            // 
            this.panelCell1_0.AutoSize = true;
            this.panelCell1_0.BackColor = System.Drawing.Color.Silver;
            this.panelCell1_0.Location = new System.Drawing.Point(12, 114);
            this.panelCell1_0.Name = "panelCell1_0";
            this.panelCell1_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_0.TabIndex = 1;
            // 
            // panelCell1_1
            // 
            this.panelCell1_1.BackColor = System.Drawing.Color.Silver;
            this.panelCell1_1.Location = new System.Drawing.Point(117, 114);
            this.panelCell1_1.Name = "panelCell1_1";
            this.panelCell1_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_1.TabIndex = 1;
            // 
            // panelCell1_2
            // 
            this.panelCell1_2.BackColor = System.Drawing.Color.Silver;
            this.panelCell1_2.Location = new System.Drawing.Point(222, 114);
            this.panelCell1_2.Name = "panelCell1_2";
            this.panelCell1_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_2.TabIndex = 1;
            // 
            // panelCell2_0
            // 
            this.panelCell2_0.BackColor = System.Drawing.Color.Silver;
            this.panelCell2_0.Location = new System.Drawing.Point(12, 216);
            this.panelCell2_0.Name = "panelCell2_0";
            this.panelCell2_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_0.TabIndex = 1;
            // 
            // panelCell2_1
            // 
            this.panelCell2_1.BackColor = System.Drawing.Color.Silver;
            this.panelCell2_1.Location = new System.Drawing.Point(117, 216);
            this.panelCell2_1.Name = "panelCell2_1";
            this.panelCell2_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_1.TabIndex = 1;
            // 
            // panelCell2_2
            // 
            this.panelCell2_2.BackColor = System.Drawing.Color.Silver;
            this.panelCell2_2.Location = new System.Drawing.Point(222, 216);
            this.panelCell2_2.Name = "panelCell2_2";
            this.panelCell2_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_2.TabIndex = 1;
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.labelPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.labelPlayer1Name.Location = new System.Drawing.Point(322, 81);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(82, 30);
            this.labelPlayer1Name.TabIndex = 3;
            this.labelPlayer1Name.Text = "Игрок:";
            // 
            // labelPlayerOScore
            // 
            this.labelPlayerOScore.AutoSize = true;
            this.labelPlayerOScore.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.labelPlayerOScore.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayerOScore.Location = new System.Drawing.Point(399, 83);
            this.labelPlayerOScore.Name = "labelPlayerOScore";
            this.labelPlayerOScore.Size = new System.Drawing.Size(27, 30);
            this.labelPlayerOScore.TabIndex = 5;
            this.labelPlayerOScore.Text = "0";
            // 
            // panelCloseButton
            // 
            this.panelCloseButton.BackColor = System.Drawing.Color.Red;
            this.panelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.panelCloseButton.ForeColor = System.Drawing.Color.White;
            this.panelCloseButton.Location = new System.Drawing.Point(398, 9);
            this.panelCloseButton.Name = "panelCloseButton";
            this.panelCloseButton.Size = new System.Drawing.Size(52, 42);
            this.panelCloseButton.TabIndex = 11;
            this.panelCloseButton.Text = "X";
            this.panelCloseButton.UseVisualStyleBackColor = false;
            this.panelCloseButton.Click += new System.EventHandler(this.panelCloseButton_Click);
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.Color.Black;
            this.panelReset.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.panelReset.ForeColor = System.Drawing.Color.White;
            this.panelReset.Location = new System.Drawing.Point(327, 12);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(61, 38);
            this.panelReset.TabIndex = 12;
            this.panelReset.Text = "Сброс";
            this.panelReset.UseVisualStyleBackColor = false;
            this.panelReset.Click += new System.EventHandler(this.panelReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Игрок:";
            // 
            // labelPlayerXScore
            // 
            this.labelPlayerXScore.AutoSize = true;
            this.labelPlayerXScore.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.labelPlayerXScore.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayerXScore.Location = new System.Drawing.Point(400, 114);
            this.labelPlayerXScore.Name = "labelPlayerXScore";
            this.labelPlayerXScore.Size = new System.Drawing.Size(27, 30);
            this.labelPlayerXScore.TabIndex = 14;
            this.labelPlayerXScore.Text = "0";
            // 
            // FrmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(464, 326);
            this.Controls.Add(this.labelPlayerXScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.panelCloseButton);
            this.Controls.Add(this.labelPlayerOScore);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.panelCell2_2);
            this.Controls.Add(this.panelCell2_1);
            this.Controls.Add(this.panelCell2_0);
            this.Controls.Add(this.panelCell1_2);
            this.Controls.Add(this.panelCell1_1);
            this.Controls.Add(this.panelCell1_0);
            this.Controls.Add(this.panelCell0_2);
            this.Controls.Add(this.panelCell0_1);
            this.Controls.Add(this.panelCell0_0);
            this.Font = new System.Drawing.Font("AmdtSymbols", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "FrmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FrmTicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCell0_0;
        private System.Windows.Forms.Panel panelCell0_1;
        private System.Windows.Forms.Panel panelCell0_2;
        private System.Windows.Forms.Panel panelCell1_0;
        private System.Windows.Forms.Panel panelCell1_1;
        private System.Windows.Forms.Panel panelCell1_2;
        private System.Windows.Forms.Panel panelCell2_0;
        private System.Windows.Forms.Panel panelCell2_1;
        private System.Windows.Forms.Panel panelCell2_2;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayerOScore;
        private System.Windows.Forms.Button panelCloseButton;
        private System.Windows.Forms.Button panelReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayerXScore;
    }
}

