using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Collections;
using ClassLibraryBL;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkReportDiscrepancy : System.Web.UI.Page
    {
        Hashtable ht = new Hashtable();//记录ID和索引
        DataTable Data = new DataTable();
        LogicUnivSystemEntities lg = new LogicUnivSystemEntities();
        ProcessDiscrepancyController pdController = new ProcessDiscrepancyController();
        User u;
        protected void Page_Load(object sender, EventArgs e)
        {

            u = (User)Session["UserEntity"];

            if (ViewState["Data"] != null)
            {
                GridViewBind(this.Gv1, ViewState["Data"] as DataTable);
            }
            else
            {

                Data.Columns.Add("Cposition");
                Data.Columns.Add("UserName");
                Data.Columns.Add("JanCount");
                Data.Columns.Add("Count");
                Data.Columns.Add("FebCount");
                Data.Columns.Add("remark");

                GridViewBind(this.Gv1, Data);
                ViewState["Data"] = Data;
            }

            Data = ViewState["Data"] as DataTable;
            if (Data.Rows.Count > 0)
            {
                for (int i = 0; i < Data.Rows.Count; i++)
                {
                    //这里应该存一个唯一键 来记录索引
                    //添加这个索引是为了后面删除和更新很方便的找到
                    ht.Add(i + 1, i);
                }
            }
        }

        protected void Gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //如果不为空就取出来
            if (ViewState["Data"] != null)
            {
                Data = ViewState["Data"] as DataTable;
            }
            //取当前行ID
            int id = Convert.ToInt32((this.Gv1.Rows[e.RowIndex].FindControl("Lkb_delete") as LinkButton).CommandArgument);
            //匹配索引
            int index = Convert.ToInt32(ht[id]);
            //移除行
            this.Data.Rows.RemoveAt(index);
            //Label1.Text = index.ToString();
            //绑定数据
            GridViewBind(this.Gv1, Data);
            //保存数据
            ViewState["Data"] = Data;

        }
        protected void Btn_Add_Click(object sender, EventArgs e)
        {

            //先取出ViewState["Data"]是否为空.
            if (ViewState["Data"] != null)
            {
                Data = ViewState["Data"] as DataTable;
            }
            else
            {
                Data = CreateTable(0);
            }

            Data.Rows.Add(new object[] { this.dropdownlist_category.SelectedValue, this.dropdownlist_item.SelectedValue, this.txt_Jn.Text, this.lbl_unit.Text, this.droplist_reason.SelectedValue, this.textbox_remark.Text });//添加行
            GridViewBind(this.Gv1, Data);//绑定
            //同时加入ViewState["Data"]
            ViewState["Data"] = Data;
        }


        private DataTable CreateTable(int Count)
        {
            DataTable Data = new DataTable();
            Data.Columns.Add("Cposition");
            Data.Columns.Add("UserName");
            Data.Columns.Add("JanCount");
            Data.Columns.Add("Count");
            Data.Columns.Add("FebCount");
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    Data.Rows.Add(new object[] { "", "", "", "" });
                }
            }
            return Data;
        }

        private void GridViewBind(GridView GV, DataTable dt)
        {
            if (dt.Rows.Count != 0)
            {
                GV.DataSource = dt;
            }
            else
            {
                GV.DataSource = null;
                GV.EmptyDataText = "Please Click 'Edit' to add rows";
            }
            GV.DataBind();
        }

        protected void Gv1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandSource.GetType() == typeof(LinkButton) && e.CommandName == "ConfirmResult")
            {
                this.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('ddddd');</script>");
            }
        }

        protected void Btn_edit_Click(object sender, EventArgs e)
        {
            Object o= pdController.getCategory();
            dropdownlist_category.DataSource = o;
            dropdownlist_category.DataBind();
         
        }

        protected void dropdownlist_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            String transfer = dropdownlist_category.SelectedValue;

            Object o = pdController.getCategoryItem(transfer);
            dropdownlist_item.DataSource = o;
            dropdownlist_item.DataBind();

            String oo = pdController.getUnit(transfer);
            lbl_unit.Text = oo;

        }

        protected void Btn_confirm_Click(object sender, EventArgs e)
        {
            pdController.confirmOperation(Data,u);
        }

        protected void Gv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Gv1.PageIndex = e.NewPageIndex;
            Gv1.DataBind();

        }

        protected void btn_History_Click(object sender, EventArgs e)
        {
            btn_History.Enabled = false;
            Response.Redirect("ViewDiscrepancyHistory.aspx");
        }
        



    }
}