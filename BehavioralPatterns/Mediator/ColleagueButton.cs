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

        private readonly CheckBox checkBox;

        public ColleagueButton(CheckBox checkBox)
            // ˅
            
            // ˄
        {
            // ˅
            this.checkBox = checkBox;
            checkBox.Click += new EventHandler(Button_Click);
            // ˄
        }

        // Set enable/disable from the Mediator
        public void SetActivation(bool isEnable)
        {
            // ˅
            checkBox.Enabled = isEnable;
            // ˄
        }

        public bool IsPressed()
        {
            // ˅
            return checkBox.Checked;
            // ˄
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // ˅
            Mediator.ColleagueChanged();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
