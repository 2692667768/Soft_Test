using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GoodsManage
{
    public partial class GoodsManageMain : Form
    {
        public GoodsManageMain()
        {
            InitializeComponent();
            GoodsInfoManage gtm = new GoodsInfoManage();
            gtm.Dock = DockStyle.Fill;
            panel1.Controls.Add(gtm);
        }


        private void BasicInfoManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GoodsInfoManage gtm = new GoodsInfoManage();
            gtm.Dock = DockStyle.Fill;
            panel1.Controls.Add(gtm);
        }

        private void GoodsInManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GoodsInManage gim = new GoodsInManage();
            gim.Dock = DockStyle.Fill;
            panel1.Controls.Add(gim);
        }

        private void GoodsOutManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GoodsOutManage gom = new GoodsOutManage();
            gom.Dock = DockStyle.Fill;
            panel1.Controls.Add(gom);
        }

        private void GoodsManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GoodsStatic gs = new GoodsStatic();
            gs.Dock = DockStyle.Fill;
            panel1.Controls.Add(gs);
        }
    }
}
