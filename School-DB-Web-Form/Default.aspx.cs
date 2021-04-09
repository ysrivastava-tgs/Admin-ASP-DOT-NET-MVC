using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School_DB_Web_Form
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["studId"].Value = SID.Text;
            Response.Cookies["studName"].Value = SNAME.Text;
            Response.Cookies["studMob"].Value = SMOB.Text;
            Response.Cookies["studBranch"].Value = SBRANCH.Text;
        }
    }
}