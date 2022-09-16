using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MathSol
{
    public partial class StartForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nWeightEllipse
        );
        public StartForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = EquationsBtn.Height;
            pnlNav.Top = EquationsBtn.Top;
            pnlNav.Left = EquationsBtn.Left;
            EquationsBtn.BackColor = Color.DimGray;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close MathSol?";
            string title = "Close MathSol";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) this.Close();
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            solvePanel.Visible = true;
            buttonPanel.Visible = true;
        }
        private void SimplifyBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = SimplifyBtn.Height;
            pnlNav.Top = SimplifyBtn.Top;
            SimplifyBtn.BackColor = Color.Gray;
        }

        private void EquationsBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = EquationsBtn.Height;
            pnlNav.Top = EquationsBtn.Top;
            pnlNav.Left = EquationsBtn.Left;
            EquationsBtn.BackColor = Color.Gray;
        }

        private void FactorsBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = FactorsBtn.Height;
            pnlNav.Top = FactorsBtn.Top;
            FactorsBtn.BackColor = Color.Gray;
        }

        private void GraphsBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = GraphsBtn.Height;
            pnlNav.Top = GraphsBtn.Top;
            GraphsBtn.BackColor = Color.Gray;
        }


        private void HelpBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = HelpBtn.Height;
            pnlNav.Top = HelpBtn.Top;
            HelpBtn.BackColor = Color.Gray;
        }

        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = ExitBtn2.Height;
            pnlNav.Top = ExitBtn2.Top;
            ExitBtn2.BackColor = Color.Gray;
            string message = "Are you sure you want to close MathSol?";
            string title = "Close MathSol";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) this.Close();

        }
        private void BGPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BGPanel_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void ExitBtn2_Leave(object sender, EventArgs e)
        {
            ExitBtn2.BackColor = Color.DimGray;
        }

        private void HelpBtn_Leave(object sender, EventArgs e)
        {
            HelpBtn.BackColor = Color.DimGray;
        }

        private void GraphsBtn_Leave(object sender, EventArgs e)
        {
            GraphsBtn.BackColor = Color.DimGray;
        }

        private void FactorsBtn_Leave(object sender, EventArgs e)
        {
            FactorsBtn.BackColor = Color.DimGray;
        }

        private void SimplifyBtn_Leave(object sender, EventArgs e)
        {
            SimplifyBtn.BackColor = Color.DimGray;
        }

        private void EquationsBtn_Leave(object sender, EventArgs e)
        {
            EquationsBtn.BackColor = Color.DimGray;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt64() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}