using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class MainForm : Form
    {
        private MainForm()
        {
            InitializeComponent();
        }


        private static MainForm singleForm;

        public static MainForm CreateOrShow()
        {
            if (singleForm == null)
                singleForm = new MainForm();
            singleForm.Show();
            return singleForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
