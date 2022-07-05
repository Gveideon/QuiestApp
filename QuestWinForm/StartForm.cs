using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestWinForm
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            //timer.Start();
            label1.Parent = pictureBackground;
            label1.BackColor = Color.Transparent;
            label1.Visible = false;
            //buttonStart.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hide();
           // timer.Stop();
            new MainForm().Show();
           // Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //if(label1.Visible == true)
            //    buttonStart.Enabled = true;
            //if (timer.Interval == 3000)
            //    timer.Interval = 7000;
            //label1.Visible = true;
        }
    }
}
