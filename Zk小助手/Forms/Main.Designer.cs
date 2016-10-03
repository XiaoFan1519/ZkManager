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
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_refresh = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_reconnect = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_delete = new System.Windows.Forms.ToolStripLabel();
            this.comboBox_Encoding = new System.Windows.Forms.ComboBox();
            this.richTextBox_NodeValue = new System.Windows.Forms.RichTextBox();
            this.textBox_NodePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuToolStrip.SuspendLayout();
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
            this.splitContainer.Panel1.Controls.Add(this.menuToolStrip);
            // 
            // splitContainer.Panel2
            // 
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
            treeNode1.Text = "/";
            this.nodeTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.nodeTree.Size = new System.Drawing.Size(218, 290);
            this.nodeTree.TabIndex = 3;
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_refresh,
            this.toolStripLabel_reconnect,
            this.toolStripLabel_delete});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(224, 25);
            this.menuToolStrip.TabIndex = 2;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_refresh
            // 
            this.toolStripButton_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_refresh.Image")));
            this.toolStripButton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_refresh.Name = "toolStripButton_refresh";
            this.toolStripButton_refresh.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton_refresh.Text = "刷新";
            // 
            // toolStripLabel_reconnect
            // 
            this.toolStripLabel_reconnect.Name = "toolStripLabel_reconnect";
            this.toolStripLabel_reconnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel_reconnect.Text = "重新连接";
            // 
            // toolStripLabel_delete
            // 
            this.toolStripLabel_delete.Name = "toolStripLabel_delete";
            this.toolStripLabel_delete.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel_delete.Text = "删除";
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encoding.FormattingEnabled = true;
            this.comboBox_Encoding.Items.AddRange(new object[] {
            "UTF-8"});
            this.comboBox_Encoding.Location = new System.Drawing.Point(307, 3);
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(58, 20);
            this.comboBox_Encoding.TabIndex = 2;
            this.comboBox_Encoding.Text = "UTF-8";
            // 
            // richTextBox_NodeValue
            // 
            this.richTextBox_NodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_NodeValue.Location = new System.Drawing.Point(3, 28);
            this.richTextBox_NodeValue.Name = "richTextBox_NodeValue";
            this.richTextBox_NodeValue.Size = new System.Drawing.Size(362, 290);
            this.richTextBox_NodeValue.TabIndex = 1;
            this.richTextBox_NodeValue.Text = "";
            // 
            // textBox_NodePath
            // 
            this.textBox_NodePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NodePath.Location = new System.Drawing.Point(3, 3);
            this.textBox_NodePath.Name = "textBox_NodePath";
            this.textBox_NodePath.Size = new System.Drawing.Size(298, 21);
            this.textBox_NodePath.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 321);
            this.Controls.Add(this.splitContainer);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.TreeView nodeTree;
        private System.Windows.Forms.TextBox textBox_NodePath;
        private System.Windows.Forms.RichTextBox richTextBox_NodeValue;
        private System.Windows.Forms.ToolStripLabel toolStripButton_refresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_reconnect;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_delete;
        private System.Windows.Forms.ComboBox comboBox_Encoding;
    }
}