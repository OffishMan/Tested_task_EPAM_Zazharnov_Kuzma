using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPAM_tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] temp = Methods.Generate10Values();

            textBox1.Text = Methods.BuildOutputString(temp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] temp = Methods.Generate10Values();
            temp = Methods.AltSort(temp);

            textBox6.Text = Methods.BuildOutputString(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = Methods.StringToDigitsArray(textBox1.Text);

            textBox2.Text = Methods.BuildOutputString(Methods.Sort(arr));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr = Methods.StringToDigitsArray(textBox6.Text);
            int newValue = int.Parse(textBox10.Text);

            textBox8.Text = $"Данное значение {Methods.ConvertBool(Methods.IsContains(arr, newValue))}содержится в заданном массиве";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox14.Text = Methods.Singles(textBox12.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox17.Text = Methods.Factorial(int.Parse(textBox15.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox20.Text = $"Данная последовательность {Methods.ConvertBool(Methods.BracketsAnalizer(textBox19.Text))}является правильной скобочной последовательностью";
        }
    }
}
