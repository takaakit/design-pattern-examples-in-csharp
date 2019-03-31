// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Mediator
{
    public class ColleagueRadioButton : IColleague
    {
        // ˅
        
        // ˄

        public IMediator Mediator
        {
            // ˅
            get; set;
            // ˄
        } = null;

        private readonly RadioButton radioButton;

        public ColleagueRadioButton(RadioButton radioButton)
            // ˅
            
            // ˄
        {
            // ˅
            this.radioButton = radioButton;
            radioButton.CheckedChanged += new EventHandler(this.RadioButton_CheckedChanged);
            // ˄
        }

        // Set enable/disable from the Mediator
        public void SetActivation(bool isEnable)
        {
            // ˅
            radioButton.Enabled = isEnable;
            // ˄
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
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
