using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                WebService webService = new WebService();
                int a = Convert.ToInt32(Textbox1.Text);
                int b = Convert.ToInt32(Textbox2.Text);
                Label3.Text = "\nOutput: " + webService.Add(a, b).ToString();
            }
            catch(Exception )
            {
                Label3.Text = "Wrong input format ";
            }
            
        }

        protected void Subtract_Click(object sender, EventArgs e)
        {
            try
            {
                WebService webService = new WebService();
                int a = Convert.ToInt32(Textbox1.Text);
                int b = Convert.ToInt32(Textbox2.Text);
                Label3.Text = "\nOutput: " + webService.Subtract(a, b).ToString();
            }
            catch (Exception)
            {
                Label3.Text = "Wrong input format ";
            }
            
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                WebService webService = new WebService();
                int a = Convert.ToInt32(Textbox1.Text);
                int b = Convert.ToInt32(Textbox2.Text);
                Label3.Text = "\nOutput: " + webService.Multiply(a, b).ToString();
            }
            catch (Exception)
            {
                Label3.Text = "Wrong input format ";
            }
            
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            try
            {
                WebService webService = new WebService();
                int a = Convert.ToInt32(Textbox1.Text);
                int b = Convert.ToInt32(Textbox2.Text);
                Label3.Text = "\nOutput: " + webService.Divide(a, b).ToString();
            }
            catch (Exception)
            {
                Label3.Text = "Wrong input format ";
            }
            
        }
    }
}