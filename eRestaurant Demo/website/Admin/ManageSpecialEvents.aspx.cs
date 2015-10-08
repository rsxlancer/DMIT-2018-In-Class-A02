using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageSpecialEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ProcessExceptions(object sender, ObjectDataSourceStatusEventArgs e)
    {
        if (e.Exception != null)
        {
            //we can display a message.
            MessageLabel.Text = "Unable to process the request.";
            //prevent the error being handled by the ObjectDataSource control itself
            e.ExceptionHandled = true;//I've delt with the problem
        }
    }
}