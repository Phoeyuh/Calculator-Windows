using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip;

        private int rainbowIndex = 0;        //raimbow color transiction index
        private Color[] rainbowColors = {
            Color.FromArgb(255, 240, 243),
            Color.FromArgb(255, 179, 193),
            Color.FromArgb(255, 77, 109),
            Color.FromArgb(244, 132, 95),
            Color.FromArgb(247, 178, 103),
            Color.FromArgb(255, 225, 105),
            Color.FromArgb(255, 238, 50),
            Color.FromArgb(255, 255, 63),
            Color.FromArgb(238, 239, 32),
            Color.FromArgb(212, 215, 0),
            Color.FromArgb(170, 204, 0),
            Color.FromArgb(128, 185, 24),
            Color.FromArgb(43, 147, 72),
            Color.FromArgb(52, 160, 164),
            Color.FromArgb(26, 117, 159),
            Color.FromArgb(72, 202, 228),
            Color.FromArgb(144, 224, 239),
            Color.FromArgb(184, 192, 255),
            Color.FromArgb(255, 214, 255)
        };  //raimbow color palette

        private string LastInput = "";
        private string OperationSign = "";

        private bool OperationCheck = false;
        private bool DotCheck = false;

        public Form1()
        {
            InitializeComponent();
        }

        //decorations
        private void InitializeMenuStrip()
        {
            menuStrip = new MenuStrip();

            ToolStripMenuItem themeMenu = new ToolStripMenuItem("Styles");
            ToolStripMenuItem darkMenuItem = new ToolStripMenuItem("Dark");
            ToolStripMenuItem lightMenuItem = new ToolStripMenuItem("Light");
            themeMenu.DropDownItems.Add(darkMenuItem);
            themeMenu.DropDownItems.Add(lightMenuItem);

            ToolStripMenuItem ColorItems = new ToolStripMenuItem("Colors");
            ToolStripMenuItem color1 = new ToolStripMenuItem("Classic");
            ToolStripMenuItem color2 = new ToolStripMenuItem("Color 2");
            ToolStripMenuItem color3 = new ToolStripMenuItem("Color 3");
            ToolStripMenuItem color4 = new ToolStripMenuItem("Color 4");
            ToolStripMenuItem color5 = new ToolStripMenuItem("Color 5");
            ToolStripMenuItem color6 = new ToolStripMenuItem("Raimbow");
            ColorItems.DropDownItems.Add(color1);
            ColorItems.DropDownItems.Add(color2);
            ColorItems.DropDownItems.Add(color3);
            ColorItems.DropDownItems.Add(color4);
            ColorItems.DropDownItems.Add(color5);
            ColorItems.DropDownItems.Add(color6);

            menuStrip.Items.Add(themeMenu);
            menuStrip.Items.Add(ColorItems);

            darkMenuItem.Click += DarkMenuItem_Click;
            lightMenuItem.Click += LightMenuItem_Click;
            color1.Click += ColorMenuItem_Click;
            color2.Click += ColorMenuItem_Click;
            color3.Click += ColorMenuItem_Click;
            color4.Click += ColorMenuItem_Click;
            color5.Click += ColorMenuItem_Click;
            color6.Click += ColorMenuItem_Click;

            Controls.Add(menuStrip);
        }
        //dark and light form color style
        private void DarkMenuItem_Click(object sender, EventArgs e)
        {
            //main bg color
            BackColor = Color.FromArgb(30, 33, 36);
            //buttons
            foreach (Control control in Controls)
            {
                if ((control is Button) && control.Name != "Cbutton" && control.Name != "CEbutton"
                    && control.Name != "div" && control.Name != "molt" && control.Name != "sub" && control.Name != "add"
                    && control.Name != "MainInput" && control.Name != "equal" && control.Name != "History"
                    && control.Name != "canc" && control.Name != "rad" && control.Name != "exp2" && control.Name != "exp3")
                {
                    control.BackColor = Color.FromArgb(66, 69, 73);
                    control.ForeColor = Color.FromArgb(224, 224, 224);
                }
            }
        }
        private void LightMenuItem_Click(object sender, EventArgs e)
        {
            //main bg color
            BackColor = Color.FromArgb(255, 255, 255);
            //buttons
            foreach (Control control in Controls)
            {
                if ((control is Button) && control.Name != "Cbutton" && control.Name != "CEbutton"
                    && control.Name != "div" && control.Name != "molt" && control.Name != "sub" && control.Name != "add"
                    && control.Name != "MainInput" && control.Name != "equal" && control.Name != "History"
                    && control.Name != "canc" && control.Name != "rad" && control.Name != "exp2" && control.Name != "exp3")
                {
                    control.BackColor = Color.FromArgb(240, 240, 240);
                    control.ForeColor = Color.FromArgb(41, 41, 41);
                }
            }
        }
        //side color style
        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            switch (menuItem.Text)
            {
                //fell free to add or change some of this styles
                default:
                case "Classic":
                    RaimbowTimer.Stop();
                    equal.BackColor = Color.FromArgb(114, 137, 218);
                    History.BackColor = Color.FromArgb(114, 137, 218); break;
                case "Color 2":
                    RaimbowTimer.Stop();
                    equal.BackColor = Color.FromArgb(255, 193, 0);
                    History.BackColor = Color.FromArgb(255, 193, 0); break;
                case "Color 3":
                    RaimbowTimer.Stop();
                    equal.BackColor = Color.FromArgb(255, 8, 74);
                    History.BackColor = Color.FromArgb(255, 8, 74); break;
                case "Color 4":
                    RaimbowTimer.Stop();
                    equal.BackColor = Color.FromArgb(246, 215, 176);
                    History.BackColor = Color.FromArgb(246, 215, 176); break;
                case "Color 5":
                    RaimbowTimer.Stop();
                    equal.BackColor = Color.FromArgb(173, 255, 0);
                    History.BackColor = Color.FromArgb(173, 255, 0); break;
                case "Raimbow":
                    RaimbowTimer.Start(); break;
            }
        }
        private void RaimbowTimer_Tick(object sender, EventArgs e)
        {
            if (rainbowIndex == rainbowColors.Length)
                rainbowIndex = 0;

            equal.BackColor = rainbowColors[rainbowIndex];
            History.BackColor = rainbowColors[rainbowIndex];

            rainbowIndex++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMenuStrip();
            RaimbowTimer.Stop();
        }

        //numbers
        private void n0_Click(object sender, EventArgs e)
        {
            OperationCheck = false;
            Button button = (Button)sender;
            if (button.Text == "," && DotCheck == false)
            {
                MainInput.Text += button.Text;
                DotCheck = true;
            }
            else if (button.Text != ",")
                MainInput.Text += button.Text;
        }
        //operations
        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!OperationCheck)
            {
                if (History.Text.Contains("*") || History.Text.Contains("/") || History.Text.Contains("+") || History.Text.Contains("-"))
                    button14_Click(sender, e);

                OperationSign = button.Text;
                LastInput = MainInput.Text;
                History.Text = $"{LastInput} {OperationSign} ";
                MainInput.Clear();
                OperationCheck = true;
                DotCheck = false;
            }

            if (History.Text == "")
                History.Visible = false;
            else
                History.Visible = true;
        }
        //clear buttons
        private void CEbutton_Click(object sender, EventArgs e)
        {
            MainInput.Text = "";
            History.Text = "";
            OperationSign = "";
            LastInput = "";
            OperationCheck = false;
            DotCheck = false;
            History.Visible = false;
        }
        private void Cbutton_Click(object sender, EventArgs e)
        {
            if (MainInput.Text != "")
            {
                MainInput.Clear();
                DotCheck = false;
            }
        }
        //result
        private void button14_Click(object sender, EventArgs e)
        {
            double tmp1, tmp2;
            switch (OperationSign)
            {
                case "*":
                    if (MainInput.Text == "")
                    {
                        History.Clear();
                        MainInput.Text = LastInput;
                        LastInput = "";
                        OperationSign = "";
                        OperationCheck = false;
                    }
                    else
                    {
                        double.TryParse(LastInput, out tmp1);
                        double.TryParse(MainInput.Text, out tmp2);
                        tmp1 *= tmp2;

                        MainInput.Text = Convert.ToString(tmp1);
                        History.Clear();
                    }
                    break;
                case "/":
                    if (MainInput.Text == "")
                        MainInput.Text = LastInput;
                    else
                    {
                        double.TryParse(LastInput, out tmp1);
                        double.TryParse(MainInput.Text, out tmp2);
                        tmp1 /= tmp2;

                        MainInput.Text = Convert.ToString(tmp1);
                        History.Clear();
                    }
                    break;
                case "+":
                    if (MainInput.Text == "")
                        MainInput.Text = LastInput;
                    else
                    {
                        double.TryParse(LastInput, out tmp1);
                        double.TryParse(MainInput.Text, out tmp2);
                        tmp1 += tmp2;

                        MainInput.Text = Convert.ToString(tmp1);
                        History.Clear();
                    }
                    break;
                case "-":
                    if (MainInput.Text == "")
                        MainInput.Text = LastInput;
                    else
                    {
                        double.TryParse(LastInput, out tmp1);
                        double.TryParse(MainInput.Text, out tmp2);
                        tmp1 -= tmp2;

                        MainInput.Text = Convert.ToString(tmp1);
                        History.Clear();
                    }
                    break;
            }
            History.Visible = false;
        }
        //other buttons
        private void canc_Click(object sender, EventArgs e) //[⌫]
        {
            if (MainInput.Text != "")
                MainInput.Text = MainInput.Text.Remove(MainInput.Text.Length - 1);
        }
        private void exp2_Click(object sender, EventArgs e) //[x²]
        {
            if (MainInput.Text != "")
            {
                double tmp;
                double.TryParse(MainInput.Text, out tmp);
                tmp = Math.Pow(tmp, 2);
                MainInput.Text = Convert.ToString(tmp);
            }
        }
        private void exp3_Click(object sender, EventArgs e) //[x³]
        {
            if (MainInput.Text != "")
            {
                double tmp;
                double.TryParse(MainInput.Text, out tmp);
                tmp = Math.Pow(tmp, 3);
                MainInput.Text = Convert.ToString(tmp);
            }
        }
        private void rad_Click(object sender, EventArgs e)  //[√x]
        {
            if (MainInput.Text != "")
            {
                double tmp;
                double.TryParse(MainInput.Text, out tmp);
                tmp = Math.Sqrt(tmp);
                MainInput.Text = Convert.ToString(tmp);
            }
        }
    }
}