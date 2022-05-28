using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

        // User login
        dsUser dsUserLogin;

        // Creates a string that holds the Security level of the logged in user
        string SecurityLevel;

        // Verifies the user's login credentials
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);

        // Returns a false authentication if the login information is not found
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;

            // Sends an email on a failed login attempt using the class we created
            if (clsBusinessLayer.SendEmail("Ant.Maisonet@gmail.com",
            "Ant.Toby@live.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText + "\n" + 
                " Your incorrect login information was sent to Ant.Toby@live.com";
            }

            return;
        }

        // Sets the current user's security level
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        // Authenticates based on Security Level
        switch (SecurityLevel)
        {
            case "A":
                // Admin Security Level
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // User Security Level
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }

    }
}