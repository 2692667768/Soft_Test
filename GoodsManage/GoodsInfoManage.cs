using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
namespace GoodsManage
{
    public partial class GoodsInfoManage : UserControl
    {
//定义一个数据库模型
GoodsManageModel gmm = new GoodsManageModel();
//过滤关键字
string filter = "";
public GoodsInfoManage()
{
    InitializeComponent();
    //初始化时绑定商品列表，传入空参数。
    //当参数为空串时，显示所有商品
    BindData(filter);
}
/// <summary>
/// 绑定商品列表
/// </summary>
/// <param name="key">过滤出商品名包含key的商品</param>
private void BindData(string key)
{
    //定义lambda查询表达式
    var query = gmm.GoodsInfoes.
        //对数据按GoodsID 升序排列
        OrderByDescending(g => g.GoodsID).
        //选取的记录组成新的表
        Select(n => new
        {
            //返回的GoodsID数据列名重命名为“商品编号”
            商品编号 = n.GoodsID,
            //返回的Name数据列重命名为“商品名称”
            商品名称 = n.Name
        });
    var result = query;
    //如果有过滤条件，进行过滤数据集
    if (key != "")
    {
        //从返回结果中过滤出商品名称中包含key的商品列表
        result = query.Where(p => p.商品名称.Contains(key));
    }
    //把lambda表达式的查询结果绑定到显示控件dataGridView1中
    dataGridView1.DataSource = result.ToList();
    //如果查询的结果不为空
    if (result.Count() > 0)
    {
        //商品名称文本框为商品列表中第一个商品的名称
        tbxGoodsName.Text = result.First().商品名称;
    }
    //重置过滤条件为空
    tbxKey.Text = "";
}

//【查询】按钮的点击事件的处理方法
private void btnGoodsQuery_Click(object sender, EventArgs e)
{
    //绑定数据列表
    BindData(tbxKey.Text);
}
//【添加】按钮的点击事件的处理方法
private void btnGoodsAdd_Click(object sender, EventArgs e)
{
    GoodsInfo goods = new GoodsInfo();      //定义一个商品实体对象     
    goods.Name = tbxGoodsName.Text;         //对该商品的名称赋值
    goods.Num = 0;                          //新添加的商品数量为0
    if (!goodsNameIsExit(tbxGoodsName.Text))    //检查该商品库中是否已经存在
    {
        gmm.GoodsInfoes.Add(goods);     //把该入库商品的信息添加到数据库中
        gmm.SaveChanges();                     //提交对数据库的修改
        BindData(tbxKey.Text);                  //重新绑定数据控件
        tbxGoodsName.Text = "";                 //重置商品名称
    }
}

//【修改】按钮的点击事件的处理方法
private void btnGoodsMod_Click(object sender, EventArgs e)
{
    //返回选中的当前行
    DataGridViewRow row = dataGridView1.SelectedRows[0];
    //用选中行的商品信息实例化一个商品对象
    GoodsInfo goods = findGoodsBySelectRow();
    //同时以文本框tbxGoodsName.Text修改数据显示控件中对应商品名称的值
    row.Cells[1].Value = tbxGoodsName.Text;
    //同时以文本框tbxGoodsName.Text修改商品对象名称的值
    goods.Name = tbxGoodsName.Text;
    //向数据库提交修改
    gmm.SaveChanges();
}

//【删除】按钮的点击事件的处理方法
private void btnGoodsDel_Click(object sender, EventArgs e)
{
    //用选中行的商品信息实例化一个商品对象
    GoodsInfo good = findGoodsBySelectRow();
    gmm.GoodsInfoes.Remove(good);              //删除该对象
    gmm.SaveChanges();                         //提交对数据库的操作
    BindData(tbxKey.Text);                     //重新绑定数据
}

//返回选中行对应的商品对象
private GoodsInfo findGoodsBySelectRow()
{
    //获取数据显示控件中被选中的行
    DataGridViewRow row = dataGridView1.SelectedRows[0];
    //取出选中商品对应的ID
    int id = Int32.Parse(row.Cells[0].Value.ToString());
    //以ID作为关键字，构建lambda表达式，实现查找该商品
    GoodsInfo good = gmm.GoodsInfoes.Where
        //商品ID等于ID，所有找到记录的第一个被返回
        (g => g.GoodsID == id).First();
    //返回找到的商品
    return good;
}

//数据显示控件点击单元格时的处理方法
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)  //如果鼠标点击选中行的索引>0
    {
        //取出数据显示控件dataGridView1被选中行的索引
        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //取出选中行中对应商品名称的值，赋值给tbxGoodsName文本框中
        tbxGoodsName.Text = row.Cells[1].Value.ToString();
    }
}
/// <summary>
/// 判断商品是否已经存在
/// </summary>
/// <param name="goodsName">商品名称</param>
/// <returns></returns>
private bool goodsNameIsExit(String goodsName)
{
    //定义lambda查询表达式，以goodsName输入的内容作为查询关键字
    var query = gmm.GoodsInfoes.Where(g => g.Name == goodsName);
    if (query.Count() >= 1) //判断是否查询到该商品
    {
        MessageBox.Show("该商品名称已经存在！");
        return true;
    }
    else
        return false;
}

    }
}
