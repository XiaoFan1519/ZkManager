namespace ZkManager.Forms
{
    partial class About
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact me：";
            // 
            // gitHubLink
            // 
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Location = new System.Drawing.Point(95, 8);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(41, 12);
            this.gitHubLink.TabIndex = 1;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "GitHub";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // emailLink
            // 
            this.emailLink.AutoSize = true;
            this.emailLink.Location = new System.Drawing.Point(142, 8);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(35, 12);
            this.emailLink.TabIndex = 2;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "Email";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 41);
            this.Controls.Add(this.emailLink);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel gitHubLink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel emailLink;
    }
}
