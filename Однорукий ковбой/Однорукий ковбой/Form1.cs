using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace Однорукий_ковбой
{
    public partial class Form1 : Form
    {
        private GameController controller;

        public Form1()
        {
            InitializeComponent();
            this.controller = new GameController(this);
        }

        public void SetController(GameController controller)
        {
            this.controller = controller;
        }

        public void UpdateSlots(int[] slots)
        {
            // Загружаем картинки в PictureBox
            pictureBox1.Image = GetImageByNumber(slots[0]);
            pictureBox2.Image = GetImageByNumber(slots[1]);
            pictureBox3.Image = GetImageByNumber(slots[2]);
        }

        public void ShowResult(string message)
        {
            label1.Text = message;
            
        }

        private Image GetImageByNumber(int number)
        {
            byte[] imageData;
            switch (number)
            {
                case 0: imageData = Properties.Resources.Cherry; break;
                case 1: imageData = Properties.Resources.Lemon; break;
                case 2: imageData = Properties.Resources.Seven; break;
                default: return null;
            }

            // Конвертируем byte[] в Image
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Spin();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
