using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSample
{
    public partial class DropdownSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void OnSelectionChanged(object sender, EventArgs e)
        {
            string selected = DropDownList1.SelectedItem.Value;
            Label1.Text = selected;
        }

        protected void htmlbutton1_ServerClick(object sender, EventArgs e)
        {

        }
    }
}