namespace ZkManager.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("/");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.nodeTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.delMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.memuRefresh = new System.Windows.Forms.ToolStripButton();
            this.menuReconnect = new System.Windows.Forms.ToolStripButton();
            this.menuAbout = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_NodeValue = new System.Windows.Forms.RichTextBox();
            this.comboBox_Encoding = new System.Windows.Forms.ComboBox();
            this.textBox_NodePath = new System.Windows.Forms.TextBox();
            this.RightMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.menuUpdate = new System.Windows.Forms.ToolStripButton();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.leftMenuToolStrip.SuspendLayout();
            this.RightMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.nodeTree);
            this.splitContainer.Panel1.Controls.Add(this.leftMenuToolStrip);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.richTextBox_NodeValue);
            this.splitContainer.Panel2.Controls.Add(this.comboBox_Encoding);
            this.splitContainer.Panel2.Controls.Add(this.textBox_NodePath);
            this.splitContainer.Panel2.Controls.Add(this.RightMenuToolStrip);
            this.splitContainer.Size = new System.Drawing.Size(586, 358);
            this.splitContainer.SplitterDistance = 224;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 15;
            // 
            // nodeTree
            // 
            this.nodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTree.ContextMenuStrip = this.contextMenuStrip1;
            this.nodeTree.Location = new System.Drawing.Point(3, 25);
            this.nodeTree.Name = "nodeTree";
            treeNode2.Name = "节点0";
            treeNode2.Tag = "/";
            treeNode2.Text = "/";
            this.nodeTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.nodeTree.Size = new System.Drawing.Size(219, 330);
            this.nodeTree.TabIndex = 16;
            this.nodeTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.nodeTree_BeforeExpand);
            this.nodeTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeTree_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenu,
            this.addMenuI,
            this.delMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // refreshMenu
            // 
            this.refreshMenu.Name = "refreshMenu";
            this.refreshMenu.Size = new System.Drawing.Size(152, 22);
            this.refreshMenu.Text = "刷新";
            this.refreshMenu.Click += new System.EventHandler(this.memuRefresh_Click);
            // 
            // addMenuI
            // 
            this.addMenuI.Name = "addMenuI";
            this.addMenuI.Size = new System.Drawing.Size(152, 22);
            this.addMenuI.Text = "新增";
            this.addMenuI.Click += new System.EventHandler(this.addMenuI_Click);
            // 
            // delMenu
            // 
            this.delMenu.Name = "delMenu";
            this.delMenu.Size = new System.Drawing.Size(152, 22);
            this.delMenu.Text = "删除";
            this.delMenu.Click += new System.EventHandler(this.delMenu_Click);
            // 
            // leftMenuToolStrip
            // 
            this.leftMenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.leftMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuRefresh,
            this.menuReconnect,
            this.menuAbout});
            this.leftMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuToolStrip.Name = "leftMenuToolStrip";
            this.leftMenuToolStrip.Size = new System.Drawing.Size(224, 25);
            this.leftMenuToolStrip.TabIndex = 15;
            this.leftMenuToolStrip.Text = "toolStrip1";
            // 
            // memuRefresh
            // 
            this.memuRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("memuRefresh.Image")));
            this.memuRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memuRefresh.Name = "memuRefresh";
            this.memuRefresh.Size = new System.Drawing.Size(36, 22);
            this.memuRefresh.Text = "刷新";
            this.memuRefresh.Click += new System.EventHandler(this.memuRefresh_Click);
            // 
            // menuReconnect
            // 
            this.menuReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuReconnect.Image = ((System.Drawing.Image)(resources.GetObject("menuReconnect.Image")));
            this.menuReconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuReconnect.Name = "menuReconnect";
            this.menuReconnect.Size = new System.Drawing.Size(60, 22);
            this.menuReconnect.Text = "重新连接";
            this.menuReconnect.Click += new System.EventHandler(this.menuReconnect_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuAbout.Image")));
            this.menuAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(36, 22);
            this.menuAbout.Text = "关于";
            // 
            // richTextBox_NodeValue
            // 
            this.richTextBox_NodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_NodeValue.Location = new System.Drawing.Point(2, 50);
            this.richTextBox_NodeValue.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_NodeValue.Name = "richTextBox_NodeValue";
            this.richTextBox_NodeValue.Size = new System.Drawing.Size(360, 306);
            this.richTextBox_NodeValue.TabIndex = 17;
            this.richTextBox_NodeValue.Text = "";
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encoding.FormattingEnabled = true;
            this.comboBox_Encoding.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.comboBox_Encoding.Location = new System.Drawing.Point(305, 25);
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(57, 20);
            this.comboBox_Encoding.TabIndex = 16;
            this.comboBox_Encoding.Text = "UTF-8";
            // 
            // textBox_NodePath
            // 
            this.textBox_NodePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NodePath.Location = new System.Drawing.Point(2, 25);
            this.textBox_NodePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NodePath.Name = "textBox_NodePath";
            this.textBox_NodePath.ReadOnly = true;
            this.textBox_NodePath.Size = new System.Drawing.Size(299, 21);
            this.textBox_NodePath.TabIndex = 15;
            this.textBox_NodePath.Text = "/";
            // 
            // RightMenuToolStrip
            // 
            this.RightMenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdate,
            this.menuSave});
            this.RightMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RightMenuToolStrip.Name = "RightMenuToolStrip";
            this.RightMenuToolStrip.Size = new System.Drawing.Size(359, 25);
            this.RightMenuToolStrip.TabIndex = 14;
            this.RightMenuToolStrip.Text = "RightMenuToolStrip";
            // 
            // menuUpdate
            // 
            this.menuUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuUpdate.Image = ((System.Drawing.Image)(resources.GetObject("menuUpdate.Image")));
            this.menuUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(36, 22);
            this.menuUpdate.Text = "更新";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuSave
            // 
            this.menuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(36, 22);
            this.menuSave.Text = "保存";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 358);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.leftMenuToolStrip.ResumeLayout(false);
            this.leftMenuToolStrip.PerformLayout();
            this.RightMenuToolStrip.ResumeLayout(false);
            this.RightMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip leftMenuToolStrip;
        private System.Windows.Forms.ToolStripButton memuRefresh;
        private System.Windows.Forms.ToolStripButton menuReconnect;
        private System.Windows.Forms.ToolStrip RightMenuToolStrip;
        private System.Windows.Forms.ToolStripButton menuUpdate;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.TreeView nodeTree;
        private System.Windows.Forms.RichTextBox richTextBox_NodeValue;
        private System.Windows.Forms.ComboBox comboBox_Encoding;
        private System.Windows.Forms.TextBox textBox_NodePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuI;
        private System.Windows.Forms.ToolStripMenuItem delMenu;
        private System.Windows.Forms.ToolStripButton menuAbout;
    }
}