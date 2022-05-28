using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* On the event (when the page loads), that textbox we made will get and display information
           the previous page */

        txtVerifiedInfo.Text =
            Session["txtFirstName"] + "\n" +
            Session["txtLastName"] + "\n" +
            Session["txtPayRate"] + "\n" +
            Session["txtStartDate"] + "\n" +
            Session["txtEndDate"];

        // Verifies that the information was saved
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
        Session["txtFirstName"].ToString(),
        Session["txtLastName"].ToString(),
        Session["txtPayRate"].ToString(),
        Session["txtStartDate"].ToString(),
        Session["txtEndDate"].ToString()))
        {

            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was successfully saved!";

        }

        else
        {

            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was NOT saved.";

        }

    }
}