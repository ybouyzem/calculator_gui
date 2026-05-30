namespace Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Free managed and unmanaged resources when the form closes
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // All controls are declared here so Visual Studio designer can see them
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnToggleSign;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // --- Form setup ---
            this.Text = "Calculator";
            this.Size = new System.Drawing.Size(340, 520);
            this.MinimumSize = new System.Drawing.Size(340, 520);
            this.MaximumSize = new System.Drawing.Size(340, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // --- Title label ---
            lblTitle = new System.Windows.Forms.Label();
            lblTitle.Text = "CALCULATOR";
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
            lblTitle.Location = new System.Drawing.Point(12, 10);
            lblTitle.Size = new System.Drawing.Size(300, 20);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // --- Display TextBox (read-only, right-aligned) ---
            txtDisplay = new System.Windows.Forms.TextBox();
            txtDisplay.Text = "0";
            txtDisplay.ReadOnly = true;
            txtDisplay.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtDisplay.ForeColor = System.Drawing.Color.White;
            txtDisplay.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular);
            txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtDisplay.Location = new System.Drawing.Point(12, 30);
            txtDisplay.Size = new System.Drawing.Size(302, 60);
            txtDisplay.TabStop = false;

            // Reusable helper to set button appearance
            int btnW = 70, btnH = 70, gap = 5;
            int startX = 12, startY = 110;

            // --- Row 0: top utility buttons (small, gray) ---
            // Backspace
            btnBackspace = MakeButton("⌫", startX, startY - 55, 70, 40,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.White, 14);
            btnBackspace.Click += btnBackspace_Click;

            // Sqrt
            btnSqrt = MakeButton("√", startX + btnW + gap, startY - 55, 70, 40,
                System.Drawing.Color.FromArgb(80, 80, 80), System.Drawing.Color.White, 14);
            btnSqrt.Click += btnSqrt_Click;

            // --- Row 1: C, +/-, %, / ---
            btnClear = MakeButton("C", startX, startY, btnW, btnH,
                System.Drawing.Color.FromArgb(90, 90, 90), System.Drawing.Color.White, 18);
            btnClear.Click += btnClear_Click;

            btnToggleSign = MakeButton("+/-", startX + (btnW + gap), startY, btnW, btnH,
                System.Drawing.Color.FromArgb(90, 90, 90), System.Drawing.Color.White, 18);
            btnToggleSign.Click += btnToggleSign_Click;

            btnPercent = MakeButton("%", startX + 2 * (btnW + gap), startY, btnW, btnH,
                System.Drawing.Color.FromArgb(90, 90, 90), System.Drawing.Color.White, 18);
            btnPercent.Click += btnPercent_Click;

            btnDivide = MakeButton("÷", startX + 3 * (btnW + gap), startY, btnW, btnH,
                System.Drawing.Color.FromArgb(255, 149, 0), System.Drawing.Color.White, 22);
            btnDivide.Text = "/";
            btnDivide.Click += OperatorButton_Click;

            // --- Row 2: 7, 8, 9, × ---
            btn7 = MakeButton("7", startX, startY + (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn7.Click += DigitButton_Click;

            btn8 = MakeButton("8", startX + (btnW + gap), startY + (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn8.Click += DigitButton_Click;

            btn9 = MakeButton("9", startX + 2 * (btnW + gap), startY + (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn9.Click += DigitButton_Click;

            btnMultiply = MakeButton("×", startX + 3 * (btnW + gap), startY + (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(255, 149, 0), System.Drawing.Color.White, 22);
            btnMultiply.Text = "*";
            btnMultiply.Click += OperatorButton_Click;

            // --- Row 3: 4, 5, 6, - ---
            btn4 = MakeButton("4", startX, startY + 2 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn4.Click += DigitButton_Click;

            btn5 = MakeButton("5", startX + (btnW + gap), startY + 2 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn5.Click += DigitButton_Click;

            btn6 = MakeButton("6", startX + 2 * (btnW + gap), startY + 2 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn6.Click += DigitButton_Click;

            btnMinus = MakeButton("-", startX + 3 * (btnW + gap), startY + 2 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(255, 149, 0), System.Drawing.Color.White, 22);
            btnMinus.Click += OperatorButton_Click;

            // --- Row 4: 1, 2, 3, + ---
            btn1 = MakeButton("1", startX, startY + 3 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn1.Click += DigitButton_Click;

            btn2 = MakeButton("2", startX + (btnW + gap), startY + 3 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn2.Click += DigitButton_Click;

            btn3 = MakeButton("3", startX + 2 * (btnW + gap), startY + 3 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn3.Click += DigitButton_Click;

            btnPlus = MakeButton("+", startX + 3 * (btnW + gap), startY + 3 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(255, 149, 0), System.Drawing.Color.White, 22);
            btnPlus.Click += OperatorButton_Click;

            // --- Row 5: 0 (wide), decimal, = ---
            btn0 = MakeButton("0", startX, startY + 4 * (btnH + gap), btnW * 2 + gap, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 20);
            btn0.Click += DigitButton_Click;

            btnDecimal = MakeButton(".", startX + 2 * (btnW + gap), startY + 4 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(55, 55, 55), System.Drawing.Color.White, 22);
            btnDecimal.Click += btnDecimal_Click;

            btnEquals = MakeButton("=", startX + 3 * (btnW + gap), startY + 4 * (btnH + gap), btnW, btnH,
                System.Drawing.Color.FromArgb(255, 149, 0), System.Drawing.Color.White, 22);
            btnEquals.Click += btnEquals_Click;

            // Add all controls to the form
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, txtDisplay,
                btnBackspace, btnSqrt,
                btnClear, btnToggleSign, btnPercent, btnDivide,
                btn7, btn8, btn9, btnMultiply,
                btn4, btn5, btn6, btnMinus,
                btn1, btn2, btn3, btnPlus,
                btn0, btnDecimal, btnEquals
            });

            this.ResumeLayout(false);
        }

        // Factory method to keep button creation DRY
        private System.Windows.Forms.Button MakeButton(string text, int x, int y, int w, int h,
            System.Drawing.Color bg, System.Drawing.Color fg, float fontSize)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.BackColor = bg;
            btn.ForeColor = fg;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", fontSize, System.Drawing.FontStyle.Regular);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TabStop = false;
            return btn;
        }
    }
}
