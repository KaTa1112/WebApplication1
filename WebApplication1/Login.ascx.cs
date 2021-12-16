using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool checkUserNamePassword()
        {
            XElement korisnici = XElement.Load(@"C:\Users\katap\source\repos\WebApplication1\WebApplication1\App_Data\korisnici.xml");
            var users = from user in korisnici.Elements("korisnici") select new { username = (string)user.Element("korisnickoIme"), password = (string)user.Element("lozinka") };

            foreach (var user in users)
            {
                if (string.Compare(user.username, TextBoxUsername.Text, true) == 0
                    && user.password == TextBoxPassword.Text)
                    return true;
            }
            return false;
        }

        private void DisplayBooks()
        {
            PanelDisplay.Visible = true;
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@"C:\Users\katap\source\repos\WebApplication1\WebApplication1\App_Data\popisKnjiga.xml");
                GridViewData.DataSource = ds;
                GridViewData.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!checkUserNamePassword())
            {
                PanelError.Visible = true;
            }
            else
            {
                DisplayBooks();
            }

        }
    }
}