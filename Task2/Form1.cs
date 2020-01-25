using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Play()) ;
        }

        private bool Play()
        {
            int counter = 0;
            Random r = new Random();
            do
            {
                counter++;
            } while (MessageBox.Show($"You value is : {r.Next(1,2000)}", "Maybe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes);
            return MessageBox.Show($"I need {counter} times; Play again?", "Again?", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes;
        }

    }
}
