namespace WindowsCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            History = new RichTextBox();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            div = new Button();
            Cbutton = new Button();
            CEbutton = new Button();
            molt = new Button();
            n6 = new Button();
            n5 = new Button();
            n4 = new Button();
            sub = new Button();
            n3 = new Button();
            n2 = new Button();
            n1 = new Button();
            add = new Button();
            equal = new Button();
            dot = new Button();
            n0 = new Button();
            RaimbowTimer = new System.Windows.Forms.Timer(components);
            MainInput = new TextBox();
            rad = new Button();
            canc = new Button();
            exp3 = new Button();
            exp2 = new Button();
            SuspendLayout();
            // 
            // History
            // 
            History.BackColor = Color.FromArgb(114, 137, 218);
            History.BorderStyle = BorderStyle.None;
            History.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = Color.FromArgb(224, 224, 224);
            History.Location = new Point(10, 35);
            History.Multiline = false;
            History.Name = "History";
            History.ReadOnly = true;
            History.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            History.Size = new Size(118, 25);
            History.TabIndex = 0;
            History.Text = "";
            History.Visible = false;
            // 
            // n7
            // 
            n7.BackColor = Color.FromArgb(66, 69, 73);
            n7.FlatStyle = FlatStyle.Popup;
            n7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n7.ForeColor = Color.FromArgb(224, 224, 224);
            n7.Location = new Point(10, 120);
            n7.Name = "n7";
            n7.Size = new Size(50, 50);
            n7.TabIndex = 2;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n0_Click;
            // 
            // n8
            // 
            n8.BackColor = Color.FromArgb(66, 69, 73);
            n8.FlatStyle = FlatStyle.Popup;
            n8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n8.ForeColor = Color.FromArgb(224, 224, 224);
            n8.Location = new Point(66, 120);
            n8.Name = "n8";
            n8.Size = new Size(50, 50);
            n8.TabIndex = 3;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n0_Click;
            // 
            // n9
            // 
            n9.BackColor = Color.FromArgb(66, 69, 73);
            n9.FlatStyle = FlatStyle.Popup;
            n9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n9.ForeColor = Color.FromArgb(224, 224, 224);
            n9.Location = new Point(122, 120);
            n9.Name = "n9";
            n9.Size = new Size(50, 50);
            n9.TabIndex = 4;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n0_Click;
            // 
            // div
            // 
            div.BackColor = Color.FromArgb(224, 224, 224);
            div.FlatStyle = FlatStyle.Popup;
            div.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            div.Location = new Point(178, 120);
            div.Name = "div";
            div.Size = new Size(50, 50);
            div.TabIndex = 5;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += operation_Click;
            // 
            // Cbutton
            // 
            Cbutton.BackColor = Color.FromArgb(224, 224, 224);
            Cbutton.FlatStyle = FlatStyle.Popup;
            Cbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cbutton.Location = new Point(234, 120);
            Cbutton.Name = "Cbutton";
            Cbutton.Size = new Size(50, 50);
            Cbutton.TabIndex = 6;
            Cbutton.Text = "C";
            Cbutton.UseVisualStyleBackColor = false;
            Cbutton.Click += Cbutton_Click;
            // 
            // CEbutton
            // 
            CEbutton.BackColor = Color.FromArgb(224, 224, 224);
            CEbutton.FlatStyle = FlatStyle.Popup;
            CEbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CEbutton.Location = new Point(234, 176);
            CEbutton.Name = "CEbutton";
            CEbutton.Size = new Size(50, 50);
            CEbutton.TabIndex = 11;
            CEbutton.Text = "CE";
            CEbutton.UseVisualStyleBackColor = false;
            CEbutton.Click += CEbutton_Click;
            // 
            // molt
            // 
            molt.BackColor = Color.FromArgb(224, 224, 224);
            molt.FlatStyle = FlatStyle.Popup;
            molt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            molt.Location = new Point(178, 176);
            molt.Name = "molt";
            molt.Size = new Size(50, 50);
            molt.TabIndex = 10;
            molt.Text = "*";
            molt.UseVisualStyleBackColor = false;
            molt.Click += operation_Click;
            // 
            // n6
            // 
            n6.BackColor = Color.FromArgb(66, 69, 73);
            n6.FlatStyle = FlatStyle.Popup;
            n6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n6.ForeColor = Color.FromArgb(224, 224, 224);
            n6.Location = new Point(122, 176);
            n6.Name = "n6";
            n6.Size = new Size(50, 50);
            n6.TabIndex = 9;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n0_Click;
            // 
            // n5
            // 
            n5.BackColor = Color.FromArgb(66, 69, 73);
            n5.FlatStyle = FlatStyle.Popup;
            n5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n5.ForeColor = Color.FromArgb(224, 224, 224);
            n5.Location = new Point(66, 176);
            n5.Name = "n5";
            n5.Size = new Size(50, 50);
            n5.TabIndex = 8;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n0_Click;
            // 
            // n4
            // 
            n4.BackColor = Color.FromArgb(66, 69, 73);
            n4.FlatStyle = FlatStyle.Popup;
            n4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n4.ForeColor = Color.FromArgb(224, 224, 224);
            n4.Location = new Point(10, 176);
            n4.Name = "n4";
            n4.Size = new Size(50, 50);
            n4.TabIndex = 7;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n0_Click;
            // 
            // sub
            // 
            sub.BackColor = Color.FromArgb(224, 224, 224);
            sub.FlatStyle = FlatStyle.Popup;
            sub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sub.Location = new Point(178, 232);
            sub.Name = "sub";
            sub.Size = new Size(50, 50);
            sub.TabIndex = 15;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += operation_Click;
            // 
            // n3
            // 
            n3.BackColor = Color.FromArgb(66, 69, 73);
            n3.FlatStyle = FlatStyle.Popup;
            n3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n3.ForeColor = Color.FromArgb(224, 224, 224);
            n3.Location = new Point(122, 232);
            n3.Name = "n3";
            n3.Size = new Size(50, 50);
            n3.TabIndex = 14;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n0_Click;
            // 
            // n2
            // 
            n2.BackColor = Color.FromArgb(66, 69, 73);
            n2.FlatStyle = FlatStyle.Popup;
            n2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n2.ForeColor = Color.FromArgb(224, 224, 224);
            n2.Location = new Point(66, 232);
            n2.Name = "n2";
            n2.Size = new Size(50, 50);
            n2.TabIndex = 13;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n0_Click;
            // 
            // n1
            // 
            n1.BackColor = Color.FromArgb(66, 69, 73);
            n1.FlatStyle = FlatStyle.Popup;
            n1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n1.ForeColor = Color.FromArgb(224, 224, 224);
            n1.Location = new Point(10, 232);
            n1.Name = "n1";
            n1.Size = new Size(50, 50);
            n1.TabIndex = 12;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n0_Click;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(224, 224, 224);
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add.Location = new Point(178, 288);
            add.Name = "add";
            add.Size = new Size(50, 50);
            add.TabIndex = 20;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += operation_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.FromArgb(114, 137, 218);
            equal.FlatStyle = FlatStyle.Popup;
            equal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            equal.Location = new Point(290, 232);
            equal.Name = "equal";
            equal.RightToLeft = RightToLeft.No;
            equal.Size = new Size(50, 106);
            equal.TabIndex = 21;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += button14_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.FromArgb(66, 69, 73);
            dot.FlatStyle = FlatStyle.Popup;
            dot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dot.ForeColor = Color.FromArgb(224, 224, 224);
            dot.Location = new Point(122, 288);
            dot.Name = "dot";
            dot.Size = new Size(50, 50);
            dot.TabIndex = 24;
            dot.Text = ",";
            dot.UseVisualStyleBackColor = false;
            dot.Click += n0_Click;
            // 
            // n0
            // 
            n0.BackColor = Color.FromArgb(66, 69, 73);
            n0.FlatStyle = FlatStyle.Popup;
            n0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n0.ForeColor = Color.FromArgb(224, 224, 224);
            n0.Location = new Point(10, 288);
            n0.Name = "n0";
            n0.Size = new Size(106, 50);
            n0.TabIndex = 22;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // RaimbowTimer
            // 
            RaimbowTimer.Enabled = true;
            RaimbowTimer.Interval = 1000;
            RaimbowTimer.Tick += RaimbowTimer_Tick;
            // 
            // MainInput
            // 
            MainInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            MainInput.Location = new Point(10, 66);
            MainInput.Name = "MainInput";
            MainInput.ReadOnly = true;
            MainInput.Size = new Size(330, 43);
            MainInput.TabIndex = 25;
            MainInput.TextAlign = HorizontalAlignment.Right;
            // 
            // rad
            // 
            rad.BackColor = Color.FromArgb(224, 224, 224);
            rad.FlatStyle = FlatStyle.Popup;
            rad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rad.Location = new Point(290, 176);
            rad.Name = "rad";
            rad.Size = new Size(50, 50);
            rad.TabIndex = 27;
            rad.Text = "√x";
            rad.UseVisualStyleBackColor = false;
            rad.Click += rad_Click;
            // 
            // canc
            // 
            canc.BackColor = Color.FromArgb(224, 224, 224);
            canc.FlatStyle = FlatStyle.Popup;
            canc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            canc.Location = new Point(290, 120);
            canc.Name = "canc";
            canc.Size = new Size(50, 50);
            canc.TabIndex = 26;
            canc.Text = "⌫";
            canc.UseVisualStyleBackColor = false;
            canc.Click += canc_Click;
            // 
            // exp3
            // 
            exp3.BackColor = Color.FromArgb(224, 224, 224);
            exp3.FlatStyle = FlatStyle.Popup;
            exp3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exp3.Location = new Point(234, 288);
            exp3.Name = "exp3";
            exp3.Size = new Size(50, 50);
            exp3.TabIndex = 29;
            exp3.Text = "x³";
            exp3.UseVisualStyleBackColor = false;
            exp3.Click += exp3_Click;
            // 
            // exp2
            // 
            exp2.BackColor = Color.FromArgb(224, 224, 224);
            exp2.FlatStyle = FlatStyle.Popup;
            exp2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exp2.Location = new Point(234, 232);
            exp2.Name = "exp2";
            exp2.Size = new Size(50, 50);
            exp2.TabIndex = 28;
            exp2.Text = "x²";
            exp2.UseVisualStyleBackColor = false;
            exp2.Click += exp2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 36);
            ClientSize = new Size(350, 348);
            Controls.Add(exp3);
            Controls.Add(exp2);
            Controls.Add(rad);
            Controls.Add(canc);
            Controls.Add(MainInput);
            Controls.Add(dot);
            Controls.Add(n0);
            Controls.Add(equal);
            Controls.Add(add);
            Controls.Add(sub);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(CEbutton);
            Controls.Add(molt);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(Cbutton);
            Controls.Add(div);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(History);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox History;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button div;
        private Button Cbutton;
        private Button CEbutton;
        private Button molt;
        private Button n6;
        private Button n5;
        private Button n4;
        private Button sub;
        private Button n3;
        private Button n2;
        private Button n1;
        private Button add;
        private Button equal;
        private Button dot;
        private Button n0;
        private System.Windows.Forms.Timer RaimbowTimer;
        private TextBox MainInput;
        private Button rad;
        private Button canc;
        private Button exp3;
        private Button exp2;
    }
}