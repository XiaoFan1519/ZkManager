namespace ZkManager
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ListBox_IpList = new System.Windows.Forms.ListBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_IpList
            // 
            this.ListBox_IpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_IpList.FormattingEnabled = true;
            this.ListBox_IpList.ItemHeight = 12;
            this.ListBox_IpList.Location = new System.Drawing.Point(9, 10);
            this.ListBox_IpList.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_IpList.Name = "ListBox_IpList";
            this.ListBox_IpList.Size = new System.Drawing.Size(164, 220);
            this.ListBox_IpList.TabIndex = 0;
            this.ListBox_IpList.DoubleClick += new System.EventHandler(this.ListBox_IpList_DoubleClick);
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Add.Location = new System.Drawing.Point(176, 10);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(64, 20);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "新增";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Edit.Location = new System.Drawing.Point(176, 33);
            this.Button_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(64, 20);
            this.Button_Edit.TabIndex = 2;
            this.Button_Edit.Text = "编辑";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Delete.Location = new System.Drawing.Point(176, 56);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(64, 20);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "删除";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Login.Location = new System.Drawing.Point(176, 79);
            this.Button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(64, 20);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "进入";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 238);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ListBox_IpList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_IpList;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Login;
    }
}