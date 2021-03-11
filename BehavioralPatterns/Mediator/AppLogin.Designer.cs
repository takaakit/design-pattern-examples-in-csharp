
namespace BehavioralPatterns.Mediator
{
    partial class AppLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsRadioGuest = new System.Windows.Forms.RadioButton();
            this.formsRadioLogin = new System.Windows.Forms.RadioButton();
            this.formsLabelUsername = new System.Windows.Forms.Label();
            this.formsLabelPassword = new System.Windows.Forms.Label();
            this.formsTextUsername = new System.Windows.Forms.TextBox();
            this.formsTextPassword = new System.Windows.Forms.TextBox();
            this.formsCheckOk = new System.Windows.Forms.CheckBox();
            this.formsCheckCancel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formsRadioGuest
            // 
            this.formsRadioGuest.AutoSize = true;
            this.formsRadioGuest.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsRadioGuest.Location = new System.Drawing.Point(23, 16);
            this.formsRadioGuest.Name = "formsRadioGuest";
            this.formsRadioGuest.Size = new System.Drawing.Size(81, 29);
            this.formsRadioGuest.TabIndex = 0;
            this.formsRadioGuest.TabStop = true;
            this.formsRadioGuest.Text = "Guest";
            this.formsRadioGuest.UseVisualStyleBackColor = true;
            // 
            // formsRadioLogin
            // 
            this.formsRadioLogin.AutoSize = true;
            this.formsRadioLogin.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsRadioLogin.Location = new System.Drawing.Point(121, 16);
            this.formsRadioLogin.Name = "formsRadioLogin";
            this.formsRadioLogin.Size = new System.Drawing.Size(80, 29);
            this.formsRadioLogin.TabIndex = 1;
            this.formsRadioLogin.TabStop = true;
            this.formsRadioLogin.Text = "Login";
            this.formsRadioLogin.UseVisualStyleBackColor = true;
            // 
            // formsLabelUsername
            // 
            this.formsLabelUsername.AutoSize = true;
            this.formsLabelUsername.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsLabelUsername.Location = new System.Drawing.Point(17, 59);
            this.formsLabelUsername.Name = "formsLabelUsername";
            this.formsLabelUsername.Size = new System.Drawing.Size(101, 25);
            this.formsLabelUsername.TabIndex = 2;
            this.formsLabelUsername.Text = "Username:";
            // 
            // formsLabelPassword
            // 
            this.formsLabelPassword.AutoSize = true;
            this.formsLabelPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsLabelPassword.Location = new System.Drawing.Point(17, 105);
            this.formsLabelPassword.Name = "formsLabelPassword";
            this.formsLabelPassword.Size = new System.Drawing.Size(96, 25);
            this.formsLabelPassword.TabIndex = 3;
            this.formsLabelPassword.Text = "Password:";
            // 
            // formsTextUsername
            // 
            this.formsTextUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsTextUsername.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsTextUsername.Location = new System.Drawing.Point(127, 56);
            this.formsTextUsername.Name = "formsTextUsername";
            this.formsTextUsername.Size = new System.Drawing.Size(212, 32);
            this.formsTextUsername.TabIndex = 4;
            // 
            // formsTextPassword
            // 
            this.formsTextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsTextPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsTextPassword.Location = new System.Drawing.Point(127, 102);
            this.formsTextPassword.Name = "formsTextPassword";
            this.formsTextPassword.PasswordChar = '*';
            this.formsTextPassword.Size = new System.Drawing.Size(212, 32);
            this.formsTextPassword.TabIndex = 5;
            // 
            // formsCheckOk
            // 
            this.formsCheckOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.formsCheckOk.Appearance = System.Windows.Forms.Appearance.Button;
            this.formsCheckOk.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsCheckOk.Location = new System.Drawing.Point(127, 151);
            this.formsCheckOk.Name = "formsCheckOk";
            this.formsCheckOk.Size = new System.Drawing.Size(100, 40);
            this.formsCheckOk.TabIndex = 6;
            this.formsCheckOk.Text = "OK";
            this.formsCheckOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formsCheckOk.UseVisualStyleBackColor = true;
            // 
            // formsCheckCancel
            // 
            this.formsCheckCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.formsCheckCancel.Appearance = System.Windows.Forms.Appearance.Button;
            this.formsCheckCancel.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsCheckCancel.Location = new System.Drawing.Point(239, 151);
            this.formsCheckCancel.Name = "formsCheckCancel";
            this.formsCheckCancel.Size = new System.Drawing.Size(100, 40);
            this.formsCheckCancel.TabIndex = 7;
            this.formsCheckCancel.Text = "Cancel";
            this.formsCheckCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formsCheckCancel.UseVisualStyleBackColor = true;
            // 
            // AppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 203);
            this.Controls.Add(this.formsCheckCancel);
            this.Controls.Add(this.formsCheckOk);
            this.Controls.Add(this.formsTextPassword);
            this.Controls.Add(this.formsTextUsername);
            this.Controls.Add(this.formsLabelPassword);
            this.Controls.Add(this.formsLabelUsername);
            this.Controls.Add(this.formsRadioLogin);
            this.Controls.Add(this.formsRadioGuest);
            this.Name = "AppLogin";
            this.Text = "Mediator Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton formsRadioGuest;
        private System.Windows.Forms.RadioButton formsRadioLogin;
        private System.Windows.Forms.Label formsLabelUsername;
        private System.Windows.Forms.Label formsLabelPassword;
        private System.Windows.Forms.TextBox formsTextUsername;
        private System.Windows.Forms.TextBox formsTextPassword;
        private System.Windows.Forms.CheckBox formsCheckOk;
        private System.Windows.Forms.CheckBox formsCheckCancel;
    }
}

