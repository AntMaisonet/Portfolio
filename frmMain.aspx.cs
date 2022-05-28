using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Uses the "save user method" in the "clsDataLayer" class. Used to record IP addresses?
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");

        if (Session["SecurityLevel"] == "A")
        {
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;

            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;

            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;

            linkbtnManageUsers.Visible = true;
            imgbtnManageUsers.Visible = true;


        }
        else
        {
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;

            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;

            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;

            linkbtnManageUsers.Visible = false;
            imgbtnManageUsers.Visible = false;

        }
    }
}