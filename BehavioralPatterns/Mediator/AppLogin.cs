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

        private ColleagueRadioButton radioLogin;

        private ColleagueRadioButton radioGuest;

        private ColleagueTextField textUsername;

        private ColleagueTextField textPassword;

        private ColleagueButton buttonOk;

        private ColleagueButton buttonCancel;

        public AppLogin()
            // ˅
            
            // ˄
        {
            // ˅
            InitializeComponent();
            CreateColleagues();

            // Set mediators
            radioGuest.Mediator = this;
            radioLogin.Mediator = this;
            textUsername.Mediator = this;
            textPassword.Mediator = this;
            buttonOk.Mediator = this;
            buttonCancel.Mediator = this;
            // ˄
        }

        public void CreateColleagues()
        {
            // ˅
            radioGuest = new ColleagueRadioButton(this.formsRadioGuest);
            radioLogin = new ColleagueRadioButton(this.formsRadioLogin);
            textUsername = new ColleagueTextField(this.formsTextUsername);
            textPassword = new ColleagueTextField(this.formsTextPassword);
            buttonOk = new ColleagueButton(this.formsCheckOk);
            buttonCancel = new ColleagueButton(this.formsCheckCancel);
            // ˄
        }

        // Change enable/disable of the Colleagues when notified from the Mediators.
        public void ColleagueChanged()
        {
            // ˅
            if (buttonOk.IsPressed() || buttonCancel.IsPressed())
            {
                this.Close();
            }
            else
            {
                if (radioGuest.IsSelected())        // Guest mode
                {
                    textUsername.SetActivation(false);
                    textPassword.SetActivation(false);
                    buttonOk.SetActivation(true);
                }
                else                                // Login mode
                {
                    textUsername.SetActivation(true);
                    textPassword.SetActivation(true);

                    // Judge whether the changed Colleage is enabled or disabled
                    if (textUsername.IsEmpty() == false && textPassword.IsEmpty() == false)
                    {
                        buttonOk.SetActivation(true);
                    }
                    else
                    {
                        buttonOk.SetActivation(false);
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
