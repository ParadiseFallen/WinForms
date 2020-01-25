using System.Windows.Forms;

namespace Task1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Task1";
            string a = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet pharetra facilisis. Fusce eget diam orci. Pellentesque sed nisi eu augue ullamcorper scelerisque. Nulla eget dui molestie, vulputate tortor sed, dictum libero. Aliquam a leo massa. Nunc malesuada sagittis dapibus. Duis ligula massa, tristique sit amet mi ut, sodales rutrum massa. Fusce blandit elementum commodo. Aliquam et ante eget lacus pharetra condimentum. Phasellus id purus quis enim consequat dignissim. Nunc maximus leo lorem, a convallis elit sagittis vehicula. Aliquam nec quam hendrerit, euismod tellus vitae, semper enim. Suspendisse maximus fermentum orci, ut aliquam diam vehicula sed.";
            string b = "Quisque laoreet, nibh vel scelerisque blandit, purus ipsum sodales libero, a gravida ipsum lacus vitae nibh. Nam eleifend eros sed velit pellentesque, in suscipit nisl maximus. Phasellus rhoncus semper vehicula. Praesent eget porta diam, quis condimentum dolor. Phasellus tempus augue id velit eleifend, ut gravida lorem viverra. Aliquam a vulputate lacus. In fermentum ante in nulla sagittis, sed condimentum metus fringilla. Ut in lectus magna.";
            string c = "Praesent ac enim purus. In sollicitudin arcu nec quam finibus, sed tempus nulla iaculis. Nam placerat ante quis tellus molestie gravida. Duis efficitur lectus nec eros lobortis semper. Mauris posuere commodo est, id consequat felis condimentum ut. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Ut dictum tortor ac purus dictum, vitae gravida diam fringilla. Maecenas posuere sollicitudin porttitor. Duis ornare leo quis lorem commodo, at feugiat mi varius. Praesent dapibus ac sem sit amet consectetur.";
            MessageBox.Show($"Краткое резюме: {a}", $"MassageBox1|Simbols on page : {a.Length}|Total : {a.Length}|Avg : {a.Length}");
            MessageBox.Show($"Краткое резюме: {b}", $"MassageBox1 | Simbols on page: { b.Length}|Total : {a.Length+b.Length}|Avg : {(a.Length+b.Length)/2}");
            MessageBox.Show($"Краткое резюме: {c}", $"MassageBox1 | Simbols on page: { c.Length}|Total : {a.Length+b.Length+c.Length}|Avg : {(a.Length+b.Length+c.Length)/3}");
            //Какая разница резюме там или вот это? все равно суть задачи вывести 3 MessageBoxa
        }

        #endregion
    }
}

