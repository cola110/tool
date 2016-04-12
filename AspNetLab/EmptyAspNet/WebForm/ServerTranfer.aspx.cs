using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyAspNet.AspNet
{
    public partial class ServerTranfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Server.Transfer("http://baidu.com");
            Response.Redirect("http://www.baidu.com");
        }
    }
}