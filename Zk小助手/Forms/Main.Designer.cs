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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("/");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.nodeTree = new System.Windows.Forms.TreeView();
            this.leftMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.memuRefresh = new System.Windows.Forms.ToolStripButton();
            this.menuReconnect = new System.Windows.Forms.ToolStripButton();
            this.memuDelete = new System.Windows.Forms.ToolStripButton();
            this.RightMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.comboBox_Encoding = new System.Windows.Forms.ComboBox();
            this.richTextBox_NodeValue = new System.Windows.Forms.RichTextBox();
            this.textBox_NodePath = new System.Windows.Forms.TextBox();
            this.menuUpdate = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.leftMenuToolStrip.SuspendLayout();
            this.RightMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.nodeTree);
            this.splitContainer.Panel1.Controls.Add(this.leftMenuToolStrip);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.RightMenuToolStrip);
            this.splitContainer.Panel2.Controls.Add(this.comboBox_Encoding);
            this.splitContainer.Panel2.Controls.Add(this.richTextBox_NodeValue);
            this.splitContainer.Panel2.Controls.Add(this.textBox_NodePath);
            this.splitContainer.Size = new System.Drawing.Size(795, 401);
            this.splitContainer.SplitterDistance = 298;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // nodeTree
            // 
            this.nodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTree.Location = new System.Drawing.Point(4, 35);
            this.nodeTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nodeTree.Name = "nodeTree";
            treeNode2.Name = "节点0";
            treeNode2.Tag = "/";
            treeNode2.Text = "/";
            this.nodeTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.nodeTree.Size = new System.Drawing.Size(288, 362);
            this.nodeTree.TabIndex = 3;
            this.nodeTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.nodeTree_BeforeExpand);
            this.nodeTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeTree_NodeMouseClick);
            // 
            // leftMenuToolStrip
            // 
            this.leftMenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.leftMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuRefresh,
            this.menuReconnect,
            this.memuDelete});
            this.leftMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuToolStrip.Name = "leftMenuToolStrip";
            this.leftMenuToolStrip.Size = new System.Drawing.Size(298, 27);
            this.leftMenuToolStrip.TabIndex = 2;
            this.leftMenuToolStrip.Text = "toolStrip1";
            // 
            // memuRefresh
            // 
            this.memuRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("memuRefresh.Image")));
            this.memuRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memuRefresh.Name = "memuRefresh";
            this.memuRefresh.Size = new System.Drawing.Size(43, 24);
            this.memuRefresh.Text = "刷新";
            // 
            // menuReconnect
            // 
            this.menuReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuReconnect.Image = ((System.Drawing.Image)(resources.GetObject("menuReconnect.Image")));
            this.menuReconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuReconnect.Name = "menuReconnect";
            this.menuReconnect.Size = new System.Drawing.Size(73, 24);
            this.menuReconnect.Text = "重新连接";
            this.menuReconnect.Click += new System.EventHandler(this.menuReconnect_Click);
            // 
            // memuDelete
            // 
            this.memuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memuDelete.Image = ((System.Drawing.Image)(resources.GetObject("memuDelete.Image")));
            this.memuDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memuDelete.Name = "memuDelete";
            this.memuDelete.Size = new System.Drawing.Size(43, 24);
            this.memuDelete.Text = "删除";
            // 
            // RightMenuToolStrip
            // 
            this.RightMenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdate,
            this.menuSave});
            this.RightMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RightMenuToolStrip.Name = "RightMenuToolStrip";
            this.RightMenuToolStrip.Size = new System.Drawing.Size(492, 27);
            this.RightMenuToolStrip.TabIndex = 3;
            this.RightMenuToolStrip.Text = "RightMenuToolStrip";
            // 
            // menuSave
            // 
            this.menuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(43, 24);
            this.menuSave.Text = "保存";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encoding.FormattingEnabled = true;
            this.comboBox_Encoding.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.comboBox_Encoding.Location = new System.Drawing.Point(410, 35);
            this.comboBox_Encoding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(76, 23);
            this.comboBox_Encoding.TabIndex = 2;
            this.comboBox_Encoding.Text = "UTF-8";
            this.comboBox_Encoding.Leave += new System.EventHandler(this.comboBox_Encoding_Leave);
            // 
            // richTextBox_NodeValue
            // 
            this.richTextBox_NodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_NodeValue.Location = new System.Drawing.Point(4, 68);
            this.richTextBox_NodeValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_NodeValue.Name = "richTextBox_NodeValue";
            this.richTextBox_NodeValue.Size = new System.Drawing.Size(482, 329);
            this.richTextBox_NodeValue.TabIndex = 1;
            this.richTextBox_NodeValue.Text = "";
            // 
            // textBox_NodePath
            // 
            this.textBox_NodePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NodePath.Location = new System.Drawing.Point(4, 35);
            this.textBox_NodePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NodePath.Name = "textBox_NodePath";
            this.textBox_NodePath.ReadOnly = true;
            this.textBox_NodePath.Size = new System.Drawing.Size(397, 25);
            this.textBox_NodePath.TabIndex = 0;
            this.textBox_NodePath.Text = "/";
            // 
            // menuUpdate
            // 
            this.menuUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuUpdate.Image = ((System.Drawing.Image)(resources.GetObject("menuUpdate.Image")));
            this.menuUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(43, 24);
            this.menuUpdate.Text = "更新";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 401);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.leftMenuToolStrip.ResumeLayout(false);
            this.leftMenuToolStrip.PerformLayout();
            this.RightMenuToolStrip.ResumeLayout(false);
            this.RightMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip leftMenuToolStrip;
        private System.Windows.Forms.TreeView nodeTree;
        private System.Windows.Forms.TextBox textBox_NodePath;
        private System.Windows.Forms.RichTextBox richTextBox_NodeValue;
        private System.Windows.Forms.ComboBox comboBox_Encoding;
        private System.Windows.Forms.ToolStripButton memuRefresh;
        private System.Windows.Forms.ToolStripButton menuReconnect;
        private System.Windows.Forms.ToolStripButton memuDelete;
        private System.Windows.Forms.ToolStrip RightMenuToolStrip;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuUpdate;
    }
}