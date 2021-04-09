using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School_DB_Web_Form
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SID.Text = Request.Cookies["studId"].Value;
            SNAME.Text = Request.Cookies["studName"].Value;
            SMOB.Text = Request.Cookies["studMob"].Value;
            SBRANCH.Text = Request.Cookies["studBranch"].Value;
        }
    }
}