using System;
using System.Windows.Forms;

namespace Schedule
{
    public partial class BackGroundForm : Form
    {
        public BackGroundForm()
        {
            InitializeComponent();
        }

        private void BackGroundForm_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            var mainForm = MainForm.CreateOrShow();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainForm.CreateOrShow();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            MainForm.CreateOrShow();
        }
    }
}
