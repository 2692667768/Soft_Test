using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoodsManage
{
    public partial class GoodsStatic : UserControl
    {
//定义数据库模型
GoodsManageModel gmm = new GoodsManageModel();
//用户控件的构造方法
public GoodsStatic()
{
    InitializeComponent();
    //绑定要显示的少于10件存货量的商品
    bindData(int.Parse(tbNum.Text));
}
//绑定数据到数据显示控件
private void bindData(int num)
{
    //重置数据显示控件的数据为空
    dgvGoods.DataSource = null;
    //定义查询存货量小于num的商品的lambda表达式
    var query = gmm.GoodsInfoes.
        //查询条件为存货量小于num
        Where(g => g.Num < num).
        //按照num的升序排列
        OrderBy(g=>g.Num).
        //把查询结果重组为对象
        Select(g => new
        {
            //查询的商品名称的列名为：商品名称
            商品名称 = g.Name,
            //查询的商品数量的列名为：商品数量
            商品数量 = g.Num
        });
    //把查询的结果绑定到数据显示控件中
    dgvGoods.DataSource = query.ToList();
}
//文本输入框文本修改时的处理方法
private void tbNum_TextChanged(object sender, EventArgs e)
{
    int num = 0;
    try
    {
        //把用户输入的数字转化为数字类型
        num = Int32.Parse(tbNum.Text);
        //绑定数据到数据显示控件
        bindData(num);
    }
    catch
    {
        MessageBox.Show("数据格式有误，请重新输入！");
    }
}

    }
}
