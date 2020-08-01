using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Operand"] = null;
                Session["Num1"] = null;
                Session["Num2"] = null;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "1";
            else Session["Num2"] += "1";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "2";
            else Session["Num2"] += "2";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "3";
            else Session["Num2"] += "3";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "4";
            else Session["Num2"] += "4";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "5";
            else Session["Num2"] += "5";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "6";
            else Session["Num2"] += "6";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "7";
            else Session["Num2"] += "7";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "8";
            else Session["Num2"] += "8";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "9";
            else Session["Num2"] += "9";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += "0";
            else Session["Num2"] += "0";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["Operand"] = "+";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Session["Operand"] = "-";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Session["Operand"] = "x";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Session["Operand"] = "!";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }


        protected void Button16_Click(object sender, EventArgs e)
        {
            Session["Operand"] = "/";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2 = 0;
            decimal res = 1;

            Num1 = Convert.ToDecimal(Session["Num1"].ToString());
            if(Session["Num2"]!=null) Num2 = Convert.ToDecimal(Session["Num2"].ToString());
            if (Session["Operand"] != null && Session["Operand"].ToString() == "+")
            {
                res = Num1 + Num2;
            }
            else if (Session["Operand"] != null && Session["Operand"].ToString() == "-")
            {
                res = Num1 - Num2;
            }
            else if (Session["Operand"] != null && Session["Operand"].ToString() == "x")
            {
                res = Num1 * Num2;
            }
            else if (Session["Operand"] != null && Session["Operand"].ToString() == "/")
            {
                res = Num1 / Num2;
            }
            else if (Session["Operand"] != null && Session["Operand"].ToString() == "!")
            {

                for (int i = 1; i <= Num1; i++)
                {

                    res = res * i;
                }
                
            }
            Label2.Text = res.ToString();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (Session["Operand"] == null) Session["Num1"] += ".";
            else Session["Num2"] += ".";
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (Session["Num2"] != null && Session["Num2"].ToString() != "")
            {
                Session["Num2"] = Session["Num2"].ToString().Substring(0, Session["Num2"].ToString().Length - 1);
            }
            else if (Session["Operand"]!=null && Session["Operand"].ToString() != "") {
                Session["Operand"] = Session["Operand"].ToString().Substring(0, Session["Operand"].ToString().Length - 1);
            }
            else if (Session["Num1"]!= null && Session["Num1"].ToString() != "")
            {
                Session["Num1"] = Session["Num1"].ToString().Substring(0, Session["Num1"].ToString().Length - 1);
        }
            if (Session["Num1"] != null) Label1.Text = Session["Num1"].ToString();
            if (Session["Operand"] != null) Label1.Text += Session["Operand"].ToString();
            if (Session["Num2"] != null) Label1.Text += Session["Num2"].ToString();
        }
    }
}