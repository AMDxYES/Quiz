using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            Session["s_id"] = tb_ID.Text;
            Session["s_name"] = tb_Name.Text;
            Response.Redirect("Quiz20210511_1.aspx",false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}