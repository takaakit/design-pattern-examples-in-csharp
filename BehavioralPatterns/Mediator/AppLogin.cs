// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Mediator
{
    public partial class AppLogin : Form, IMediator
    {
        // ˅
        
        // ˄

        private ColleagueRadioButton colleagueRadioLogin;

        private ColleagueRadioButton colleagueRadioGuest;

        private ColleagueTextField colleagueTextUsername;

        private ColleagueTextField colleagueTextPassword;

        private ColleagueButton colleagueButtonOk;

        private ColleagueButton colleagueButtonCancel;

        public AppLogin()
            // ˅
            
            // ˄
        {
            // ˅
            this.colleagueRadioLogin = null;
            this.colleagueRadioGuest = null;
            this.colleagueTextUsername = null;
            this.colleagueTextPassword = null;
            this.colleagueButtonOk = null;
            this.colleagueButtonCancel = null;
            InitializeComponent();
            CreateColleagues();
            // ˄
        }

        public void CreateColleagues()
        {
            // ˅
            colleagueRadioGuest = new ColleagueRadioButton(this.radioGuest);
            colleagueRadioLogin = new ColleagueRadioButton(this.radioLogin);
            colleagueTextUsername = new ColleagueTextField(this.textUsername);
            colleagueTextPassword = new ColleagueTextField(this.textPassword);
            colleagueButtonOk = new ColleagueButton(this.buttonOk);
            colleagueButtonCancel = new ColleagueButton(this.buttonCancel);

            // Set mediators
            colleagueRadioGuest.Mediator = this;
            colleagueRadioLogin.Mediator = this;
            colleagueTextUsername.Mediator = this;
            colleagueTextPassword.Mediator = this;
            colleagueButtonOk.Mediator = this;
            colleagueButtonCancel.Mediator = this;
            // ˄
        }

        // Change enable/disable of the Colleagues when notified from the Mediators.
        public void ColleagueChanged(object sender, EventArgs e)
        {
            // ˅
            if (sender == buttonOk || sender == buttonCancel)
            {
                this.Close();
            }
            else
            {
                if (sender == radioGuest)   // Guest mode
                {
                    colleagueTextUsername.SetActivation(false);
                    colleagueTextPassword.SetActivation(false);
                    colleagueButtonOk.SetActivation(true);
                }
                else                        // Login mode
                {
                    colleagueTextUsername.SetActivation(true);
                    colleagueTextPassword.SetActivation(true);

                    // Judge whether the changed Colleage is enabled or disabled
                    if (textUsername.Text != "" && textPassword.Text != "")
                    {
                        colleagueButtonOk.SetActivation(true);
                    }
                    else
                    {
                        colleagueButtonOk.SetActivation(false);
                    }
                }
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
