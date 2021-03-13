// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// ˄

namespace BehavioralPatterns.State
{
    // Safe security system that the security status changes with time.
    public partial class AppSafe : Form, IContext
    {
        // ˅
        
        // ˄

        // Current state
        private IState state;

        public AppSafe()
            // ˅
            
            // ˄
        {
            // ˅
            InitializeComponent();

            state = DaytimeState.GetInstance();

            Task.Run(() => {
                while (true)
                {
                    for (int hour = 0; hour < 24; hour++)
                    {
                        SetTime(hour);      // Set the time
                        Thread.Sleep(1000);
                    }
                }
            });

            buttonUse.Click += new System.EventHandler(ButtonUse_Click);
            buttonAlarm.Click += new System.EventHandler(ButtonAlarm_Click);
            buttonPhone.Click += new System.EventHandler(ButtonPhone_Click);
            buttonExit.Click += new System.EventHandler(ButtonExit_Click);
            // ˄
        }

        // Set time
        public void SetTime(int hour)
        {
            // ˅
            string clockTime = "Current Time : ";
            if (hour < 10)
            {
                clockTime += $"0{hour}:00";
            }
            else
            {
                clockTime += $"{hour}:00";
            }

            Console.WriteLine(clockTime);
            if (textTime != null)
            {
                textTime.Text = clockTime;
            }
            
            state.SetTime(this, hour);
            // ˄
        }

        // Change state
        public void ChangeState(IState state)
        {
            // ˅
            Console.WriteLine($"The state changed from {this.state} to {state}.");
            this.state = state;
            // ˄
        }

        // Call a security guard room
        public void CallSecurityGuardsRoom(string message)
        {
            // ˅
            textMessage.AppendText($"call! {message}{Environment.NewLine}");
            // ˄
        }

        // Record security log
        public void RecordSecurityLog(string message)
        {
            // ˅
            textMessage.AppendText($"record ... {message}{Environment.NewLine}");
            // ˄
        }

        private void ButtonUse_Click(object sender, EventArgs e)
        {
            // ˅
            state.UseSafe(this);        // Use button pressed
            // ˄
        }

        private void ButtonAlarm_Click(object sender, EventArgs e)
        {
            // ˅
            state.SoundBell(this);      // Alarm button pressed
            // ˄
        }

        private void ButtonPhone_Click(object sender, EventArgs e)
        {
            // ˅
            state.Call(this);           // Phone button pressed
            // ˄
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // ˅
            this.Close();               // Exit button pressed
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
