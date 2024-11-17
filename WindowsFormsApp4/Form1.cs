using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoComplete(textBox2);
        }

        

        private void AutoComplete(TextBox txt)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "Программирование в компьютерных системах",
                "Информационные системы и программирование",
                "Конструирование, моделирование и технологий швейных изделий",
                "Конструирование, моделирование и технология изделий из кожи"
            };
            txt.AutoCompleteCustomSource = source;
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             label4.Text=textBox4.Text;
        }
    }
}
