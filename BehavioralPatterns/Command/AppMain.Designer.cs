namespace BehavioralPatterns.Command
{
    partial class AppMain
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
            this.undoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(284, 494);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(98, 38);
            this.undoButton.TabIndex = 0;
            this.undoButton.Text = "undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(397, 494);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 38);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(754, 476);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // AppMain
            // 
            this.AcceptButton = this.undoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 538);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.undoButton);
            this.Name = "AppMain";
            this.Text = "Command Example";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox canvas;
    }
}

