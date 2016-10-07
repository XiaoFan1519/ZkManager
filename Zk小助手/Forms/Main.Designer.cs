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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("/");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.nodeTree = new System.Windows.Forms.TreeView();
            this.leftMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.memuRefresh = new System.Windows.Forms.ToolStripButton();
            this.menuReconnect = new System.Windows.Forms.ToolStripButton();
            this.memuDelete = new System.Windows.Forms.ToolStripButton();
            this.comboBox_Encoding = new System.Windows.Forms.ComboBox();
            this.richTextBox_NodeValue = new System.Windows.Forms.RichTextBox();
            this.textBox_NodePath = new System.Windows.Forms.TextBox();
            this.RightMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
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
            this.splitContainer.Size = new System.Drawing.Size(596, 321);
            this.splitContainer.SplitterDistance = 224;
            this.splitContainer.TabIndex = 0;
            // 
            // nodeTree
            // 
            this.nodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTree.Location = new System.Drawing.Point(3, 28);
            this.nodeTree.Name = "nodeTree";
            treeNode1.Name = "节点0";
            treeNode1.Tag = "/";
            treeNode1.Text = "/";
            this.nodeTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.nodeTree.Size = new System.Drawing.Size(218, 290);
            this.nodeTree.TabIndex = 3;
            this.nodeTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.nodeTree_BeforeExpand);
            this.nodeTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeTree_NodeMouseClick);
            // 
            // leftMenuToolStrip
            // 
            this.leftMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuRefresh,
            this.menuReconnect,
            this.memuDelete});
            this.leftMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuToolStrip.Name = "leftMenuToolStrip";
            this.leftMenuToolStrip.Size = new System.Drawing.Size(224, 25);
            this.leftMenuToolStrip.TabIndex = 2;
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
            // memuDelete
            // 
            this.memuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memuDelete.Image = ((System.Drawing.Image)(resources.GetObject("memuDelete.Image")));
            this.memuDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memuDelete.Name = "memuDelete";
            this.memuDelete.Size = new System.Drawing.Size(36, 22);
            this.memuDelete.Text = "删除";
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encoding.FormattingEnabled = true;
            this.comboBox_Encoding.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.comboBox_Encoding.Location = new System.Drawing.Point(307, 28);
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(58, 20);
            this.comboBox_Encoding.TabIndex = 2;
            this.comboBox_Encoding.Text = "UTF-8";
            this.comboBox_Encoding.Leave += new System.EventHandler(this.comboBox_Encoding_Leave);
            // 
            // richTextBox_NodeValue
            // 
            this.richTextBox_NodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_NodeValue.Location = new System.Drawing.Point(3, 54);
            this.richTextBox_NodeValue.Name = "richTextBox_NodeValue";
            this.richTextBox_NodeValue.Size = new System.Drawing.Size(362, 264);
            this.richTextBox_NodeValue.TabIndex = 1;
            this.richTextBox_NodeValue.Text = "";
            // 
            // textBox_NodePath
            // 
            this.textBox_NodePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NodePath.Location = new System.Drawing.Point(3, 28);
            this.textBox_NodePath.Name = "textBox_NodePath";
            this.textBox_NodePath.ReadOnly = true;
            this.textBox_NodePath.Size = new System.Drawing.Size(298, 21);
            this.textBox_NodePath.TabIndex = 0;
            this.textBox_NodePath.Text = "/";
            // 
            // RightMenuToolStrip
            // 
            this.RightMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave});
            this.RightMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.RightMenuToolStrip.Name = "RightMenuToolStrip";
            this.RightMenuToolStrip.Size = new System.Drawing.Size(368, 25);
            this.RightMenuToolStrip.TabIndex = 3;
            this.RightMenuToolStrip.Text = "RightMenuToolStrip";
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
            this.ClientSize = new System.Drawing.Size(596, 321);
            this.Controls.Add(this.splitContainer);
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
    }
}