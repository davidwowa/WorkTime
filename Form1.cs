using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;

namespace WorkTime
{
    public partial class WorkTimeForm : Form
    {
        private TimeCore timeCore;

        public WorkTimeForm()
        {
            InitializeComponent();

            timeCore = new TimeCore();

            timeCore.getPCStartTime();
            labelStartTime.Text = timeCore.getPCStartTime();
            screentStartTime.DisplayTime = timeCore.getPCStartTimeAsDateTime();

            screentWorkTime.LedLayout = LedControls.LedLayout.BlueLayout;
            segmentScreen.LedLayout = LedControls.LedLayout.BlueLayout;
            screenPause.LedLayout = LedControls.LedLayout.BlueLayout;
            screentStartTime.LedLayout = LedControls.LedLayout.BlueLayout;
            
            

            currentTimeTimer.Start();
            workTimeTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void workTimeTimer_Tick(object sender, EventArgs e)
        {
            DateTime time = new DateTime();

            TimeSpan span = timeCore.getPCWorkTimeAsTimeSpam();
            
            time = time.Add(span);

            screentWorkTime.DisplayTime = time;

            int pause = timeCore.pause;
            if (pause < 60)
            {
                screenPause.DisplayMin = timeCore.pause;
            }
            else
            {
                screenPause.DisplayMin = 0;
                screenPause.DisplayHour = 1;
            }
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            segmentScreen.DisplayTime = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
