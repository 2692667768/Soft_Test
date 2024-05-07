namespace GoodsManage
{
    partial class GoodsInManage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpGoodsIn = new System.Windows.Forms.DateTimePicker();
            this.tbxGoodsNum = new System.Windows.Forms.TextBox();
            this.cmbGoods = new System.Windows.Forms.ComboBox();
            this.btnGoodsIn = new System.Windows.Forms.Button();
            this.tbxFilterKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpGoodsIn
            // 
            this.dtpGoodsIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpGoodsIn.Location = new System.Drawing.Point(63, 90);
            this.dtpGoodsIn.Name = "dtpGoodsIn";
            this.dtpGoodsIn.Size = new System.Drawing.Size(151, 21);
            this.dtpGoodsIn.TabIndex = 7;
            // 
            // tbxGoodsNum
            // 
            this.tbxGoodsNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxGoodsNum.Location = new System.Drawing.Point(63, 61);
            this.tbxGoodsNum.Name = "tbxGoodsNum";
            this.tbxGoodsNum.Size = new System.Drawing.Size(151, 21);
            this.tbxGoodsNum.TabIndex = 6;
            this.tbxGoodsNum.TextChanged += new System.EventHandler(this.tbxFilterKey_TextChanged);
            this.tbxGoodsNum.Leave += new System.EventHandler(this.tbxGoodsNum_Leave);
            // 
            // cmbGoods
            // 
            this.cmbGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGoods.FormattingEnabled = true;
            this.cmbGoods.Location = new System.Drawing.Point(63, 32);
            this.cmbGoods.Name = "cmbGoods";
            this.cmbGoods.Size = new System.Drawing.Size(151, 20);
            this.cmbGoods.TabIndex = 5;
            // 
            // btnGoodsIn
            // 
            this.btnGoodsIn.Location = new System.Drawing.Point(63, 119);
            this.btnGoodsIn.Name = "btnGoodsIn";
            this.btnGoodsIn.Size = new System.Drawing.Size(75, 23);
            this.btnGoodsIn.TabIndex = 8;
            this.btnGoodsIn.Text = "进货";
            this.btnGoodsIn.UseVisualStyleBackColor = true;
            this.btnGoodsIn.Click += new System.EventHandler(this.btnGoodsIn_Click);
            // 
            // tbxFilterKey
            // 
            this.tbxFilterKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilterKey.Location = new System.Drawing.Point(63, 3);
            this.tbxFilterKey.Name = "tbxFilterKey";
            this.tbxFilterKey.Size = new System.Drawing.Size(151, 21);
            this.tbxFilterKey.TabIndex = 4;
            this.tbxFilterKey.TextChanged += new System.EventHandler(this.tbxFilterKey_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmbGoods, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGoodsIn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxFilterKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpGoodsIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxGoodsNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 149);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "商品过滤";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "进货时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进货数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品选择";
            // 
            // GoodsInManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GoodsInManage";
            this.Size = new System.Drawing.Size(314, 212);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGoodsIn;
        private System.Windows.Forms.TextBox tbxGoodsNum;
        private System.Windows.Forms.ComboBox cmbGoods;
        private System.Windows.Forms.Button btnGoodsIn;
        private System.Windows.Forms.TextBox tbxFilterKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
