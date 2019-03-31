namespace BehavioralPatterns.State
{
    partial class AppSafe
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
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUse
            // 
            this.buttonUse.Location = new System.Drawing.Point(12, 359);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(180, 50);
            this.buttonUse.TabIndex = 0;
            this.buttonUse.Text = "Use a safe";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.ButtonUse_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(205, 359);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(180, 50);
            this.buttonAlarm.TabIndex = 1;
            this.buttonAlarm.Text = "Sound an emergency bell";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            this.buttonAlarm.Click += new System.EventHandler(this.ButtonAlarm_Click);
            // 
            // buttonPhone
            // 
            this.buttonPhone.Location = new System.Drawing.Point(398, 359);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(180, 50);
            this.buttonPhone.TabIndex = 2;
            this.buttonPhone.Text = "Make a call";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.ButtonPhone_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(592, 359);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 50);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textTime
            // 
            this.textTime.BackColor = System.Drawing.SystemColors.Window;
            this.textTime.Location = new System.Drawing.Point(161, 12);
            this.textTime.Name = "textTime";
            this.textTime.ReadOnly = true;
            this.textTime.Size = new System.Drawing.Size(200, 25);
            this.textTime.TabIndex = 4;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textMessage.Location = new System.Drawing.Point(12, 43);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(760, 300);
            this.textMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Time :";
            // 
            // AppSafe
            // 
            this.AcceptButton = this.buttonExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonUse);
            this.Name = "AppSafe";
            this.Text = "State Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label1;
    }
}

