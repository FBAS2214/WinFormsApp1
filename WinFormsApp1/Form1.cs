using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TimerExample();
            // AddLabelDynamic();
        }



        void AddLabelDynamic()
        {
            Label label = new Label
            {
                Text = "Hakuna Matata",
                Location = new Point(90, 190),
                AutoSize = true,
                Font = new Font("Comic Sans MS", 30, FontStyle.Bold | FontStyle.Underline)
            };

            Controls.Add(label);
        }



        private void TimerExample()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            // timer.Stop();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show($"X: {e.X}   Y: {e.Y}");


            if (e.Button == MouseButtons.Left)
            {
                // BackColor = Color.DarkGoldenrod;
                // BackColor = Color.FromName("Red");
                // BackColor = Color.FromKnownColor( KnownColor.LimeGreen);
                BackColor = Color.FromArgb(207, 42, 222);
            }
            else if (e.Button == MouseButtons.Right)
            {
                BackColor = Color.Green;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }




        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "MouseEnter";
            label1.ForeColor = Color.DeepSkyBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "MouseLeave";
            label1.ForeColor = Color.Black;
        }



        bool state = true;
        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            button.Size = state
                ? new Size(300, 150)
                : new Size(200, 100);

            state = !state;
        }


        private void btn_Dispose_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Dispose();

                int btnWidth = 187;
                int btnHeight = 46;

                int x = Random.Shared.Next(0, Width - btnWidth);
                int y = Random.Shared.Next(0, Height - btnHeight);

                Button button = new Button
                {
                    AutoSize = true,
                    Text = "Dispose",
                    Size = new Size(btnWidth, btnHeight),
                    Name = "btn_Dispose",
                    Location = new Point(x, y),
                    Font = new Font("Vineta BT", 20.25F),
                };

                button.Click += btn_Dispose_Click;
                Controls.Add(button);

            }
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.hakuna;
        }


        private void button_box_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Text", "Caption",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);


            if (result == DialogResult.Yes)
                MessageBox.Show("Yes");
            else if (result == DialogResult.No)
                MessageBox.Show("No");
            else if (result == DialogResult.Cancel)
                MessageBox.Show("Cancel");

        }
    }
}