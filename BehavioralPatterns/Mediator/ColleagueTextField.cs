// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Mediator
{
    public class ColleagueTextField : IColleague
    {
        // ˅
        
        // ˄

        public IMediator Mediator
        {
            // ˅
            get; set;
            // ˄
        } = null;

        private readonly TextBox textBox;

        public ColleagueTextField(TextBox textBox)
            // ˅
            
            // ˄
        {
            // ˅
            this.textBox = textBox;
            textBox.TextChanged += new EventHandler(this.TextBox_TextChanged);
            // ˄
        }

        // Set enable/disable from the Mediator
        public void SetActivation(bool isEnable)
        {
            // ˅
            textBox.Enabled = isEnable;
            // ˄
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
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
