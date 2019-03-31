namespace BehavioralPatterns.Mediator
{
    partial class AppLogin
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioGuest = new System.Windows.Forms.RadioButton();
            this.radioLogin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textUsername
            // 
            this.textUsername.Enabled = false;
            this.textUsername.Location = new System.Drawing.Point(109, 46);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(200, 25);
            this.textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Location = new System.Drawing.Point(109, 85);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 25);
            this.textPassword.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(139, 127);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 30);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(234, 127);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioGuest
            // 
            this.radioGuest.AutoSize = true;
            this.radioGuest.Checked = true;
            this.radioGuest.Location = new System.Drawing.Point(15, 12);
            this.radioGuest.Name = "radioGuest";
            this.radioGuest.Size = new System.Drawing.Size(77, 22);
            this.radioGuest.TabIndex = 6;
            this.radioGuest.TabStop = true;
            this.radioGuest.Text = "Guest";
            this.radioGuest.UseVisualStyleBackColor = true;
            // 
            // radioLogin
            // 
            this.radioLogin.AutoSize = true;
            this.radioLogin.Location = new System.Drawing.Point(109, 12);
            this.radioLogin.Name = "radioLogin";
            this.radioLogin.Size = new System.Drawing.Size(73, 22);
            this.radioLogin.TabIndex = 7;
            this.radioLogin.Text = "Login";
            this.radioLogin.UseVisualStyleBackColor = true;
            // 
            // AppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 174);
            this.Controls.Add(this.radioLogin);
            this.Controls.Add(this.radioGuest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppLogin";
            this.Text = "Mediator Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioGuest;
        private System.Windows.Forms.RadioButton radioLogin;
    }
}

