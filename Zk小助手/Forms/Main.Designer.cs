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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.nodeTree = new System.Windows.Forms.TreeView();
            this.textBox_NodePath = new System.Windows.Forms.TextBox();
            this.richTextBox_NodeValue = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.splitContainer.Panel2.Controls.Add(this.richTextBox_NodeValue);
            this.splitContainer.Panel2.Controls.Add(this.textBox_NodePath);
            this.splitContainer.Size = new System.Drawing.Size(596, 321);
            this.splitContainer.SplitterDistance = 224;
            this.splitContainer.TabIndex = 0;
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(224, 25);
            this.menuToolStrip.TabIndex = 2;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // nodeTree
            // 
            this.nodeTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTree.Location = new System.Drawing.Point(3, 28);
            this.nodeTree.Name = "nodeTree";
            this.nodeTree.Size = new System.Drawing.Size(218, 290);
            this.nodeTree.TabIndex = 3;
            // 
            // textBox_NodePath
            // 
            this.textBox_NodePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NodePath.Location = new System.Drawing.Point(3, 3);
            this.textBox_NodePath.Name = "textBox_NodePath";
            this.textBox_NodePath.Size = new System.Drawing.Size(362, 21);
            this.textBox_NodePath.TabIndex = 0;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 321);
            this.Controls.Add(this.splitContainer);
            this.Name = "Main";
            this.Text = "Main";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.TreeView nodeTree;
        private System.Windows.Forms.TextBox textBox_NodePath;
        private System.Windows.Forms.RichTextBox richTextBox_NodeValue;
    }
}