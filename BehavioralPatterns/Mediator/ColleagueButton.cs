// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Mediator
{
    public class ColleagueButton : IColleague
    {
        // ˅
        
        // ˄

        public IMediator Mediator
        {
            // ˅
            get; set;
            // ˄
        } = null;

        private readonly Button button;

        public ColleagueButton(Button button)
            // ˅
            
            // ˄
        {
            // ˅
            this.button = button;
            button.Click += new EventHandler(this.Button_Click);
            // ˄
        }

        // Set enable/disable from the Mediator
        public void SetActivation(bool isEnable)
        {
            // ˅
            button.Enabled = isEnable;
            // ˄
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // ˅
            Mediator.ColleagueChanged(sender, e);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
