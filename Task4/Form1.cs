using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private Point Start;
        private int number = 0;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Start.X = e.X;
            Start.Y = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            var sizeX = Math.Abs(e.X - Start.X);
            var sizeY = Math.Abs(e.Y - Start.Y);
            if (sizeX < 10 || sizeY < 10)
            { 
                MessageBox.Show("TooSmall","Alert!");
                return;
            }
            var t = new Label() { Text = $"{number++}",
                Left = Start.X<e.X?Start.X:e.X
                ,Top = Start.Y<e.Y?Start.Y:e.Y
                ,Width = Start.X > e.X ? Start.X- e.X  : e.X-Start.X                
                ,Height = Start.Y > e.Y ?  Start.Y - e.Y : e.Y - Start.Y
                ,BackColor = Color.Aqua
            };

            t.MouseDown += (s, a) => {
                if (a.Button != MouseButtons.Right)
                    return;
                int maxN=0;

                List<Label> temp = new List<Label>();
                GetLabels().ForEach(i => {
                    /*if (new Rectangle(i.Location.X, i.Location.Y, i.Width,i.Height).Contains(e.Location))
                        temp.Add(i);*/
                    if (i.ClientRectangle.Contains(a.Location))
                        temp.Add(i);
                });
                foreach (var item in temp)
                {
                    if (int.Parse(item.Text) > maxN)
                        maxN = int.Parse(item.Text);
                }
                Label l = GetLabels().Where(i=> i.Text== maxN.ToString()).ElementAt<Label>(0);
                this.Text = $"S:{l.Width*l.Height}|X:{l.Left}|Y:{l.Top}";
            };
            t.MouseDoubleClick += (s, a) => {
                if (a.Button != MouseButtons.Left)
                    return;
                int minN = number;

                var temp = new List<Label>();
                GetLabels().ForEach(i => {
                    Console.WriteLine($"{new Rectangle(i.Left, i.Top, i.Left + i.Width, i.Top + i.Height)} {i.Left + a.X} {i.Top + a.Y} ");
                    Console.WriteLine($"{new Rectangle(i.Left, i.Top, i.Left + i.Width, i.Top + i.Height).Contains(i.Left + a.X, i.Top + a.Y)}");
                    if (new Rectangle(i.Left, i.Top, i.Left + i.Width, i.Top + i.Height).Contains(i.Left + a.X, i.Top + a.Y))
                        temp.Add(i);
                });
                foreach (var item in temp)
                {
                    Console.WriteLine($"{int.Parse(item.Text)}   {minN} ");
                    if (int.Parse(item.Text) < minN)
                    {
                        minN = int.Parse(item.Text);
                    }
                }
                Label l = GetLabels().Where(i => i.Text == minN.ToString())?.ElementAt<Label>(0);
                Controls.Remove(l);
            };

            Controls.Add(t);
        }

        private List<Label> GetLabels() {
            List<Label> t = new List<Label>();
            foreach (var item in Controls)
            {
                if (item is Label)
                    t.Add(item as Label);
            }
            return t;
        }
    }
}
