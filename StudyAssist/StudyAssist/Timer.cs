using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace StudyAssist
{
    public partial class Timer : Form
    {
        private System.Timers.Timer timer;
        private TimeSpan studyTime = TimeSpan.FromMinutes(25);
        private TimeSpan breakTime = TimeSpan.FromMinutes(5);
        private TimeSpan remainingTime;
        private bool isStudyTime = true;
        private bool isRunning = false;
        private bool isPaused = false;
        public Timer()
        {
            InitializeComponent();
            InitializeTimer();
            remainingTime = studyTime;
            UpdateTimerDisplay();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => TimerElapsed(sender, e)));
                return;
            }

            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimerDisplay();
            }
            else
            {
                timer.Stop();
                isRunning = false;
                MessageBox.Show(isStudyTime ? "Time's Up! Time for a mini break!!" : "Enough break!! Get back to work NOW!!");
                isStudyTime = !isStudyTime;
                remainingTime = isStudyTime ? studyTime : breakTime;
                UpdateTimerDisplay();
            }
        }

        private void UpdateTimerDisplay()
        {
            label1.Text = remainingTime.ToString(@"mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isPaused = true;
                isRunning = false;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
            isPaused = false;
            remainingTime = studyTime;
            UpdateTimerDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isRunning || isPaused)
            {
                timer.Start();
                isRunning = true;
                isPaused = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The Pomodoro technique uses 25-minute work sessions to maintain focus.\n" +
                "It includes short breaks to improve productivity and mental agility.",
                "Why 25 minutes?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
