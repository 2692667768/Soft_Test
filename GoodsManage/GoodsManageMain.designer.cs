namespace GoodsManage
{
    partial class GoodsManageMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BasicInfoManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsInManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsOutManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BasicInfoManageToolStripMenuItem,
            this.GoodsInManageToolStripMenuItem,
            this.GoodsOutManageToolStripMenuItem,
            this.GoodsManageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BasicInfoManageToolStripMenuItem
            // 
            this.BasicInfoManageToolStripMenuItem.Name = "BasicInfoManageToolStripMenuItem";
            this.BasicInfoManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.BasicInfoManageToolStripMenuItem.Text = "商品管理";
            this.BasicInfoManageToolStripMenuItem.Click += new System.EventHandler(this.BasicInfoManageToolStripMenuItem_Click);
            // 
            // GoodsInManageToolStripMenuItem
            // 
            this.GoodsInManageToolStripMenuItem.Name = "GoodsInManageToolStripMenuItem";
            this.GoodsInManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.GoodsInManageToolStripMenuItem.Text = "进货管理";
            this.GoodsInManageToolStripMenuItem.Click += new System.EventHandler(this.GoodsInManageToolStripMenuItem_Click);
            // 
            // GoodsOutManageToolStripMenuItem
            // 
            this.GoodsOutManageToolStripMenuItem.Name = "GoodsOutManageToolStripMenuItem";
            this.GoodsOutManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.GoodsOutManageToolStripMenuItem.Text = "销售管理";
            this.GoodsOutManageToolStripMenuItem.Click += new System.EventHandler(this.GoodsOutManageToolStripMenuItem_Click);
            // 
            // GoodsManageToolStripMenuItem
            // 
            this.GoodsManageToolStripMenuItem.Name = "GoodsManageToolStripMenuItem";
            this.GoodsManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.GoodsManageToolStripMenuItem.Text = "库存统计";
            this.GoodsManageToolStripMenuItem.Click += new System.EventHandler(this.GoodsManageToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 212);
            this.panel1.TabIndex = 0;
            // 
            // GoodsManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsManageMain";
            this.Text = "超市商品进销存管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BasicInfoManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsInManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsOutManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsManageToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

