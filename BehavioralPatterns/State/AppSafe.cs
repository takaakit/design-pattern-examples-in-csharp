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
            this.state = DaytimeState.GetInstance();
            InitializeComponent();

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

            this.buttonUse.Click += new System.EventHandler(this.ButtonUse_Click);
            this.buttonAlarm.Click += new System.EventHandler(this.ButtonAlarm_Click);
            this.buttonPhone.Click += new System.EventHandler(this.ButtonPhone_Click);
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // ˄
        }

        // Set time
        public void SetTime(int hour)
        {
            // ˅
            string clockTime;
            if (hour < 10)
            {
                clockTime = $"0{hour}:00";
            }
            else
            {
                clockTime = $"{hour}:00";
            }
            Console.WriteLine(clockTime);
            textTime.Text = clockTime;
            state.SetTime(this, hour);
            // ˄
        }

        // Change state
        public void ChangeState(IState state)
        {
            // ˅
            Console.WriteLine($"The state changed from {this.state.ToString()} to {state}.");
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
            state.UseSafe(this);        // Safe use button pressed
            // ˄
        }

        private void ButtonAlarm_Click(object sender, EventArgs e)
        {
            // ˅
            state.SoundBell(this);      // Emergency bell button pressed
            // ˄
        }

        private void ButtonPhone_Click(object sender, EventArgs e)
        {
            // ˅
            state.Call(this);           // Normal call button pressed
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
