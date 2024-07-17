using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Control
{
    public partial class DongHoTick : UserControl
    {
        bool isRunning = false;
        DateTime startTime;
        Timer timer1 = new Timer();

        public DongHoTick()
        {
            InitializeComponent();
            timer1.Interval = 100; 
            timer1.Tick += timer1_Tick; 
        }

        private void DongHo_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                startTime = DateTime.Now;
                timer1.Start();
                btnStart.Text = "Stop";
            }
            else
            {
                isRunning = false;
                timer1.Stop();
                btnStart.Text = "Start";
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                TimeSpan elapsed = DateTime.Now.Subtract(startTime);
                lbTime.Text = elapsed.ToString(@"hh\:mm\:ss\.fff");
            }
        }
    }
}
