using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace GoodsManage
{
    public partial class GoodsInManage : UserControl
    {
GoodsManageModel gmm = new GoodsManageModel();
//用户控件的构造方法
public GoodsInManage()
{
    //自动生成的控件初始化
    InitializeComponent();
    //构建lambda查询表达式，查询出所有的商品.
    //在进行绑定的时候由于商品过多，可以选择库存最少的10件商品
    var query = gmm.GoodsInfoes.
        //按照商品存货量的升序排列
        OrderBy(g => g.Num).Select(g => g.Name);
    //把商品名称绑定到商品选择下拉框中
    cmbGoods.DataSource = query.Take(10).ToList();
}
//【进货】按钮点击的处理方法，实现进货处理
private void btnGoodsIn_Click(object sender, EventArgs e)
{
    //查询出选中的商品对象
    GoodsInfo good = gmm.GoodsInfoes.Where(g => g.Name == cmbGoods.Text).First();
    //把该商品的数量进行修改,现存量加上进货量
    good.Num = good.Num + Int32.Parse(tbxGoodsNum.Text);
    //实例化一个商品进货对象
    GoodsIn gi = new GoodsIn();
    //设置商品进货对象的商品ID等于商品对象的ID
    gi.GoodsID = good.GoodsID;
    //设置商品进货对象的进货数量等于tbxGoodsNum文本框的值
    gi.Num = Int32.Parse(tbxGoodsNum.Text);
    //设置商品进货时间
    gi.InTime = dtpGoodsIn.Value;
    //把商品进货对象插入到数据库
    gmm.GoodsIns.Add(gi);
    //提交对数据库的修改
    gmm.SaveChanges();
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
//实现对数量文本框的输入有效性验证
private void tbxGoodsNum_Leave(object sender, EventArgs e)
{
    //返回验证结果,IsPositiveNumber()方法验证有效性
    bool isValidNum = IsPositiveNumber(tbxGoodsNum.Text);
    if (!isValidNum)
    {
        MessageBox.Show("不是数字或者为空，请重新输入!");
        //数量控件获取焦点
        tbxGoodsNum.Focus();
        //设置数量控件为空
        tbxGoodsNum.Text = "";
    }
}
//验证数字的有效性
public bool IsPositiveNumber(string strNumber)
{
    //用来验证整数部分的表达式
    Regex objNotPositivePattern = new Regex("[^0-9.]");
    //用来验证小数部分的表达式
    Regex objPositivePattern = new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
    //用来验证包含整数和小数的表达式
    Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
    //返回验证结果
    return objNotPositivePattern.IsMatch(strNumber) ||
    objPositivePattern.IsMatch(strNumber) ||
    objTwoDotPattern.IsMatch(strNumber);
}

    }
}
