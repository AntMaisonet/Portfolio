using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }

        // If the User is admin, let them access the submit button
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
            
        }
        else
        {
            //If the User is not an admin, do not show the submit button
            btnSubmit.Visible = false;
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblError.Text = null;
        bool validatedState;

        /* 5/27/2020 - Realized that there was a possible issue with the Start and End dates where the app tried accepting a null value. Setting a default value for these
         DateTime objects and assigning value after the button click (if no null value is detected). Not sure why myself and my professor never caught this. 
         */

        DateTime startDate = new DateTime(2020,01,01);
        DateTime endDate = new DateTime(3030,01,01);


        if (Request["txtFirstName"].ToString().Trim() == "")
        {
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "<br />" + " * Please enter a valid first name";
            lblError.ForeColor = System.Drawing.Color.Red;
            validatedState = false;
        }

        else
        {
            txtFirstName.BackColor = System.Drawing.Color.White;
            validatedState = true;
        }


        if (Request["txtLastName"].ToString().Trim() == "")
        {
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "<br />" + " * Please enter a valid last name" + Environment.NewLine;
            lblError.ForeColor = System.Drawing.Color.Red;
            validatedState = false;
        }

        else
        {
            txtLastName.BackColor = System.Drawing.Color.White;
            validatedState = true;
        }


        if (Request["txtPayRate"].ToString().Trim() == "")
        {
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "<br />" + " * Please enter a valid pay rate";
            validatedState = false;
        }

        else
        {
            txtPayRate.BackColor = System.Drawing.Color.White;
            validatedState = true;
        }


        if (DateTime.Compare(startDate, endDate) == 0 || DateTime.Compare(startDate, endDate) > 0 || Request["txtStartDate"].ToString().Trim() == "" || Request["txtEndDate"].ToString().Trim() == "") 
        {
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text += "<br />" + " * Please enter a valid start and end date.A date must be entered for both Start and End dates";
                validatedState = false;
        }

        else
        {
            startDate = DateTime.Parse(Request["txtStartDate"]);
            endDate = DateTime.Parse(Request["txtEndDate"]);
            txtStartDate.BackColor = System.Drawing.Color.White;
            txtEndDate.BackColor = System.Drawing.Color.White;

                validatedState = true;
        }

            if (validatedState == true)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            Response.Redirect("frmPersonnelVerified.aspx");
         }

    }
}