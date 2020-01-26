using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             В общем как то так
             */
        }
        private KeyEventArgs lastKey = new KeyEventArgs(Keys.D);
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lastKey.KeyCode == Keys.Control)
            {
                Application.Exit();
                Close();
                MessageBox.Show("close");
                return;
            }
            if (e.Button== MouseButtons.Left)
            {
                MessageBox.Show("Inside");
            }
            if (e.Button == MouseButtons.Left&&lastKey.KeyCode == Keys.Control)
            {
                Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"X:{this.Width}|Y:{this.Height}";
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            /*хз почему не работает*/
            if (e.Button == MouseButtons.Left && lastKey.KeyCode == Keys.Control)
            {
                Application.Exit();
                Close();
                MessageBox.Show("close");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Outside");
            }
            
            if (e.Button == MouseButtons.Right)
            {
                Text = $"X:{this.Width}|Y:{this.Height}";
            }
            base.OnMouseDown(e);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lastKey = e;
        }

        private void Btn_KeyDown(object sender, KeyEventArgs e)
        {
            lastKey = e;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"Mouse : X:{e.X}|Y:{e.Y}";
        }
    }
}
