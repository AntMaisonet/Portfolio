using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        // Antonio Maisonet - CIS407A - Professor Howell

        // Week 2 Lab

        // Declaring variable for the salary calculator here:

        double hours = 0;
        double payrate = 0;
        double salary = 0;

        // Converting the user input from the textboxes to our variables for calculations (both this and the above segment of code can be combined):


        // 5/27/2022 - Noticed no check for null values. Fixing this now. No error messages for validation either. Adding this as welll:
        if (Request["txtAnnualHours"].ToString().Trim() == "")
        {

        }    
        if(Request["txtPayRate"].ToString().Trim() == "")
        {

        }

        else
        {
            hours = Double.Parse(txtAnnualHours.Text);
            payrate = Double.Parse(txtPayRate.Text);

            // Calculations for the annual salary:

            salary = hours * payrate;

            // Displaying our calculations in the proper format (text with a currency format):

            lblAnnualSalary.Text = salary.ToString("C");
        }
    }
}