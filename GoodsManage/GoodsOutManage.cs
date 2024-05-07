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
    public partial class GoodsOutManage : UserControl
    {
//定义数据库模型
GoodsManageModel gmm = new GoodsManageModel();
//用户控件的构造方法
public GoodsOutManage()
{
    InitializeComponent();
    //定义lambda表达式，返回商品销售记录
    var query = gmm.GoodsOuts.
        //对销售的记录按销售的时间降序排列
        OrderByDescending(g => g.OutTime).
        //取关联到的商品的名称
        Select(g => g.GoodsInfo.Name);
    //给下拉框绑定最近销售的10种商品，distinct用来去除重复商品
    cmbGoods.DataSource = query.Distinct().Take(10).ToList();
}


//过滤文本框控件文本发现变化事件处理方法
private void tbxFilterKey_TextChanged(object sender, EventArgs e)
{
    //构建以tbxFilterKey.Text为关键字的查询表达式
    var query = gmm.GoodsInfoes.
        //查询条件为商品名称包含传入的关键字
        Where(g => g.Name.Contains(tbxFilterKey.Text)).
        //以升序排列返回商品名称
        OrderBy(g => g.Name).Select(g => g.Name );
    //如果查询结果为空，设置cmbGoods控件没有任何项
    if (query.Count() == 0)
    {
        cmbGoods.Text = "";
    }
    else //绑定查询结果到cmbGoods控件
    {
        cmbGoods.DataSource = query.ToList();
    }
}


//【销售】按钮的处理方法
private void btnGoodsOut_Click(object sender, EventArgs e)
{
    //返回一个商品对象，该项商品对象是用户从下拉框中选中的商品
    GoodsInfo good = gmm.GoodsInfoes.
        //查询条件为商品名称称为等于选中的商品名称
        Where(g => g.Name == cmbGoods.Text).
        //返回查询结果中的第一个对象
        First();
    //计算商品剩余数量，并赋值
    good.Num = good.Num - Int32.Parse(tbxGoodsNum.Text);
    //定义商品销售对象
    GoodsOut go = new GoodsOut();
    //售出的商品ID等于商品ID
    go.GoodsID = good.GoodsID;
    //售出数量等于文件框内设置的数量
    go.Num = Int32.Parse(tbxGoodsNum.Text);
    //设置售出时间
    go.OutTime = dtpGoodsIn.Value;
    //向数据库对象中插入该条记录
    gmm.GoodsOuts.Add(go);
    //把对数据库的修改提交给服务器
    gmm.SaveChanges();
}
    }
}
