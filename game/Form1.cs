using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int Index = rnd.Next(4); // Генерация случайного индекса
           
            // В зависимости от Index выбираем действие
            switch (Index)
            {
                case 0:
                    BClick.Left += BClick.Width; // Двигаем кнопку вправо
                    break;
                case 1:
                    BClick.Left -= BClick.Width; // Двигаем кнопку влево
                    break;
                case 2:
                    BClick.Top += BClick.Height; // Двигаем кнопку вниз
                    break;
                case 3:
                    BClick.Top -= BClick.Height; // Двигаем кнопку вверх
                    break;
            }

            // Проверка выхода кнопки за пределы формы
            BClick.Left = Math.Max(0, Math.Min(BClick.Left, this.ClientSize.Width - BClick.Width));
            BClick.Top = Math.Max(0, Math.Min(BClick.Top, this.ClientSize.Height - BClick.Height));
        }

     
        private void BClick_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void BClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter нажимать не честно, используй мышь");
        }
    }
}
